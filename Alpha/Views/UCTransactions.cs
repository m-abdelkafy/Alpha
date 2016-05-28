using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Alpha.BusinessLogic;
using Alpha.Controllers;
using Alpha.DatabaseItems;
using Alpha.Utilities;
using DevExpress.XtraEditors;

namespace Alpha.Views
{
	public partial class UCTransactions : XtraUserControl, INotify
	{
		List<Control> _requiredFieldControls = new List<Control>();

		public UCTransactions(ToolStripStatusLabel tsLbl)
		{
			InitializeComponent();
			StatusLabel = tsLbl;
		}

		public ToolStripStatusLabel StatusLabel { get; set; }private void UCTransactions_Load(object sender, EventArgs e)
		{
			comboBuyCategory.PrepareCombobox<Category>();
			comboBuySupplier.PrepareCombobox<Supplier>();
			comboSellClient.PrepareCombobox<Client>();
			comboBuyBrand.PrepareCombobox<Brand>();

			GenericHelper.EnableControls(false, tcTransactions.SelectedTab.Controls);
			GenericHelper.EnableControls(true, btnSellNew);


		}

		private void tcTransactions_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (tcTransactions.SelectedIndex == 0)
			//{
			//	Size = new Size(841, 428);
			//	tcTransactions.Size = new Size(801, 352);
			//}
			//else
			//{
			//	Size = new Size(552, 428);
			//	tcTransactions.Size = new Size(512, 352);
			//}
			GenericHelper.EnableControls(false, tcTransactions.SelectedTab.Controls);
		}
		
