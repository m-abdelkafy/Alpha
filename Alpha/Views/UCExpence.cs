using System;
using System.Windows.Forms;
using Alpha.DatabaseItems;
using Alpha.Utilities;

namespace Alpha.Views
{
    public partial class UCExpence : UserControl
    {
        public UCExpence()
        {
            InitializeComponent();
        }

        private void btnExpenseCommit_Click(object sender, EventArgs e)
        {
            bool isError = false;
            isError |= ControlHelperUtil.CheckControlIfEmpty(txtExpenseName);
            isError |= ControlHelperUtil.CheckControlIfEmpty(txtExpensePrice);

            if (isError)
            {
                return;
            }

            if (txtExpensePrice.Text[txtExpensePrice.EditValue.ToString().Length - 1] == '.')
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
    }
}
