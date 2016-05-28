using System;
using System.Windows.Forms;
using Alpha.Utilities;
using Alpha.Views;

namespace Alpha.Forms
{
    public partial class MainForm : Form, INotify
    {
        private static ToolStripStatusLabel _statusLabel = new ToolStripStatusLabel();
        public ToolStripStatusLabel StatusLabel
        {
            get { return _statusLabel; }
            set { _statusLabel = value; }
        }

        private readonly UCBuy _ucBuy = new UCBuy();
        private readonly UCSell _ucSell = new UCSell();
        private readonly UCExpence _ucExpense = new UCExpence();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ApplicationHelperUtil.ExitApplication();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationHelperUtil.ExitApplication();
        }


        #region Buttons
        #region Daily Transactions
        private void btnSell_CheckedChanged(object sender, EventArgs e)
        {
            xucMain.Controls.Clear();
            if (_ucSell != null) xucMain.Controls.Add(_ucSell);
        }

        private void btnBuy_CheckedChanged(object sender, EventArgs e)
        {
            xucMain.Controls.Clear();
            if (_ucBuy != null) xucMain.Controls.Add(_ucBuy);
        }

        private void btnExpenses_CheckedChanged(object sender, EventArgs e)
        {
            xucMain.Controls.Clear();
            if (_ucExpense != null) xucMain.Controls.Add(_ucExpense);
        }
        #endregion

        #region Search
        private void btnSearchItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchTransaction_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion


    }
}