        #region BuyTab
		private void chkBuyMultipleSimilarItems_CheckedChanged(object sender, EventArgs e)
		{
			numBuyQuantity.Enabled = chkBuyMultipleSimilarItems.Checked;
		}
		private void chkBuyIsWarranty_CheckedChanged(object sender, EventArgs e)
		{
			if (chkBuyIsWarranty.Checked)
			{
				txtBuyWarrantyDuration.Enabled = true;
				numBuyQuantity.Value = 1;
				numBuyQuantity.Enabled = false;
				chkBuyMultipleSimilarItems.Enabled = true;
			}
			else
			{
				txtBuyWarrantyDuration.Enabled = false;
				numBuyQuantity.Enabled = true;
				chkBuyMultipleSimilarItems.Checked = false;
				chkBuyMultipleSimilarItems.Enabled = false;
			}
		}
		private void txtBuyWarrantyDuration_KeyPress(object sender, KeyPressEventArgs e)
		{
			ControlHelperUtil.NumbersOnlyString(e, txtBuyWarrantyDuration);
		}
		private void txtBuyUnitCost_KeyPress(object sender, KeyPressEventArgs e)
		{
			ControlHelperUtil.NumbersOnlyString(e, txtBuyUnitCost);
		}
		private void btnBuyCommit_Click(object sender, EventArgs e)
		{
			//             if (Properties.Settings.Default.CULTURE == "en")
			//             {
			//                 tsslStatus.Text = "Working...     ";
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
			isError |= ControlHelperUtil.CheckControlIfEmpty(txtBuyUnitCost);
			isError |= ControlHelperUtil.CheckControlIfEmpty(comboBuySupplier);

			if (isError)
			{

				//ErrorHelper.Notify(ErrorHelper.NotifyMessage.Problem, StatusLabel);
				return;
			}
			try
			{
				if (txtBuyUnitCost.Text[txtBuyUnitCost.TextLength - 1] == '.')
				{
					string s = txtBuyUnitCost.Text.TrimEnd('.');
					txtBuyUnitCost.Text = s;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			int warranty = chkBuyIsWarranty.Checked ? Convert.ToInt32(txtBuyWarrantyDuration.Text) : -1;
			int quantity = chkBuyIsWarranty.Checked ? 1 : Convert.ToInt32(numBuyQuantity.Value);

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
				int count = (int)numBuyQuantity.Value;
				for (int i = 0; i < numBuyQuantity.Value; i++)
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
		#endregion

		#region SellTab
		private void btnSellNew_Click(object sender, EventArgs e)
		{
			btnSellClearAll_Click(sender, e);
			GenericHelper.EnableControls(true, tcTransactions.SelectedTab.Controls);
			GenericHelper.EnableControls(false, btnSellCommit); lblSellID.Text = GenericHelper.GetNextId<Transaction>().ToString();
			SellTransactionController.ThisTransactionId = Convert.ToInt32(lblSellID.Text);

			ErrorHelper.SetRequiredFields(txtSellSerial, numSellQuantity, txtSellUnitPrice, comboSellClient);
		}
		private void btnSellCancel_Click(object sender, EventArgs e)
		{
			btnSellClearAll_Click(sender, e);
			GenericHelper.EnableControls(false, tcTransactions.SelectedTab.Controls);
			GenericHelper.EnableControls(true, btnSellNew);
			SellTransactionController.ThisTransactionId = 0;
			ErrorHelper.SetRequiredFields(txtSellSerial, numSellQuantity, txtSellUnitPrice, comboSellClient);
		}
		private void btnSellClearAll_Click(object sender, EventArgs e)
		{
			txtSellSerial.Text = string.Empty;
			numSellQuantity.Text = string.Empty;
			txtSellUnitPrice.Text = string.Empty;
			comboSellClient.SelectedIndex = -1;
			dgvSellCurrentInvoice.DataSource = null;
			dgvSellCurrentInvoice.Refresh();
			dgvSellItemInfo.DataSource = null;
			dgvSellItemInfo.Refresh();
			lblSellID.Text = string.Empty;

			ErrorHelper.SetRequiredFields(txtSellSerial, numSellQuantity, txtSellUnitPrice, comboSellClient);
		}
		private void txtSellSerial_Leave(object sender, EventArgs e)
		{
			//ErrorHelper.CheckItemBySerial(GenericHelper.CheckItemExists(txtSellSerial.Text),
			//	txtSellSerial, dgvSellItemInfo);
		}
		private void btnSellAddToInvoice_Click(object sender, EventArgs e)
		{
			if (!ErrorHelper.ValidateRequiredField()) return;

			//SellTransactionController.AddItemToInvoice(Convert.ToInt32(lblSellID.Text),
			//	txtSellSerial.Text,
			//	Convert.ToInt32(numSellQuantity.Text),
			//	Convert.ToDecimal(txtSellUnitPrice.Text),
			//	Convert.ToInt32(comboSellClient.SelectedValue),
			//	chkIsNotFinal.Checked);
		}
		private void txtSellUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			ControlHelperUtil.NumbersOnlyString(e, txtSellUnitPrice);
		}
		private void numSellQuantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			ControlHelperUtil.NumbersOnlyString(e, numSellQuantity);
		}
		private void btnSellCommit_Click(object sender, EventArgs e)
		{
			if (SellTransactionController.CommitTransaction())
			{
				btnSellAddToInvoice.Enabled = true;
			}
		}
		private void btnSellInvoiceAndPrint_Click(object sender, EventArgs e)
		{
			SellTransactionController.CommitAndPrintTransaction();
		}

		#endregion

		#region ExpenseTab
		private void btnCommitExpense_Click(object sender, EventArgs e)
		{
			bool isError = false;
			isError |= ControlHelperUtil.CheckControlIfEmpty(txtExpenseName);
			isError |= ControlHelperUtil.CheckControlIfEmpty(txtExpensePrice);

			if (isError)
			{
				return;
			}

			if (txtExpensePrice.Text[txtExpensePrice.TextLength - 1] == '.')
			{
				string s = txtExpensePrice.Text.TrimEnd('.');
				txtExpensePrice.Text = s;
			}

			DatabaseTransactions.ExpenseTransaction(txtExpenseName.Text, Convert.ToDecimal(txtExpensePrice.Text));

			//             if (Properties.Settings.Default.CULTURE == "en")
			//             {
			//                 Helpers.Notify("Expense added successfuly     ", tsslStatus);
			//             }
			//             else if (Properties.Settings.Default.CULTURE == "ar")
			//             {
			//                 Helpers.Notify("تم اضافة مصروف بنجاح     ", tsslStatus);
			//             }
		}

		private void txtExpensePrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			ControlHelperUtil.NumbersOnlyString(e, txtExpensePrice);
		}

        #endregion

        private void btnBuyAddNewCategory_Click(object sender, EventArgs e)
        {

        }
    }
}