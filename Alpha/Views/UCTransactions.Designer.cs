using System.ComponentModel;
using System.Windows.Forms;

namespace Alpha.Views
{
    partial class UCTransactions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcTransactions = new System.Windows.Forms.TabControl();
            this.tpSell = new System.Windows.Forms.TabPage();
            this.chkIsNotFinal = new System.Windows.Forms.CheckBox();
            this.lblSellID = new System.Windows.Forms.Label();
            this.btnSellCancel = new System.Windows.Forms.Button();
            this.btnSellNew = new System.Windows.Forms.Button();
            this.btnSellClearAll = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvSellCurrentInvoice = new System.Windows.Forms.DataGridView();
            this.btnSellCommitAndPrint = new System.Windows.Forms.Button();
            this.dgvSellItemInfo = new System.Windows.Forms.DataGridView();
            this.btnSellCommit = new System.Windows.Forms.Button();
            this.btnSellAddToInvoice = new System.Windows.Forms.Button();
            this.numSellQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboSellClient = new System.Windows.Forms.ComboBox();
            this.btnSellAddNewClient = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSellUnitPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSellSerial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpBuy = new System.Windows.Forms.TabPage();
            this.chkBuyMultipleSimilarItems = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuyCommitAndPrint = new System.Windows.Forms.Button();
            this.btnBuyCommit = new System.Windows.Forms.Button();
            this.numBuyQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboBuySupplier = new System.Windows.Forms.ComboBox();
            this.btnBuyAddNewSupplier = new System.Windows.Forms.Button();
            this.btnBuyAddNewBrand = new System.Windows.Forms.Button();
            this.btnBuyAddNewCategory = new System.Windows.Forms.Button();
            this.txtBuySerial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIsUsed = new System.Windows.Forms.CheckBox();
            this.txtBuyUnitCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBuyIsWarranty = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuyWarrantyDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBuyBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBuyCategory = new System.Windows.Forms.ComboBox();
            this.tpExpense = new System.Windows.Forms.TabPage();
            this.txtExpenseNameArabic = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnExpenseCommit = new System.Windows.Forms.Button();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExpensePrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tcTransactions.SuspendLayout();
            this.tpSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellCurrentInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellItemInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellQuantity)).BeginInit();
            this.tpBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyQuantity)).BeginInit();
            this.tpExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTransactions
            // 
            this.tcTransactions.Controls.Add(this.tpSell);
            this.tcTransactions.Controls.Add(this.tpBuy);
            this.tcTransactions.Controls.Add(this.tpExpense);
            this.tcTransactions.Location = new System.Drawing.Point(3, 3);
            this.tcTransactions.Name = "tcTransactions";
            this.tcTransactions.SelectedIndex = 0;
            this.tcTransactions.Size = new System.Drawing.Size(1045, 478);
            this.tcTransactions.TabIndex = 2;
            this.tcTransactions.SelectedIndexChanged += new System.EventHandler(this.tcTransactions_SelectedIndexChanged);
            // 
            // tpSell
            // 
            this.tpSell.Controls.Add(this.chkIsNotFinal);
            this.tpSell.Controls.Add(this.lblSellID);
            this.tpSell.Controls.Add(this.btnSellCancel);
            this.tpSell.Controls.Add(this.btnSellNew);
            this.tpSell.Controls.Add(this.btnSellClearAll);
            this.tpSell.Controls.Add(this.label15);
            this.tpSell.Controls.Add(this.label14);
            this.tpSell.Controls.Add(this.dgvSellCurrentInvoice);
            this.tpSell.Controls.Add(this.btnSellCommitAndPrint);
            this.tpSell.Controls.Add(this.dgvSellItemInfo);
            this.tpSell.Controls.Add(this.btnSellCommit);
            this.tpSell.Controls.Add(this.btnSellAddToInvoice);
            this.tpSell.Controls.Add(this.numSellQuantity);
            this.tpSell.Controls.Add(this.comboSellClient);
            this.tpSell.Controls.Add(this.btnSellAddNewClient);
            this.tpSell.Controls.Add(this.label11);
            this.tpSell.Controls.Add(this.txtSellUnitPrice);
            this.tpSell.Controls.Add(this.label10);
            this.tpSell.Controls.Add(this.label9);
            this.tpSell.Controls.Add(this.txtSellSerial);
            this.tpSell.Controls.Add(this.label8);
            this.tpSell.Location = new System.Drawing.Point(4, 22);
            this.tpSell.Name = "tpSell";
            this.tpSell.Padding = new System.Windows.Forms.Padding(3);
            this.tpSell.Size = new System.Drawing.Size(1037, 452);
            this.tpSell.TabIndex = 0;
            this.tpSell.Text = "Sell";
            this.tpSell.UseVisualStyleBackColor = true;
            // 
            // chkIsNotFinal
            // 
            this.chkIsNotFinal.AutoSize = true;
            this.chkIsNotFinal.Location = new System.Drawing.Point(76, 204);
            this.chkIsNotFinal.Name = "chkIsNotFinal";
            this.chkIsNotFinal.Size = new System.Drawing.Size(90, 17);
            this.chkIsNotFinal.TabIndex = 37;
            this.chkIsNotFinal.Text = "Item not final";
            this.chkIsNotFinal.UseVisualStyleBackColor = true;
            // 
            // lblSellID
            // 
            this.lblSellID.AutoSize = true;
            this.lblSellID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSellID.Location = new System.Drawing.Point(118, 9);
            this.lblSellID.Name = "lblSellID";
            this.lblSellID.Size = new System.Drawing.Size(0, 14);
            this.lblSellID.TabIndex = 36;
            // 
            // btnSellCancel
            // 
            this.btnSellCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellCancel.Location = new System.Drawing.Point(159, 33);
            this.btnSellCancel.Name = "btnSellCancel";
            this.btnSellCancel.Size = new System.Drawing.Size(75, 21);
            this.btnSellCancel.TabIndex = 35;
            this.btnSellCancel.Text = "Cance&l";
            this.btnSellCancel.UseVisualStyleBackColor = true;
            this.btnSellCancel.Click += new System.EventHandler(this.btnSellCancel_Click);
            // 
            // btnSellNew
            // 
            this.btnSellNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellNew.Location = new System.Drawing.Point(157, 6);
            this.btnSellNew.Name = "btnSellNew";
            this.btnSellNew.Size = new System.Drawing.Size(77, 21);
            this.btnSellNew.TabIndex = 34;
            this.btnSellNew.Text = "&New";
            this.btnSellNew.UseVisualStyleBackColor = true;
            this.btnSellNew.Click += new System.EventHandler(this.btnSellNew_Click);
            // 
            // btnSellClearAll
            // 
            this.btnSellClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSellClearAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSellClearAll.Location = new System.Drawing.Point(122, 315);
            this.btnSellClearAll.Name = "btnSellClearAll";
            this.btnSellClearAll.Size = new System.Drawing.Size(112, 53);
            this.btnSellClearAll.TabIndex = 33;
            this.btnSellClearAll.Text = "&Clear All";
            this.btnSellClearAll.UseVisualStyleBackColor = true;
            this.btnSellClearAll.Click += new System.EventHandler(this.btnSellClearAll_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(6, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Item info:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(247, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "This invoice:";
            // 
            // dgvSellCurrentInvoice
            // 
            this.dgvSellCurrentInvoice.AllowUserToAddRows = false;
            this.dgvSellCurrentInvoice.AllowUserToDeleteRows = false;
            this.dgvSellCurrentInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellCurrentInvoice.Location = new System.Drawing.Point(250, 30);
            this.dgvSellCurrentInvoice.Name = "dgvSellCurrentInvoice";
            this.dgvSellCurrentInvoice.ReadOnly = true;
            this.dgvSellCurrentInvoice.Size = new System.Drawing.Size(781, 338);
            this.dgvSellCurrentInvoice.TabIndex = 29;
            // 
            // btnSellCommitAndPrint
            // 
            this.btnSellCommitAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSellCommitAndPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSellCommitAndPrint.Location = new System.Drawing.Point(6, 320);
            this.btnSellCommitAndPrint.Name = "btnSellCommitAndPrint";
            this.btnSellCommitAndPrint.Size = new System.Drawing.Size(112, 48);
            this.btnSellCommitAndPrint.TabIndex = 27;
            this.btnSellCommitAndPrint.Text = "Commit and &Print";
            this.btnSellCommitAndPrint.UseVisualStyleBackColor = true;
            this.btnSellCommitAndPrint.Click += new System.EventHandler(this.btnSellInvoiceAndPrint_Click);
            // 
            // dgvSellItemInfo
            // 
            this.dgvSellItemInfo.AllowUserToAddRows = false;
            this.dgvSellItemInfo.AllowUserToDeleteRows = false;
            this.dgvSellItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellItemInfo.Location = new System.Drawing.Point(6, 387);
            this.dgvSellItemInfo.Name = "dgvSellItemInfo";
            this.dgvSellItemInfo.ReadOnly = true;
            this.dgvSellItemInfo.Size = new System.Drawing.Size(1025, 59);
            this.dgvSellItemInfo.TabIndex = 26;
            // 
            // btnSellCommit
            // 
            this.btnSellCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSellCommit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSellCommit.Location = new System.Drawing.Point(6, 266);
            this.btnSellCommit.Name = "btnSellCommit";
            this.btnSellCommit.Size = new System.Drawing.Size(112, 48);
            this.btnSellCommit.TabIndex = 25;
            this.btnSellCommit.Text = "&Commit";
            this.btnSellCommit.UseVisualStyleBackColor = true;
            this.btnSellCommit.Click += new System.EventHandler(this.btnSellCommit_Click);
            // 
            // btnSellAddToInvoice
            // 
            this.btnSellAddToInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSellAddToInvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSellAddToInvoice.Location = new System.Drawing.Point(122, 266);
            this.btnSellAddToInvoice.Name = "btnSellAddToInvoice";
            this.btnSellAddToInvoice.Size = new System.Drawing.Size(112, 48);
            this.btnSellAddToInvoice.TabIndex = 24;
            this.btnSellAddToInvoice.Text = "&Add to invoice";
            this.btnSellAddToInvoice.UseVisualStyleBackColor = true;
            this.btnSellAddToInvoice.Click += new System.EventHandler(this.btnSellAddToInvoice_Click);
            // 
            // numSellQuantity
            // 
            this.numSellQuantity.Location = new System.Drawing.Point(76, 124);
            this.numSellQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSellQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSellQuantity.Name = "numSellQuantity";
            this.numSellQuantity.Size = new System.Drawing.Size(158, 21);
            this.numSellQuantity.TabIndex = 23;
            this.numSellQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSellQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numSellQuantity_KeyPress);
            // 
            // comboSellClient
            // 
            this.comboSellClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSellClient.FormattingEnabled = true;
            this.comboSellClient.Location = new System.Drawing.Point(76, 177);
            this.comboSellClient.Name = "comboSellClient";
            this.comboSellClient.Size = new System.Drawing.Size(132, 21);
            this.comboSellClient.TabIndex = 22;
            // 
            // btnSellAddNewClient
            // 
            this.btnSellAddNewClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSellAddNewClient.Location = new System.Drawing.Point(214, 177);
            this.btnSellAddNewClient.Name = "btnSellAddNewClient";
            this.btnSellAddNewClient.Size = new System.Drawing.Size(20, 21);
            this.btnSellAddNewClient.TabIndex = 21;
            this.btnSellAddNewClient.Text = "+";
            this.btnSellAddNewClient.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(32, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Client:";
            // 
            // txtSellUnitPrice
            // 
            this.txtSellUnitPrice.Location = new System.Drawing.Point(76, 150);
            this.txtSellUnitPrice.MaxLength = 7;
            this.txtSellUnitPrice.Name = "txtSellUnitPrice";
            this.txtSellUnitPrice.Size = new System.Drawing.Size(158, 21);
            this.txtSellUnitPrice.TabIndex = 16;
            this.txtSellUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellUnitPrice_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(14, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Unit price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(17, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Quantity:";
            // 
            // txtSellSerial
            // 
            this.txtSellSerial.Location = new System.Drawing.Point(76, 97);
            this.txtSellSerial.MaxLength = 20;
            this.txtSellSerial.Name = "txtSellSerial";
            this.txtSellSerial.Size = new System.Drawing.Size(158, 21);
            this.txtSellSerial.TabIndex = 12;
            this.txtSellSerial.Leave += new System.EventHandler(this.txtSellSerial_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(33, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Serial:";
            // 
            // tpBuy
            // 
            this.tpBuy.Controls.Add(this.chkBuyMultipleSimilarItems);
            this.tpBuy.Controls.Add(this.label5);
            this.tpBuy.Controls.Add(this.btnBuyCommitAndPrint);
            this.tpBuy.Controls.Add(this.btnBuyCommit);
            this.tpBuy.Controls.Add(this.numBuyQuantity);
            this.tpBuy.Controls.Add(this.comboBuySupplier);
            this.tpBuy.Controls.Add(this.btnBuyAddNewSupplier);
            this.tpBuy.Controls.Add(this.btnBuyAddNewBrand);
            this.tpBuy.Controls.Add(this.btnBuyAddNewCategory);
            this.tpBuy.Controls.Add(this.txtBuySerial);
            this.tpBuy.Controls.Add(this.label7);
            this.tpBuy.Controls.Add(this.label6);
            this.tpBuy.Controls.Add(this.chkIsUsed);
            this.tpBuy.Controls.Add(this.txtBuyUnitCost);
            this.tpBuy.Controls.Add(this.label4);
            this.tpBuy.Controls.Add(this.chkBuyIsWarranty);
            this.tpBuy.Controls.Add(this.label3);
            this.tpBuy.Controls.Add(this.txtBuyWarrantyDuration);
            this.tpBuy.Controls.Add(this.label2);
            this.tpBuy.Controls.Add(this.comboBuyBrand);
            this.tpBuy.Controls.Add(this.label1);
            this.tpBuy.Controls.Add(this.comboBuyCategory);
            this.tpBuy.Location = new System.Drawing.Point(4, 22);
            this.tpBuy.Name = "tpBuy";
            this.tpBuy.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuy.Size = new System.Drawing.Size(1037, 452);
            this.tpBuy.TabIndex = 1;
            this.tpBuy.Text = "Buy";
            this.tpBuy.UseVisualStyleBackColor = true;
            // 
            // chkBuyMultipleSimilarItems
            // 
            this.chkBuyMultipleSimilarItems.AutoSize = true;
            this.chkBuyMultipleSimilarItems.Enabled = false;
            this.chkBuyMultipleSimilarItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBuyMultipleSimilarItems.Location = new System.Drawing.Point(254, 132);
            this.chkBuyMultipleSimilarItems.Name = "chkBuyMultipleSimilarItems";
            this.chkBuyMultipleSimilarItems.Size = new System.Drawing.Size(15, 14);
            this.chkBuyMultipleSimilarItems.TabIndex = 24;
            this.chkBuyMultipleSimilarItems.UseVisualStyleBackColor = true;
            this.chkBuyMultipleSimilarItems.CheckedChanged += new System.EventHandler(this.chkBuyMultipleSimilarItems_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(42, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Unit price:";
            // 
            // btnBuyCommitAndPrint
            // 
            this.btnBuyCommitAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuyCommitAndPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuyCommitAndPrint.Location = new System.Drawing.Point(128, 246);
            this.btnBuyCommitAndPrint.Name = "btnBuyCommitAndPrint";
            this.btnBuyCommitAndPrint.Size = new System.Drawing.Size(121, 74);
            this.btnBuyCommitAndPrint.TabIndex = 22;
            this.btnBuyCommitAndPrint.Text = "Commit and &Print";
            this.btnBuyCommitAndPrint.UseVisualStyleBackColor = true;
            this.btnBuyCommitAndPrint.Click += new System.EventHandler(this.btnBuyCommitAndPrint_Click);
            // 
            // btnBuyCommit
            // 
            this.btnBuyCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuyCommit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuyCommit.Location = new System.Drawing.Point(6, 246);
            this.btnBuyCommit.Name = "btnBuyCommit";
            this.btnBuyCommit.Size = new System.Drawing.Size(116, 74);
            this.btnBuyCommit.TabIndex = 21;
            this.btnBuyCommit.Text = "&Commit";
            this.btnBuyCommit.UseVisualStyleBackColor = true;
            this.btnBuyCommit.Click += new System.EventHandler(this.btnBuyCommit_Click);
            // 
            // numBuyQuantity
            // 
            this.numBuyQuantity.Location = new System.Drawing.Point(103, 130);
            this.numBuyQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numBuyQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBuyQuantity.Name = "numBuyQuantity";
            this.numBuyQuantity.Size = new System.Drawing.Size(145, 21);
            this.numBuyQuantity.TabIndex = 20;
            this.numBuyQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBuySupplier
            // 
            this.comboBuySupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuySupplier.FormattingEnabled = true;
            this.comboBuySupplier.Location = new System.Drawing.Point(103, 205);
            this.comboBuySupplier.Name = "comboBuySupplier";
            this.comboBuySupplier.Size = new System.Drawing.Size(145, 21);
            this.comboBuySupplier.TabIndex = 19;
            // 
            // btnBuyAddNewSupplier
            // 
            this.btnBuyAddNewSupplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuyAddNewSupplier.Location = new System.Drawing.Point(255, 205);
            this.btnBuyAddNewSupplier.Name = "btnBuyAddNewSupplier";
            this.btnBuyAddNewSupplier.Size = new System.Drawing.Size(20, 21);
            this.btnBuyAddNewSupplier.TabIndex = 18;
            this.btnBuyAddNewSupplier.Text = "+";
            this.btnBuyAddNewSupplier.UseVisualStyleBackColor = true;
            // 
            // btnBuyAddNewBrand
            // 
            this.btnBuyAddNewBrand.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuyAddNewBrand.Location = new System.Drawing.Point(255, 77);
            this.btnBuyAddNewBrand.Name = "btnBuyAddNewBrand";
            this.btnBuyAddNewBrand.Size = new System.Drawing.Size(20, 21);
            this.btnBuyAddNewBrand.TabIndex = 17;
            this.btnBuyAddNewBrand.Text = "+";
            this.btnBuyAddNewBrand.UseVisualStyleBackColor = true;
            // 
            // btnBuyAddNewCategory
            // 
            this.btnBuyAddNewCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuyAddNewCategory.Location = new System.Drawing.Point(255, 49);
            this.btnBuyAddNewCategory.Name = "btnBuyAddNewCategory";
            this.btnBuyAddNewCategory.Size = new System.Drawing.Size(20, 21);
            this.btnBuyAddNewCategory.TabIndex = 16;
            this.btnBuyAddNewCategory.Text = "+";
            this.btnBuyAddNewCategory.UseVisualStyleBackColor = true;
            this.btnBuyAddNewCategory.Click += new System.EventHandler(this.btnBuyAddNewCategory_Click);
            // 
            // txtBuySerial
            // 
            this.txtBuySerial.Location = new System.Drawing.Point(103, 24);
            this.txtBuySerial.Name = "txtBuySerial";
            this.txtBuySerial.Size = new System.Drawing.Size(172, 21);
            this.txtBuySerial.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(61, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Serial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(49, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Supplier:";
            // 
            // chkIsUsed
            // 
            this.chkIsUsed.AutoSize = true;
            this.chkIsUsed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkIsUsed.Location = new System.Drawing.Point(103, 182);
            this.chkIsUsed.Name = "chkIsUsed";
            this.chkIsUsed.Size = new System.Drawing.Size(50, 17);
            this.chkIsUsed.TabIndex = 11;
            this.chkIsUsed.Text = "Used";
            this.chkIsUsed.UseVisualStyleBackColor = true;
            // 
            // txtBuyUnitCost
            // 
            this.txtBuyUnitCost.Location = new System.Drawing.Point(103, 156);
            this.txtBuyUnitCost.MaxLength = 7;
            this.txtBuyUnitCost.Name = "txtBuyUnitCost";
            this.txtBuyUnitCost.Size = new System.Drawing.Size(146, 21);
            this.txtBuyUnitCost.TabIndex = 10;
            this.txtBuyUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyUnitCost_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(48, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // chkBuyIsWarranty
            // 
            this.chkBuyIsWarranty.AutoSize = true;
            this.chkBuyIsWarranty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBuyIsWarranty.Location = new System.Drawing.Point(255, 106);
            this.chkBuyIsWarranty.Name = "chkBuyIsWarranty";
            this.chkBuyIsWarranty.Size = new System.Drawing.Size(15, 14);
            this.chkBuyIsWarranty.TabIndex = 6;
            this.chkBuyIsWarranty.UseVisualStyleBackColor = true;
            this.chkBuyIsWarranty.CheckedChanged += new System.EventHandler(this.chkBuyIsWarranty_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Warranty duration:";
            // 
            // txtBuyWarrantyDuration
            // 
            this.txtBuyWarrantyDuration.Enabled = false;
            this.txtBuyWarrantyDuration.Location = new System.Drawing.Point(103, 104);
            this.txtBuyWarrantyDuration.MaxLength = 2;
            this.txtBuyWarrantyDuration.Name = "txtBuyWarrantyDuration";
            this.txtBuyWarrantyDuration.Size = new System.Drawing.Size(146, 21);
            this.txtBuyWarrantyDuration.TabIndex = 5;
            this.txtBuyWarrantyDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyWarrantyDuration_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(59, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand:";
            // 
            // comboBuyBrand
            // 
            this.comboBuyBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuyBrand.FormattingEnabled = true;
            this.comboBuyBrand.Location = new System.Drawing.Point(103, 77);
            this.comboBuyBrand.Name = "comboBuyBrand";
            this.comboBuyBrand.Size = new System.Drawing.Size(146, 21);
            this.comboBuyBrand.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category:";
            // 
            // comboBuyCategory
            // 
            this.comboBuyCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuyCategory.FormattingEnabled = true;
            this.comboBuyCategory.Location = new System.Drawing.Point(103, 50);
            this.comboBuyCategory.Name = "comboBuyCategory";
            this.comboBuyCategory.Size = new System.Drawing.Size(146, 21);
            this.comboBuyCategory.TabIndex = 0;
            // 
            // tpExpense
            // 
            this.tpExpense.Controls.Add(this.txtExpenseNameArabic);
            this.tpExpense.Controls.Add(this.label16);
            this.tpExpense.Controls.Add(this.btnExpenseCommit);
            this.tpExpense.Controls.Add(this.txtExpenseName);
            this.tpExpense.Controls.Add(this.label13);
            this.tpExpense.Controls.Add(this.txtExpensePrice);
            this.tpExpense.Controls.Add(this.label12);
            this.tpExpense.Location = new System.Drawing.Point(4, 22);
            this.tpExpense.Name = "tpExpense";
            this.tpExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tpExpense.Size = new System.Drawing.Size(1037, 452);
            this.tpExpense.TabIndex = 2;
            this.tpExpense.Text = "Expense";
            this.tpExpense.UseVisualStyleBackColor = true;
            // 
            // txtExpenseNameArabic
            // 
            this.txtExpenseNameArabic.Location = new System.Drawing.Point(103, 77);
            this.txtExpenseNameArabic.Name = "txtExpenseNameArabic";
            this.txtExpenseNameArabic.Size = new System.Drawing.Size(121, 21);
            this.txtExpenseNameArabic.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(26, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Name Arabic:";
            // 
            // btnExpenseCommit
            // 
            this.btnExpenseCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExpenseCommit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExpenseCommit.Location = new System.Drawing.Point(103, 135);
            this.btnExpenseCommit.Name = "btnExpenseCommit";
            this.btnExpenseCommit.Size = new System.Drawing.Size(121, 74);
            this.btnExpenseCommit.TabIndex = 22;
            this.btnExpenseCommit.Text = "&Commit";
            this.btnExpenseCommit.UseVisualStyleBackColor = true;
            this.btnExpenseCommit.Click += new System.EventHandler(this.btnCommitExpense_Click);
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(103, 50);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(121, 21);
            this.txtExpenseName.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(63, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Price:";
            // 
            // txtExpensePrice
            // 
            this.txtExpensePrice.Location = new System.Drawing.Point(103, 104);
            this.txtExpensePrice.Name = "txtExpensePrice";
            this.txtExpensePrice.Size = new System.Drawing.Size(121, 21);
            this.txtExpensePrice.TabIndex = 1;
            this.txtExpensePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpensePrice_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(59, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name:";
            // 
            // UCTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcTransactions);
            this.Name = "UCTransactions";
            this.Size = new System.Drawing.Size(1051, 484);
            this.Load += new System.EventHandler(this.UCTransactions_Load);
            this.tcTransactions.ResumeLayout(false);
            this.tpSell.ResumeLayout(false);
            this.tpSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellCurrentInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellItemInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellQuantity)).EndInit();
            this.tpBuy.ResumeLayout(false);
            this.tpBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyQuantity)).EndInit();
            this.tpExpense.ResumeLayout(false);
            this.tpExpense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcTransactions;
        private TabPage tpSell;
        private Button btnSellCommitAndPrint;
        private DataGridView dgvSellItemInfo;
        private Button btnSellCommit;
        private Button btnSellAddToInvoice;
        private NumericUpDown numSellQuantity;
        private ComboBox comboSellClient;
        private Button btnSellAddNewClient;
        private Label label11;
        private TextBox txtSellUnitPrice;
        private Label label10;
        private Label label9;
        private TextBox txtSellSerial;
        private Label label8;
        private TabPage tpBuy;
        private CheckBox chkBuyMultipleSimilarItems;
        private Label label5;
        private Button btnBuyCommitAndPrint;
        private Button btnBuyCommit;
        private NumericUpDown numBuyQuantity;
        private ComboBox comboBuySupplier;
        private Button btnBuyAddNewSupplier;
        private Button btnBuyAddNewBrand;
        private Button btnBuyAddNewCategory;
        private TextBox txtBuySerial;
        private Label label7;
        private Label label6;
        private CheckBox chkIsUsed;
        private TextBox txtBuyUnitCost;
        private Label label4;
        private CheckBox chkBuyIsWarranty;
        private Label label3;
        private TextBox txtBuyWarrantyDuration;
        private Label label2;
        private ComboBox comboBuyBrand;
        private Label label1;
        private ComboBox comboBuyCategory;
        private TabPage tpExpense;
        private Button btnExpenseCommit;
        private TextBox txtExpenseName;
        private Label label13;
        private TextBox txtExpensePrice;
		private Label label12;
		private Label label14;
		private DataGridView dgvSellCurrentInvoice;
		private Label label15;
		private TextBox txtExpenseNameArabic;
		private Label label16;
		private Button btnSellClearAll;
		private Button btnSellNew;
		private Button btnSellCancel;
		private Label lblSellID;
		private CheckBox chkIsNotFinal;
    }
}
