using System;
using System.Windows.Forms;
using System.Data.Entity;
using Alpha.BusinessLogic;
using Alpha.Controllers;
using Alpha.DatabaseItems;
using Alpha.Utilities;

namespace Alpha.Views
{
    public partial class UCSell : UserControl
    {
        private static int _currentItemId;
        //TODO: Get item price in second grid view!
        public UCSell()
        {
            InitializeComponent();
            IV_ACEntities dbContext = DatabaseManager.CreateConnection();
            dbContext.ItemTransaction.Load();
            bindingSource1.DataSource = dbContext.ItemTransaction.Local.ToBindingList();
        }

        private void UCSell_Load(object sender, EventArgs e)
        {
            comboSellClient.PrepareCombobox<Client>();

            GenericHelper.EnableControls(false, Controls);
            GenericHelper.EnableControls(true, btnSellNew);
            SellTransactionController.ThisTransactionId = 0;
            ErrorHelper.SetRequiredFields(txtSellSerial, numSellQuantity, txtSellUnitPrice, comboSellClient);
        }

        private void btnSellAddNewClient_Click(object sender, EventArgs e)
        {

        }

        private void btnSellNew_Click(object sender, EventArgs e)
        {
            btnSellClearAll_Click(sender, e);
            GenericHelper.EnableControls(true, Controls);
            GenericHelper.EnableControls(false, btnSellCommit);
            txtNextId.Text = GenericHelper.GetNextId<Transaction>().ToString();
            SellTransactionController.ThisTransactionId = Convert.ToInt32(txtNextId.Text);
        }
        private void btnSellClearAll_Click(object sender, EventArgs e)
        {
            txtSellSerial.Text = string.Empty;
            numSellQuantity.Text = string.Empty;
            txtSellUnitPrice.Text = string.Empty;
            comboSellClient.SelectedIndex = -1;
            grdSell.DataSource = null;
            grdSell.Refresh();
            txtNextId.Text = string.Empty;

            ErrorHelper.ClearErrorPopupsFromControls(txtSellSerial, numSellQuantity, txtSellUnitPrice, comboSellClient);
        }

        private void btnSellCancel_Click(object sender, EventArgs e)
        {
            btnSellClearAll_Click(sender, e);
            UCSell_Load(sender, e);
        }

        private void btnSellCommit_Click(object sender, EventArgs e)
        {
            if (SellTransactionController.CommitTransaction())
            {
                btnSellAddToInvoice.Enabled = true;
            }
        }

        private void btnSellAddToInvoice_Click(object sender, EventArgs e)
        {
            if (!ErrorHelper.ValidateRequiredField()) return;

            SellTransactionController.AddItemToInvoice(Convert.ToInt32(txtNextId.Text),
                _currentItemId,
                Convert.ToInt32(numSellQuantity.Text),
                Convert.ToDecimal(txtSellUnitPrice.Text),
                chkIsNotFinal.Checked);

            GenericHelper.EnableControls(true, btnSellCommit);
        }
        private void btnSellCommitAndPrint_Click(object sender, EventArgs e)
        {
            SellTransactionController.CommitAndPrintTransaction();
        }

       private void txtSellSerial_TextChanged(object sender, EventArgs e)
        {
            _currentItemId = ErrorHelper.CheckItemBySerial(GenericHelper.CheckItemExists(txtSellSerial.Text),
                txtSellSerial, grdCurrentItem);
        }
    }
}