
namespace JokerFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtxtBoxDescription = new System.Windows.Forms.RichTextBox();
            this.lblTicketsNumber = new System.Windows.Forms.Label();
            this.txtTicketsNumber = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtSyncTime = new System.Windows.Forms.TextBox();
            this.tabResults = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.datagridWinners = new System.Windows.Forms.DataGridView();
            this.TabFive = new System.Windows.Forms.TabPage();
            this.dataGridFive = new System.Windows.Forms.DataGridView();
            this.TabFourAndOne = new System.Windows.Forms.TabPage();
            this.dataGridFourAndOne = new System.Windows.Forms.DataGridView();
            this.tabFour = new System.Windows.Forms.TabPage();
            this.datagridFour = new System.Windows.Forms.DataGridView();
            this.tabThreeAndOne = new System.Windows.Forms.TabPage();
            this.dataGridThreeAndOne = new System.Windows.Forms.DataGridView();
            this.tabThree = new System.Windows.Forms.TabPage();
            this.dataGridThree = new System.Windows.Forms.DataGridView();
            this.tabTwoAndOne = new System.Windows.Forms.TabPage();
            this.dataGridTwoAndOne = new System.Windows.Forms.DataGridView();
            this.tabOneAndOne = new System.Windows.Forms.TabPage();
            this.dataGridOneAndOne = new System.Windows.Forms.DataGridView();
            this.dataGridWinningTicket = new System.Windows.Forms.DataGridView();
            this.lblWinningTicket = new System.Windows.Forms.Label();
            this.lblMoneyDistributed = new System.Windows.Forms.Label();
            this.lblPrizePool = new System.Windows.Forms.Label();
            this.txtPrizePool = new System.Windows.Forms.TextBox();
            this.txtMoneyDistributed = new System.Windows.Forms.TextBox();
            this.lblTotalMoneyDistributed = new System.Windows.Forms.Label();
            this.txtTotalMoneyDistributed = new System.Windows.Forms.TextBox();
            this.jokerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersPlayedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jokerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersPlayedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winningsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earningsPlaceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabResults.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridWinners)).BeginInit();
            this.TabFive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFive)).BeginInit();
            this.TabFourAndOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFourAndOne)).BeginInit();
            this.tabFour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFour)).BeginInit();
            this.tabThreeAndOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThreeAndOne)).BeginInit();
            this.tabThree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThree)).BeginInit();
            this.tabTwoAndOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTwoAndOne)).BeginInit();
            this.tabOneAndOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOneAndOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWinningTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(425, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Joker App";
            // 
            // rtxtBoxDescription
            // 
            this.rtxtBoxDescription.Location = new System.Drawing.Point(8, 37);
            this.rtxtBoxDescription.Name = "rtxtBoxDescription";
            this.rtxtBoxDescription.ReadOnly = true;
            this.rtxtBoxDescription.Size = new System.Drawing.Size(988, 58);
            this.rtxtBoxDescription.TabIndex = 1;
            this.rtxtBoxDescription.Text = "";
            // 
            // lblTicketsNumber
            // 
            this.lblTicketsNumber.AutoSize = true;
            this.lblTicketsNumber.Location = new System.Drawing.Point(414, 116);
            this.lblTicketsNumber.Name = "lblTicketsNumber";
            this.lblTicketsNumber.Size = new System.Drawing.Size(147, 13);
            this.lblTicketsNumber.TabIndex = 2;
            this.lblTicketsNumber.Text = "Number of tickets to generate";
            // 
            // txtTicketsNumber
            // 
            this.txtTicketsNumber.Location = new System.Drawing.Point(417, 132);
            this.txtTicketsNumber.Name = "txtTicketsNumber";
            this.txtTicketsNumber.Size = new System.Drawing.Size(144, 20);
            this.txtTicketsNumber.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(444, 158);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Lottery";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtSyncTime
            // 
            this.txtSyncTime.Location = new System.Drawing.Point(444, 187);
            this.txtSyncTime.Name = "txtSyncTime";
            this.txtSyncTime.ReadOnly = true;
            this.txtSyncTime.Size = new System.Drawing.Size(85, 20);
            this.txtSyncTime.TabIndex = 5;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.tabPageMain);
            this.tabResults.Controls.Add(this.TabFive);
            this.tabResults.Controls.Add(this.TabFourAndOne);
            this.tabResults.Controls.Add(this.tabFour);
            this.tabResults.Controls.Add(this.tabThreeAndOne);
            this.tabResults.Controls.Add(this.tabThree);
            this.tabResults.Controls.Add(this.tabTwoAndOne);
            this.tabResults.Controls.Add(this.tabOneAndOne);
            this.tabResults.Location = new System.Drawing.Point(12, 306);
            this.tabResults.Name = "tabResults";
            this.tabResults.SelectedIndex = 0;
            this.tabResults.Size = new System.Drawing.Size(988, 322);
            this.tabResults.TabIndex = 9;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.datagridWinners);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(980, 296);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Winners";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // datagridWinners
            // 
            this.datagridWinners.AllowUserToAddRows = false;
            this.datagridWinners.AllowUserToDeleteRows = false;
            this.datagridWinners.AutoGenerateColumns = false;
            this.datagridWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridWinners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.jokerDataGridViewTextBoxColumn1,
            this.numbersPlayedDataGridViewTextBoxColumn1,
            this.winningsDataGridViewTextBoxColumn1,
            this.earningsPlaceDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.datagridWinners.DataSource = this.ticketBindingSource1;
            this.datagridWinners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridWinners.Location = new System.Drawing.Point(3, 3);
            this.datagridWinners.Name = "datagridWinners";
            this.datagridWinners.ReadOnly = true;
            this.datagridWinners.Size = new System.Drawing.Size(974, 290);
            this.datagridWinners.TabIndex = 0;
            // 
            // TabFive
            // 
            this.TabFive.Controls.Add(this.dataGridFive);
            this.TabFive.Location = new System.Drawing.Point(4, 22);
            this.TabFive.Name = "TabFive";
            this.TabFive.Padding = new System.Windows.Forms.Padding(3);
            this.TabFive.Size = new System.Drawing.Size(980, 296);
            this.TabFive.TabIndex = 2;
            this.TabFive.Text = "5";
            this.TabFive.UseVisualStyleBackColor = true;
            // 
            // dataGridFive
            // 
            this.dataGridFive.AllowUserToAddRows = false;
            this.dataGridFive.AllowUserToDeleteRows = false;
            this.dataGridFive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFive.Location = new System.Drawing.Point(3, 3);
            this.dataGridFive.Name = "dataGridFive";
            this.dataGridFive.ReadOnly = true;
            this.dataGridFive.Size = new System.Drawing.Size(974, 290);
            this.dataGridFive.TabIndex = 0;
            // 
            // TabFourAndOne
            // 
            this.TabFourAndOne.Controls.Add(this.dataGridFourAndOne);
            this.TabFourAndOne.Location = new System.Drawing.Point(4, 22);
            this.TabFourAndOne.Name = "TabFourAndOne";
            this.TabFourAndOne.Padding = new System.Windows.Forms.Padding(3);
            this.TabFourAndOne.Size = new System.Drawing.Size(980, 296);
            this.TabFourAndOne.TabIndex = 3;
            this.TabFourAndOne.Text = "4 + 1";
            this.TabFourAndOne.UseVisualStyleBackColor = true;
            // 
            // dataGridFourAndOne
            // 
            this.dataGridFourAndOne.AllowUserToAddRows = false;
            this.dataGridFourAndOne.AllowUserToDeleteRows = false;
            this.dataGridFourAndOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFourAndOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFourAndOne.Location = new System.Drawing.Point(3, 3);
            this.dataGridFourAndOne.Name = "dataGridFourAndOne";
            this.dataGridFourAndOne.ReadOnly = true;
            this.dataGridFourAndOne.Size = new System.Drawing.Size(974, 290);
            this.dataGridFourAndOne.TabIndex = 0;
            // 
            // tabFour
            // 
            this.tabFour.Controls.Add(this.datagridFour);
            this.tabFour.Location = new System.Drawing.Point(4, 22);
            this.tabFour.Name = "tabFour";
            this.tabFour.Padding = new System.Windows.Forms.Padding(3);
            this.tabFour.Size = new System.Drawing.Size(980, 296);
            this.tabFour.TabIndex = 4;
            this.tabFour.Text = "4";
            this.tabFour.UseVisualStyleBackColor = true;
            // 
            // datagridFour
            // 
            this.datagridFour.AllowUserToAddRows = false;
            this.datagridFour.AllowUserToDeleteRows = false;
            this.datagridFour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridFour.Location = new System.Drawing.Point(3, 3);
            this.datagridFour.Name = "datagridFour";
            this.datagridFour.ReadOnly = true;
            this.datagridFour.Size = new System.Drawing.Size(974, 290);
            this.datagridFour.TabIndex = 0;
            // 
            // tabThreeAndOne
            // 
            this.tabThreeAndOne.Controls.Add(this.dataGridThreeAndOne);
            this.tabThreeAndOne.Location = new System.Drawing.Point(4, 22);
            this.tabThreeAndOne.Name = "tabThreeAndOne";
            this.tabThreeAndOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabThreeAndOne.Size = new System.Drawing.Size(980, 296);
            this.tabThreeAndOne.TabIndex = 5;
            this.tabThreeAndOne.Text = "3 + 1";
            this.tabThreeAndOne.UseVisualStyleBackColor = true;
            // 
            // dataGridThreeAndOne
            // 
            this.dataGridThreeAndOne.AllowUserToAddRows = false;
            this.dataGridThreeAndOne.AllowUserToDeleteRows = false;
            this.dataGridThreeAndOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThreeAndOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridThreeAndOne.Location = new System.Drawing.Point(3, 3);
            this.dataGridThreeAndOne.Name = "dataGridThreeAndOne";
            this.dataGridThreeAndOne.ReadOnly = true;
            this.dataGridThreeAndOne.Size = new System.Drawing.Size(974, 290);
            this.dataGridThreeAndOne.TabIndex = 0;
            // 
            // tabThree
            // 
            this.tabThree.Controls.Add(this.dataGridThree);
            this.tabThree.Location = new System.Drawing.Point(4, 22);
            this.tabThree.Name = "tabThree";
            this.tabThree.Padding = new System.Windows.Forms.Padding(3);
            this.tabThree.Size = new System.Drawing.Size(980, 296);
            this.tabThree.TabIndex = 6;
            this.tabThree.Text = "3";
            this.tabThree.UseVisualStyleBackColor = true;
            // 
            // dataGridThree
            // 
            this.dataGridThree.AllowUserToAddRows = false;
            this.dataGridThree.AllowUserToDeleteRows = false;
            this.dataGridThree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridThree.Location = new System.Drawing.Point(3, 3);
            this.dataGridThree.Name = "dataGridThree";
            this.dataGridThree.ReadOnly = true;
            this.dataGridThree.Size = new System.Drawing.Size(974, 290);
            this.dataGridThree.TabIndex = 0;
            // 
            // tabTwoAndOne
            // 
            this.tabTwoAndOne.Controls.Add(this.dataGridTwoAndOne);
            this.tabTwoAndOne.Location = new System.Drawing.Point(4, 22);
            this.tabTwoAndOne.Name = "tabTwoAndOne";
            this.tabTwoAndOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabTwoAndOne.Size = new System.Drawing.Size(980, 296);
            this.tabTwoAndOne.TabIndex = 7;
            this.tabTwoAndOne.Text = "2 + 1";
            this.tabTwoAndOne.UseVisualStyleBackColor = true;
            // 
            // dataGridTwoAndOne
            // 
            this.dataGridTwoAndOne.AllowUserToAddRows = false;
            this.dataGridTwoAndOne.AllowUserToDeleteRows = false;
            this.dataGridTwoAndOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTwoAndOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTwoAndOne.Location = new System.Drawing.Point(3, 3);
            this.dataGridTwoAndOne.Name = "dataGridTwoAndOne";
            this.dataGridTwoAndOne.ReadOnly = true;
            this.dataGridTwoAndOne.Size = new System.Drawing.Size(974, 290);
            this.dataGridTwoAndOne.TabIndex = 0;
            // 
            // tabOneAndOne
            // 
            this.tabOneAndOne.Controls.Add(this.dataGridOneAndOne);
            this.tabOneAndOne.Location = new System.Drawing.Point(4, 22);
            this.tabOneAndOne.Name = "tabOneAndOne";
            this.tabOneAndOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabOneAndOne.Size = new System.Drawing.Size(980, 296);
            this.tabOneAndOne.TabIndex = 8;
            this.tabOneAndOne.Text = "1 + 1";
            this.tabOneAndOne.UseVisualStyleBackColor = true;
            // 
            // dataGridOneAndOne
            // 
            this.dataGridOneAndOne.AllowUserToAddRows = false;
            this.dataGridOneAndOne.AllowUserToDeleteRows = false;
            this.dataGridOneAndOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOneAndOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOneAndOne.Location = new System.Drawing.Point(3, 3);
            this.dataGridOneAndOne.Name = "dataGridOneAndOne";
            this.dataGridOneAndOne.ReadOnly = true;
            this.dataGridOneAndOne.Size = new System.Drawing.Size(974, 290);
            this.dataGridOneAndOne.TabIndex = 0;
            // 
            // dataGridWinningTicket
            // 
            this.dataGridWinningTicket.AllowUserToAddRows = false;
            this.dataGridWinningTicket.AllowUserToDeleteRows = false;
            this.dataGridWinningTicket.AutoGenerateColumns = false;
            this.dataGridWinningTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWinningTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jokerDataGridViewTextBoxColumn,
            this.numbersPlayedDataGridViewTextBoxColumn});
            this.dataGridWinningTicket.DataSource = this.ticketBindingSource;
            this.dataGridWinningTicket.Location = new System.Drawing.Point(12, 205);
            this.dataGridWinningTicket.Name = "dataGridWinningTicket";
            this.dataGridWinningTicket.ReadOnly = true;
            this.dataGridWinningTicket.Size = new System.Drawing.Size(286, 95);
            this.dataGridWinningTicket.TabIndex = 10;
            // 
            // lblWinningTicket
            // 
            this.lblWinningTicket.AutoSize = true;
            this.lblWinningTicket.Location = new System.Drawing.Point(108, 187);
            this.lblWinningTicket.Name = "lblWinningTicket";
            this.lblWinningTicket.Size = new System.Drawing.Size(76, 13);
            this.lblWinningTicket.TabIndex = 11;
            this.lblWinningTicket.Text = "WinningTicket";
            // 
            // lblMoneyDistributed
            // 
            this.lblMoneyDistributed.AutoSize = true;
            this.lblMoneyDistributed.Location = new System.Drawing.Point(785, 116);
            this.lblMoneyDistributed.Name = "lblMoneyDistributed";
            this.lblMoneyDistributed.Size = new System.Drawing.Size(142, 13);
            this.lblMoneyDistributed.TabIndex = 12;
            this.lblMoneyDistributed.Text = "Money Distributed this lottery";
            // 
            // lblPrizePool
            // 
            this.lblPrizePool.AutoSize = true;
            this.lblPrizePool.Location = new System.Drawing.Point(119, 116);
            this.lblPrizePool.Name = "lblPrizePool";
            this.lblPrizePool.Size = new System.Drawing.Size(54, 13);
            this.lblPrizePool.TabIndex = 13;
            this.lblPrizePool.Text = "Prize Pool";
            // 
            // txtPrizePool
            // 
            this.txtPrizePool.Location = new System.Drawing.Point(81, 132);
            this.txtPrizePool.Name = "txtPrizePool";
            this.txtPrizePool.ReadOnly = true;
            this.txtPrizePool.Size = new System.Drawing.Size(144, 20);
            this.txtPrizePool.TabIndex = 14;
            // 
            // txtMoneyDistributed
            // 
            this.txtMoneyDistributed.Location = new System.Drawing.Point(788, 132);
            this.txtMoneyDistributed.Name = "txtMoneyDistributed";
            this.txtMoneyDistributed.ReadOnly = true;
            this.txtMoneyDistributed.Size = new System.Drawing.Size(144, 20);
            this.txtMoneyDistributed.TabIndex = 15;
            // 
            // lblTotalMoneyDistributed
            // 
            this.lblTotalMoneyDistributed.AutoSize = true;
            this.lblTotalMoneyDistributed.Location = new System.Drawing.Point(817, 168);
            this.lblTotalMoneyDistributed.Name = "lblTotalMoneyDistributed";
            this.lblTotalMoneyDistributed.Size = new System.Drawing.Size(84, 13);
            this.lblTotalMoneyDistributed.TabIndex = 16;
            this.lblTotalMoneyDistributed.Text = "Total Distributed";
            // 
            // txtTotalMoneyDistributed
            // 
            this.txtTotalMoneyDistributed.Location = new System.Drawing.Point(788, 187);
            this.txtTotalMoneyDistributed.Name = "txtTotalMoneyDistributed";
            this.txtTotalMoneyDistributed.ReadOnly = true;
            this.txtTotalMoneyDistributed.Size = new System.Drawing.Size(144, 20);
            this.txtTotalMoneyDistributed.TabIndex = 17;
            // 
            // jokerDataGridViewTextBoxColumn
            // 
            this.jokerDataGridViewTextBoxColumn.DataPropertyName = "Joker";
            this.jokerDataGridViewTextBoxColumn.HeaderText = "Joker";
            this.jokerDataGridViewTextBoxColumn.Name = "jokerDataGridViewTextBoxColumn";
            this.jokerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numbersPlayedDataGridViewTextBoxColumn
            // 
            this.numbersPlayedDataGridViewTextBoxColumn.DataPropertyName = "NumbersPlayed";
            this.numbersPlayedDataGridViewTextBoxColumn.HeaderText = "NumbersPlayed";
            this.numbersPlayedDataGridViewTextBoxColumn.Name = "numbersPlayedDataGridViewTextBoxColumn";
            this.numbersPlayedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(JokerFormsApp.Models.Ticket);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // jokerDataGridViewTextBoxColumn1
            // 
            this.jokerDataGridViewTextBoxColumn1.DataPropertyName = "Joker";
            this.jokerDataGridViewTextBoxColumn1.HeaderText = "Joker";
            this.jokerDataGridViewTextBoxColumn1.Name = "jokerDataGridViewTextBoxColumn1";
            this.jokerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numbersPlayedDataGridViewTextBoxColumn1
            // 
            this.numbersPlayedDataGridViewTextBoxColumn1.DataPropertyName = "NumbersPlayed";
            this.numbersPlayedDataGridViewTextBoxColumn1.HeaderText = "NumbersPlayed";
            this.numbersPlayedDataGridViewTextBoxColumn1.Name = "numbersPlayedDataGridViewTextBoxColumn1";
            this.numbersPlayedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // winningsDataGridViewTextBoxColumn1
            // 
            this.winningsDataGridViewTextBoxColumn1.DataPropertyName = "Winnings";
            this.winningsDataGridViewTextBoxColumn1.HeaderText = "Winnings";
            this.winningsDataGridViewTextBoxColumn1.Name = "winningsDataGridViewTextBoxColumn1";
            this.winningsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // earningsPlaceDataGridViewTextBoxColumn1
            // 
            this.earningsPlaceDataGridViewTextBoxColumn1.DataPropertyName = "EarningsPlace";
            this.earningsPlaceDataGridViewTextBoxColumn1.HeaderText = "EarningsPlace";
            this.earningsPlaceDataGridViewTextBoxColumn1.Name = "earningsPlaceDataGridViewTextBoxColumn1";
            this.earningsPlaceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ticketBindingSource1
            // 
            this.ticketBindingSource1.DataSource = typeof(JokerFormsApp.Models.Ticket);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 640);
            this.Controls.Add(this.txtTotalMoneyDistributed);
            this.Controls.Add(this.lblTotalMoneyDistributed);
            this.Controls.Add(this.txtMoneyDistributed);
            this.Controls.Add(this.txtPrizePool);
            this.Controls.Add(this.lblPrizePool);
            this.Controls.Add(this.lblMoneyDistributed);
            this.Controls.Add(this.lblWinningTicket);
            this.Controls.Add(this.dataGridWinningTicket);
            this.Controls.Add(this.tabResults);
            this.Controls.Add(this.txtSyncTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtTicketsNumber);
            this.Controls.Add(this.lblTicketsNumber);
            this.Controls.Add(this.rtxtBoxDescription);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1028, 679);
            this.MinimumSize = new System.Drawing.Size(1028, 679);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joker Lottery simulator";
            this.tabResults.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridWinners)).EndInit();
            this.TabFive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFive)).EndInit();
            this.TabFourAndOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFourAndOne)).EndInit();
            this.tabFour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridFour)).EndInit();
            this.tabThreeAndOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThreeAndOne)).EndInit();
            this.tabThree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThree)).EndInit();
            this.tabTwoAndOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTwoAndOne)).EndInit();
            this.tabOneAndOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOneAndOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWinningTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtxtBoxDescription;
        private System.Windows.Forms.Label lblTicketsNumber;
        private System.Windows.Forms.TextBox txtTicketsNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtSyncTime;
        private System.Windows.Forms.TabControl tabResults;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.DataGridView datagridWinners;
        private System.Windows.Forms.DataGridView dataGridWinningTicket;
        private System.Windows.Forms.Label lblWinningTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jokerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersPlayedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn winningsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn earningsPlaceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource ticketBindingSource1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn jokerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersPlayedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMoneyDistributed;
        private System.Windows.Forms.Label lblPrizePool;
        private System.Windows.Forms.TextBox txtPrizePool;
        private System.Windows.Forms.TextBox txtMoneyDistributed;
        private System.Windows.Forms.Label lblTotalMoneyDistributed;
        private System.Windows.Forms.TextBox txtTotalMoneyDistributed;
        private System.Windows.Forms.TabPage TabFive;
        private System.Windows.Forms.TabPage TabFourAndOne;
        private System.Windows.Forms.TabPage tabFour;
        private System.Windows.Forms.TabPage tabThreeAndOne;
        private System.Windows.Forms.TabPage tabThree;
        private System.Windows.Forms.TabPage tabTwoAndOne;
        private System.Windows.Forms.TabPage tabOneAndOne;
        private System.Windows.Forms.DataGridView dataGridFive;
        private System.Windows.Forms.DataGridView dataGridFourAndOne;
        private System.Windows.Forms.DataGridView datagridFour;
        private System.Windows.Forms.DataGridView dataGridThreeAndOne;
        private System.Windows.Forms.DataGridView dataGridThree;
        private System.Windows.Forms.DataGridView dataGridTwoAndOne;
        private System.Windows.Forms.DataGridView dataGridOneAndOne;
    }
}

