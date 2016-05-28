using System;
using System.Windows.Forms;
using Alpha.BusinessLogic;
using Alpha.Utilities;

namespace Alpha.Views
{
    public partial class UCBuy : UserControl
    {
        public ToolStripStatusLabel StatusLabel { get; set; }

        public UCBuy()
        {
            InitializeComponent();
        }

        private void chkBuyMultipleSimilarItems_CheckedChanged(object sender, EventArgs e)
        {
            spinBuyQuantity.Enabled = chkBuyMultipleSimilarItems.Checked;
        }
        private void chkBuyIsWarranty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyIsWarranty.Checked)
            {
                txtBuyWarrantyDuration.Enabled = true;
                spinBuyQuantity.Value = 1;
                spinBuyQuantity.Enabled = false;
                chkBuyMultipleSimilarItems.Enabled = true;
            }
            else
            {
                txtBuyWarrantyDuration.Enabled = false;
                spinBuyQuantity.Enabled = true;
                chkBuyMultipleSimilarItems.Checked = false;
                chkBuyMultipleSimilarItems.Enabled = false;
            }
        }
        private void txtBuyWarrantyDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHelperUtil.NumbersOnlyString(e, txtBuyWarrantyDuration);
        }
        private void txtBuyUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHelperUtil.NumbersOnlyString(e, txtBuyUnitPrice);
        }
        private void btnBuyCommit_Click(object sender, EventArgs e)
        {
            //             if (Properties.Settings.Default.CULTURE == "en")
            //             {//                 tsslStatus.Text = "Working...     ";
            //             }
            //             else if (Properties.Settings.Default.CULTURE == "ar")
            //             {
            //                 tsslStatus.Text = "جاري العمل...     ";
            //             }

            bool isError = false;

            isError |= ControlHelperUtil.CheckControlIfEmpty(txtBuySerial);
            isError |= ControlHelperUtil.CheckControlIfEmpty(comboBuyCategory);
            isError |= ControlHelperUtil.CheckControlIfEmpty(comboBuyBrand);
            isError |= ControlHelperUtil.CheckControlIfEmpty(txtBuyWarrantyDuration, 25);
            isError |= ControlHelperUtil.CheckControlIfEmpty(txtBuyUnitPrice);
            isError |= ControlHelperUtil.CheckControlIfEmpty(comboBuySupplier);

            if (isError)
            {

                //ErrorHelper.Notify(ErrorHelper.NotifyMessage.Problem, StatusLabel);
                return;
            }
            try
            {
                if (txtBuyUnitPrice.Text[txtBuyUnitPrice.EditValue.ToString().Length - 1] == '.')
                {
                    string s = txtBuyUnitPrice.Text.TrimEnd('.');
                    txtBuyUnitPrice.Text = s;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            int warranty = chkBuyIsWarranty.Checked ? Convert.ToInt32(txtBuyWarrantyDuration.Text) : -1;
            int quantity = chkBuyIsWarranty.Checked ? 1 : Convert.ToInt32(spinBuyQuantity.Value);

            int error = 1;

            if (chkBuyMultipleSimilarItems.Checked == false)
            {
                //error = DatabaseTransactions.BuyTransaction(txtBuySerial.Text,
                //comboCategory.SelectedValue.ToString(), comboBrand.SelectedValue.ToString(),
                //checkBoxUsed.Checked, comboSupplier.SelectedValue.ToString(),
                //Convert.ToDecimal(txtBuyUnitCost.Text), warranty, quantity);
            }
            else
            {
                int count = (int)spinBuyQuantity.Value;
                for (int i = 0; i < spinBuyQuantity.Value; i++)
                {
                    if (error == 1)
                    {
                        //error = DatabaseTransactions.BuyTransaction(txtBuySerial.Text,
                        //        comboCategory.SelectedValue.ToString(), comboBrand.SelectedValue.ToString(),
                        //        checkBoxUsed.Checked, comboSupplier.SelectedValue.ToString(),
                        //        Convert.ToDecimal(txtBuyUnitCost.Text), warranty, quantity);
                        count--;
                    }
                }
            }

            if (error == 0)
            {

                //ErrorHelper.Notify(ErrorHelper.NotifyMessage.Problem, StatusLabel);

                return;
            }

            ErrorHelper.Notify(ErrorHelper.NotifyMessage.BoughtSuccessfully, StatusLabel);

        }
        private void btnBuyCommitAndPrint_Click(object sender, EventArgs e)
        {
            btnBuyCommit_Click(sender, e);

            /////////////////////
            ///Print code here///
            /////////////////////
        }
    }
}
