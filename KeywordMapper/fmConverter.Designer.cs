namespace KeywordMapper
{
    partial class fmConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConverter));
            this.SourceQueryText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FtsQueryTextBox = new System.Windows.Forms.TextBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Search = new System.Windows.Forms.Button();
            this.KeywordsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.grpResultView = new System.Windows.Forms.GroupBox();
            this.btnExpandTreeView = new System.Windows.Forms.Button();
            this.btnCollapseTreeview = new System.Windows.Forms.Button();
            this.KeywordsTreeView = new System.Windows.Forms.TreeView();
            this.lblSearchResultsCount = new System.Windows.Forms.Label();
            this.dgvSearchOutput = new System.Windows.Forms.DataGridView();
            this.colWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOccurenceCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnList = new System.Windows.Forms.Button();
            this.btnGrid = new System.Windows.Forms.Button();
            this.grpQuery = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.cmbSearchTypes = new System.Windows.Forms.ComboBox();
            this.grpTextOperations = new System.Windows.Forms.GroupBox();
            this.SearchIndexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblSearchIndex = new System.Windows.Forms.Label();
            this.lblSearchDirection = new System.Windows.Forms.Label();
            this.cmbSearchDirection = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.grpNLPOperations = new System.Windows.Forms.GroupBox();
            this.chkDT = new System.Windows.Forms.CheckBox();
            this.chkIN = new System.Windows.Forms.CheckBox();
            this.chkJJS = new System.Windows.Forms.CheckBox();
            this.chkPDT = new System.Windows.Forms.CheckBox();
            this.chkWP = new System.Windows.Forms.CheckBox();
            this.chkPRPDollar = new System.Windows.Forms.CheckBox();
            this.chkVBP = new System.Windows.Forms.CheckBox();
            this.chkRBS = new System.Windows.Forms.CheckBox();
            this.chkVBD = new System.Windows.Forms.CheckBox();
            this.chkTO = new System.Windows.Forms.CheckBox();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.chkFW = new System.Windows.Forms.CheckBox();
            this.chkJJR = new System.Windows.Forms.CheckBox();
            this.chkMD = new System.Windows.Forms.CheckBox();
            this.chkPRP = new System.Windows.Forms.CheckBox();
            this.chkRBR = new System.Windows.Forms.CheckBox();
            this.chkWRB = new System.Windows.Forms.CheckBox();
            this.chkSYM = new System.Windows.Forms.CheckBox();
            this.chkWDT = new System.Windows.Forms.CheckBox();
            this.chkVB = new System.Windows.Forms.CheckBox();
            this.chkVBN = new System.Windows.Forms.CheckBox();
            this.chkCC = new System.Windows.Forms.CheckBox();
            this.chkEX = new System.Windows.Forms.CheckBox();
            this.chkJJ = new System.Windows.Forms.CheckBox();
            this.chkLS = new System.Windows.Forms.CheckBox();
            this.chkPOS = new System.Windows.Forms.CheckBox();
            this.chkRB = new System.Windows.Forms.CheckBox();
            this.chkRP = new System.Windows.Forms.CheckBox();
            this.chkUH = new System.Windows.Forms.CheckBox();
            this.chkVBJ = new System.Windows.Forms.CheckBox();
            this.chkVBZ = new System.Windows.Forms.CheckBox();
            this.chkWPDoller = new System.Windows.Forms.CheckBox();
            this.lblExpectNounSection = new System.Windows.Forms.Label();
            this.lkblNounsSection = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkNNS = new System.Windows.Forms.CheckBox();
            this.chkNN = new System.Windows.Forms.CheckBox();
            this.pnlCPUUsage = new System.Windows.Forms.Panel();
            this.KeywordsTabControl = new System.Windows.Forms.TabControl();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.KeywordsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.KeywordsSplitContainer)).BeginInit();
            this.KeywordsSplitContainer.Panel1.SuspendLayout();
            this.KeywordsSplitContainer.Panel2.SuspendLayout();
            this.KeywordsSplitContainer.SuspendLayout();
            this.grpResultView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchOutput)).BeginInit();
            this.grpQuery.SuspendLayout();
            this.grpTextOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIndexNumericUpDown)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.grpNLPOperations.SuspendLayout();
            this.pnlCPUUsage.SuspendLayout();
            this.KeywordsTabControl.SuspendLayout();
            this.SearchTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceQueryText
            // 
            this.SourceQueryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceQueryText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceQueryText.Location = new System.Drawing.Point(48, 24);
            this.SourceQueryText.Name = "SourceQueryText";
            this.SourceQueryText.Size = new System.Drawing.Size(336, 22);
            this.SourceQueryText.TabIndex = 0;
            this.SourceQueryText.Text = "\"Enter search terms here\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Query";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(543, 22);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 26);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Match";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Results";
            this.label3.Visible = false;
            // 
            // FtsQueryTextBox
            // 
            this.FtsQueryTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FtsQueryTextBox.Location = new System.Drawing.Point(0, 0);
            this.FtsQueryTextBox.Multiline = true;
            this.FtsQueryTextBox.Name = "FtsQueryTextBox";
            this.FtsQueryTextBox.ReadOnly = true;
            this.FtsQueryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FtsQueryTextBox.Size = new System.Drawing.Size(633, 54);
            this.FtsQueryTextBox.TabIndex = 7;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(139, 35);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(55, 13);
            this.lblRAM.TabIndex = 10;
            this.lblRAM.Text = "RAM Cost";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(6, 35);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(53, 13);
            this.lblCPU.TabIndex = 12;
            this.lblCPU.Text = "CPU Cost";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Search.Location = new System.Drawing.Point(462, 26);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 18;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // KeywordsSplitContainer
            // 
            this.KeywordsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeywordsSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.KeywordsSplitContainer.Name = "KeywordsSplitContainer";
            // 
            // KeywordsSplitContainer.Panel1
            // 
            this.KeywordsSplitContainer.Panel1.Controls.Add(this.grpResultView);
            this.KeywordsSplitContainer.Panel1.Controls.Add(this.btnList);
            this.KeywordsSplitContainer.Panel1.Controls.Add(this.btnGrid);
            this.KeywordsSplitContainer.Panel1.Controls.Add(this.grpQuery);
            this.KeywordsSplitContainer.Panel1.Controls.Add(this.grpTextOperations);
            this.KeywordsSplitContainer.Panel1.Controls.Add(this.pnlBottom);
            this.KeywordsSplitContainer.Panel1.Controls.Add(this.label3);
            // 
            // KeywordsSplitContainer.Panel2
            // 
            this.KeywordsSplitContainer.Panel2.Controls.Add(this.grpNLPOperations);
            this.KeywordsSplitContainer.Panel2.Controls.Add(this.pnlCPUUsage);
            this.KeywordsSplitContainer.Size = new System.Drawing.Size(1210, 696);
            this.KeywordsSplitContainer.SplitterDistance = 633;
            this.KeywordsSplitContainer.TabIndex = 20;
            // 
            // grpResultView
            // 
            this.grpResultView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResultView.Controls.Add(this.btnExpandTreeView);
            this.grpResultView.Controls.Add(this.btnCollapseTreeview);
            this.grpResultView.Controls.Add(this.KeywordsTreeView);
            this.grpResultView.Controls.Add(this.lblSearchResultsCount);
            this.grpResultView.Controls.Add(this.dgvSearchOutput);
            this.grpResultView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultView.Location = new System.Drawing.Point(2, 216);
            this.grpResultView.Name = "grpResultView";
            this.grpResultView.Size = new System.Drawing.Size(626, 420);
            this.grpResultView.TabIndex = 30;
            this.grpResultView.TabStop = false;
            this.grpResultView.Text = "Results";
            // 
            // btnExpandTreeView
            // 
            this.btnExpandTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandTreeView.Image = ((System.Drawing.Image)(resources.GetObject("btnExpandTreeView.Image")));
            this.btnExpandTreeView.Location = new System.Drawing.Point(586, 15);
            this.btnExpandTreeView.Name = "btnExpandTreeView";
            this.btnExpandTreeView.Size = new System.Drawing.Size(30, 25);
            this.btnExpandTreeView.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnExpandTreeView, "Expand");
            this.btnExpandTreeView.UseVisualStyleBackColor = true;
            this.btnExpandTreeView.Visible = false;
            this.btnExpandTreeView.Click += new System.EventHandler(this.btnExpandTreeView_Click);
            // 
            // btnCollapseTreeview
            // 
            this.btnCollapseTreeview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollapseTreeview.Image = ((System.Drawing.Image)(resources.GetObject("btnCollapseTreeview.Image")));
            this.btnCollapseTreeview.Location = new System.Drawing.Point(550, 15);
            this.btnCollapseTreeview.Name = "btnCollapseTreeview";
            this.btnCollapseTreeview.Size = new System.Drawing.Size(30, 25);
            this.btnCollapseTreeview.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnCollapseTreeview, "Collapse");
            this.btnCollapseTreeview.UseVisualStyleBackColor = true;
            this.btnCollapseTreeview.Visible = false;
            this.btnCollapseTreeview.Click += new System.EventHandler(this.btnCollapseTreeview_Click);
            // 
            // KeywordsTreeView
            // 
            this.KeywordsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeywordsTreeView.Location = new System.Drawing.Point(5, 49);
            this.KeywordsTreeView.Name = "KeywordsTreeView";
            this.KeywordsTreeView.Size = new System.Drawing.Size(616, 365);
            this.KeywordsTreeView.TabIndex = 15;
            this.KeywordsTreeView.Visible = false;
            // 
            // lblSearchResultsCount
            // 
            this.lblSearchResultsCount.AutoSize = true;
            this.lblSearchResultsCount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchResultsCount.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblSearchResultsCount.Location = new System.Drawing.Point(56, 0);
            this.lblSearchResultsCount.Name = "lblSearchResultsCount";
            this.lblSearchResultsCount.Size = new System.Drawing.Size(11, 15);
            this.lblSearchResultsCount.TabIndex = 28;
            this.lblSearchResultsCount.Text = "-";
            // 
            // dgvSearchOutput
            // 
            this.dgvSearchOutput.AllowUserToAddRows = false;
            this.dgvSearchOutput.AllowUserToDeleteRows = false;
            this.dgvSearchOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWord,
            this.colOccurenceCount});
            this.dgvSearchOutput.Location = new System.Drawing.Point(4, 49);
            this.dgvSearchOutput.Name = "dgvSearchOutput";
            this.dgvSearchOutput.Size = new System.Drawing.Size(618, 363);
            this.dgvSearchOutput.TabIndex = 26;
            this.dgvSearchOutput.Visible = false;
            // 
            // colWord
            // 
            this.colWord.DataPropertyName = "Value";
            this.colWord.FillWeight = 150F;
            this.colWord.HeaderText = "Word";
            this.colWord.MinimumWidth = 150;
            this.colWord.Name = "colWord";
            this.colWord.Width = 150;
            // 
            // colOccurenceCount
            // 
            this.colOccurenceCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOccurenceCount.DataPropertyName = "Count";
            this.colOccurenceCount.HeaderText = "Occurence Count";
            this.colOccurenceCount.Name = "colOccurenceCount";
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(586, 188);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(30, 25);
            this.btnList.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnList, "List View");
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Visible = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnGrid
            // 
            this.btnGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnGrid.Image")));
            this.btnGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrid.Location = new System.Drawing.Point(550, 188);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(30, 25);
            this.btnGrid.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnGrid, "Grid View");
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Visible = false;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // grpQuery
            // 
            this.grpQuery.Controls.Add(this.lblCount);
            this.grpQuery.Controls.Add(this.SourceQueryText);
            this.grpQuery.Controls.Add(this.cmbSearchTypes);
            this.grpQuery.Controls.Add(this.ConvertButton);
            this.grpQuery.Controls.Add(this.label1);
            this.grpQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpQuery.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuery.Location = new System.Drawing.Point(0, 0);
            this.grpQuery.Name = "grpQuery";
            this.grpQuery.Size = new System.Drawing.Size(633, 83);
            this.grpQuery.TabIndex = 27;
            this.grpQuery.TabStop = false;
            this.grpQuery.Text = "Query";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(48, 54);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(53, 15);
            this.lblCount.TabIndex = 22;
            this.lblCount.Text = "Matches";
            // 
            // cmbSearchTypes
            // 
            this.cmbSearchTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchTypes.FormattingEnabled = true;
            this.cmbSearchTypes.Location = new System.Drawing.Point(390, 23);
            this.cmbSearchTypes.Name = "cmbSearchTypes";
            this.cmbSearchTypes.Size = new System.Drawing.Size(136, 23);
            this.cmbSearchTypes.TabIndex = 21;
            // 
            // grpTextOperations
            // 
            this.grpTextOperations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTextOperations.Controls.Add(this.SearchIndexNumericUpDown);
            this.grpTextOperations.Controls.Add(this.lblSearchIndex);
            this.grpTextOperations.Controls.Add(this.lblSearchDirection);
            this.grpTextOperations.Controls.Add(this.cmbSearchDirection);
            this.grpTextOperations.Controls.Add(this.btnReset);
            this.grpTextOperations.Controls.Add(this.Search);
            this.grpTextOperations.Enabled = false;
            this.grpTextOperations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTextOperations.Location = new System.Drawing.Point(3, 101);
            this.grpTextOperations.Name = "grpTextOperations";
            this.grpTextOperations.Size = new System.Drawing.Size(628, 70);
            this.grpTextOperations.TabIndex = 25;
            this.grpTextOperations.TabStop = false;
            this.grpTextOperations.Text = "Text Operations";
            // 
            // SearchIndexNumericUpDown
            // 
            this.SearchIndexNumericUpDown.Location = new System.Drawing.Point(329, 26);
            this.SearchIndexNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SearchIndexNumericUpDown.Name = "SearchIndexNumericUpDown";
            this.SearchIndexNumericUpDown.Size = new System.Drawing.Size(53, 23);
            this.SearchIndexNumericUpDown.TabIndex = 29;
            this.SearchIndexNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSearchIndex
            // 
            this.lblSearchIndex.AutoSize = true;
            this.lblSearchIndex.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchIndex.Location = new System.Drawing.Point(246, 30);
            this.lblSearchIndex.Name = "lblSearchIndex";
            this.lblSearchIndex.Size = new System.Drawing.Size(77, 15);
            this.lblSearchIndex.TabIndex = 28;
            this.lblSearchIndex.Text = "Search Index";
            // 
            // lblSearchDirection
            // 
            this.lblSearchDirection.AutoSize = true;
            this.lblSearchDirection.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDirection.Location = new System.Drawing.Point(8, 30);
            this.lblSearchDirection.Name = "lblSearchDirection";
            this.lblSearchDirection.Size = new System.Drawing.Size(97, 15);
            this.lblSearchDirection.TabIndex = 27;
            this.lblSearchDirection.Text = "Search Direction";
            // 
            // cmbSearchDirection
            // 
            this.cmbSearchDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchDirection.FormattingEnabled = true;
            this.cmbSearchDirection.Items.AddRange(new object[] {
            "-Select Direction-",
            "Left",
            "Right"});
            this.cmbSearchDirection.Location = new System.Drawing.Point(106, 26);
            this.cmbSearchDirection.Name = "cmbSearchDirection";
            this.cmbSearchDirection.Size = new System.Drawing.Size(121, 23);
            this.cmbSearchDirection.TabIndex = 26;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(543, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.FtsQueryTextBox);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 642);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(633, 54);
            this.pnlBottom.TabIndex = 20;
            // 
            // grpNLPOperations
            // 
            this.grpNLPOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNLPOperations.Controls.Add(this.chkDT);
            this.grpNLPOperations.Controls.Add(this.chkIN);
            this.grpNLPOperations.Controls.Add(this.chkJJS);
            this.grpNLPOperations.Controls.Add(this.chkPDT);
            this.grpNLPOperations.Controls.Add(this.chkWP);
            this.grpNLPOperations.Controls.Add(this.chkPRPDollar);
            this.grpNLPOperations.Controls.Add(this.chkVBP);
            this.grpNLPOperations.Controls.Add(this.chkRBS);
            this.grpNLPOperations.Controls.Add(this.chkVBD);
            this.grpNLPOperations.Controls.Add(this.chkTO);
            this.grpNLPOperations.Controls.Add(this.chkCD);
            this.grpNLPOperations.Controls.Add(this.chkFW);
            this.grpNLPOperations.Controls.Add(this.chkJJR);
            this.grpNLPOperations.Controls.Add(this.chkMD);
            this.grpNLPOperations.Controls.Add(this.chkPRP);
            this.grpNLPOperations.Controls.Add(this.chkRBR);
            this.grpNLPOperations.Controls.Add(this.chkWRB);
            this.grpNLPOperations.Controls.Add(this.chkSYM);
            this.grpNLPOperations.Controls.Add(this.chkWDT);
            this.grpNLPOperations.Controls.Add(this.chkVB);
            this.grpNLPOperations.Controls.Add(this.chkVBN);
            this.grpNLPOperations.Controls.Add(this.chkCC);
            this.grpNLPOperations.Controls.Add(this.chkEX);
            this.grpNLPOperations.Controls.Add(this.chkJJ);
            this.grpNLPOperations.Controls.Add(this.chkLS);
            this.grpNLPOperations.Controls.Add(this.chkPOS);
            this.grpNLPOperations.Controls.Add(this.chkRB);
            this.grpNLPOperations.Controls.Add(this.chkRP);
            this.grpNLPOperations.Controls.Add(this.chkUH);
            this.grpNLPOperations.Controls.Add(this.chkVBJ);
            this.grpNLPOperations.Controls.Add(this.chkVBZ);
            this.grpNLPOperations.Controls.Add(this.chkWPDoller);
            this.grpNLPOperations.Controls.Add(this.lblExpectNounSection);
            this.grpNLPOperations.Controls.Add(this.lkblNounsSection);
            this.grpNLPOperations.Controls.Add(this.checkBox2);
            this.grpNLPOperations.Controls.Add(this.checkBox1);
            this.grpNLPOperations.Controls.Add(this.chkNNS);
            this.grpNLPOperations.Controls.Add(this.chkNN);
            this.grpNLPOperations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNLPOperations.Location = new System.Drawing.Point(5, 4);
            this.grpNLPOperations.Name = "grpNLPOperations";
            this.grpNLPOperations.Size = new System.Drawing.Size(563, 632);
            this.grpNLPOperations.TabIndex = 1;
            this.grpNLPOperations.TabStop = false;
            this.grpNLPOperations.Text = "NLP Operations";
            // 
            // chkDT
            // 
            this.chkDT.AutoSize = true;
            this.chkDT.Enabled = false;
            this.chkDT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDT.Location = new System.Drawing.Point(431, 168);
            this.chkDT.Name = "chkDT";
            this.chkDT.Size = new System.Drawing.Size(113, 19);
            this.chkDT.TabIndex = 26;
            this.chkDT.Text = "DT (Determinar)";
            this.chkDT.UseVisualStyleBackColor = true;
            // 
            // chkIN
            // 
            this.chkIN.AutoSize = true;
            this.chkIN.Enabled = false;
            this.chkIN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIN.Location = new System.Drawing.Point(432, 188);
            this.chkIN.Name = "chkIN";
            this.chkIN.Size = new System.Drawing.Size(118, 34);
            this.chkIN.TabIndex = 27;
            this.chkIN.Text = "IN (Prep or Sub\r\nordinating  Conj)";
            this.chkIN.UseVisualStyleBackColor = true;
            // 
            // chkJJS
            // 
            this.chkJJS.AutoSize = true;
            this.chkJJS.Enabled = false;
            this.chkJJS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJJS.Location = new System.Drawing.Point(431, 228);
            this.chkJJS.Name = "chkJJS";
            this.chkJJS.Size = new System.Drawing.Size(138, 19);
            this.chkJJS.TabIndex = 28;
            this.chkJJS.Text = "JJS (Adjv,Superlative)";
            this.chkJJS.UseVisualStyleBackColor = true;
            // 
            // chkPDT
            // 
            this.chkPDT.AutoSize = true;
            this.chkPDT.Enabled = false;
            this.chkPDT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPDT.Location = new System.Drawing.Point(431, 257);
            this.chkPDT.Name = "chkPDT";
            this.chkPDT.Size = new System.Drawing.Size(137, 19);
            this.chkPDT.TabIndex = 29;
            this.chkPDT.Text = "PDT (Predeterminar)";
            this.chkPDT.UseVisualStyleBackColor = true;
            // 
            // chkWP
            // 
            this.chkWP.AutoSize = true;
            this.chkWP.Enabled = false;
            this.chkWP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWP.Location = new System.Drawing.Point(432, 498);
            this.chkWP.Name = "chkWP";
            this.chkWP.Size = new System.Drawing.Size(122, 19);
            this.chkWP.TabIndex = 30;
            this.chkWP.Text = "WP (wh pronoun)";
            this.chkWP.UseVisualStyleBackColor = true;
            // 
            // chkPRPDollar
            // 
            this.chkPRPDollar.AutoSize = true;
            this.chkPRPDollar.Enabled = false;
            this.chkPRPDollar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPRPDollar.Location = new System.Drawing.Point(431, 282);
            this.chkPRPDollar.Name = "chkPRPDollar";
            this.chkPRPDollar.Size = new System.Drawing.Size(118, 34);
            this.chkPRPDollar.TabIndex = 31;
            this.chkPRPDollar.Text = "PRP $ (Possesive\r\nPronoun)";
            this.chkPRPDollar.UseVisualStyleBackColor = true;
            // 
            // chkVBP
            // 
            this.chkVBP.AutoSize = true;
            this.chkVBP.Enabled = false;
            this.chkVBP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVBP.Location = new System.Drawing.Point(432, 435);
            this.chkVBP.Name = "chkVBP";
            this.chkVBP.Size = new System.Drawing.Size(138, 49);
            this.chkVBP.TabIndex = 32;
            this.chkVBP.Text = "VBP (Verb,Non \r\n3rd person singular \r\npresent )";
            this.chkVBP.UseVisualStyleBackColor = true;
            // 
            // chkRBS
            // 
            this.chkRBS.AutoSize = true;
            this.chkRBS.Enabled = false;
            this.chkRBS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRBS.Location = new System.Drawing.Point(432, 323);
            this.chkRBS.Name = "chkRBS";
            this.chkRBS.Size = new System.Drawing.Size(94, 34);
            this.chkRBS.TabIndex = 33;
            this.chkRBS.Text = "RBS (Adverb,\r\nSuperlative)";
            this.chkRBS.UseVisualStyleBackColor = true;
            // 
            // chkVBD
            // 
            this.chkVBD.AutoSize = true;
            this.chkVBD.Enabled = false;
            this.chkVBD.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVBD.Location = new System.Drawing.Point(432, 399);
            this.chkVBD.Name = "chkVBD";
            this.chkVBD.Size = new System.Drawing.Size(142, 19);
            this.chkVBD.TabIndex = 34;
            this.chkVBD.Text = "VBD (Verb,past tense)";
            this.chkVBD.UseVisualStyleBackColor = true;
            // 
            // chkTO
            // 
            this.chkTO.AutoSize = true;
            this.chkTO.Enabled = false;
            this.chkTO.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTO.Location = new System.Drawing.Point(432, 364);
            this.chkTO.Name = "chkTO";
            this.chkTO.Size = new System.Drawing.Size(63, 19);
            this.chkTO.TabIndex = 35;
            this.chkTO.Text = "TO (to)";
            this.chkTO.UseVisualStyleBackColor = true;
            // 
            // chkCD
            // 
            this.chkCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCD.AutoSize = true;
            this.chkCD.Enabled = false;
            this.chkCD.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCD.Location = new System.Drawing.Point(225, 168);
            this.chkCD.Name = "chkCD";
            this.chkCD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCD.Size = new System.Drawing.Size(145, 19);
            this.chkCD.TabIndex = 15;
            this.chkCD.Text = "CD (Cardinal number)";
            this.chkCD.UseVisualStyleBackColor = true;
            // 
            // chkFW
            // 
            this.chkFW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFW.AutoSize = true;
            this.chkFW.Enabled = false;
            this.chkFW.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFW.Location = new System.Drawing.Point(225, 196);
            this.chkFW.Name = "chkFW";
            this.chkFW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFW.Size = new System.Drawing.Size(129, 19);
            this.chkFW.TabIndex = 16;
            this.chkFW.Text = "FW (Foreign Word)";
            this.chkFW.UseVisualStyleBackColor = true;
            // 
            // chkJJR
            // 
            this.chkJJR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJJR.AutoSize = true;
            this.chkJJR.Enabled = false;
            this.chkJJR.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJJR.Location = new System.Drawing.Point(225, 228);
            this.chkJJR.Name = "chkJJR";
            this.chkJJR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkJJR.Size = new System.Drawing.Size(170, 19);
            this.chkJJR.TabIndex = 17;
            this.chkJJR.Text = "JJR (Adjective,Comparator)";
            this.chkJJR.UseVisualStyleBackColor = true;
            // 
            // chkMD
            // 
            this.chkMD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMD.AutoSize = true;
            this.chkMD.Enabled = false;
            this.chkMD.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMD.Location = new System.Drawing.Point(225, 257);
            this.chkMD.Name = "chkMD";
            this.chkMD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkMD.Size = new System.Drawing.Size(92, 19);
            this.chkMD.TabIndex = 18;
            this.chkMD.Text = "MD (Modal)";
            this.chkMD.UseVisualStyleBackColor = true;
            // 
            // chkPRP
            // 
            this.chkPRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPRP.AutoSize = true;
            this.chkPRP.Enabled = false;
            this.chkPRP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPRP.Location = new System.Drawing.Point(225, 282);
            this.chkPRP.Name = "chkPRP";
            this.chkPRP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPRP.Size = new System.Drawing.Size(157, 19);
            this.chkPRP.TabIndex = 19;
            this.chkPRP.Text = "PRP (Personal Pronoun)";
            this.chkPRP.UseVisualStyleBackColor = true;
            // 
            // chkRBR
            // 
            this.chkRBR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRBR.AutoSize = true;
            this.chkRBR.Enabled = false;
            this.chkRBR.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRBR.Location = new System.Drawing.Point(225, 328);
            this.chkRBR.Name = "chkRBR";
            this.chkRBR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRBR.Size = new System.Drawing.Size(167, 19);
            this.chkRBR.TabIndex = 20;
            this.chkRBR.Text = "RBR (Adverb,comparative)";
            this.chkRBR.UseVisualStyleBackColor = true;
            // 
            // chkWRB
            // 
            this.chkWRB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWRB.AutoSize = true;
            this.chkWRB.Enabled = false;
            this.chkWRB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWRB.Location = new System.Drawing.Point(226, 532);
            this.chkWRB.Name = "chkWRB";
            this.chkWRB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkWRB.Size = new System.Drawing.Size(120, 19);
            this.chkWRB.TabIndex = 21;
            this.chkWRB.Text = "WRB (wh adverb)";
            this.chkWRB.UseVisualStyleBackColor = true;
            // 
            // chkSYM
            // 
            this.chkSYM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSYM.AutoSize = true;
            this.chkSYM.Enabled = false;
            this.chkSYM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSYM.Location = new System.Drawing.Point(226, 364);
            this.chkSYM.Name = "chkSYM";
            this.chkSYM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSYM.Size = new System.Drawing.Size(100, 19);
            this.chkSYM.TabIndex = 22;
            this.chkSYM.Text = "SYM (Symbol)";
            this.chkSYM.UseVisualStyleBackColor = true;
            // 
            // chkWDT
            // 
            this.chkWDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWDT.AutoSize = true;
            this.chkWDT.Enabled = false;
            this.chkWDT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWDT.Location = new System.Drawing.Point(226, 498);
            this.chkWDT.Name = "chkWDT";
            this.chkWDT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkWDT.Size = new System.Drawing.Size(142, 19);
            this.chkWDT.TabIndex = 23;
            this.chkWDT.Text = "WDT (wh determiner)";
            this.chkWDT.UseVisualStyleBackColor = true;
            // 
            // chkVB
            // 
            this.chkVB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVB.AutoSize = true;
            this.chkVB.Enabled = false;
            this.chkVB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVB.Location = new System.Drawing.Point(226, 399);
            this.chkVB.Name = "chkVB";
            this.chkVB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkVB.Size = new System.Drawing.Size(133, 19);
            this.chkVB.TabIndex = 24;
            this.chkVB.Text = "VB (Verb,base form)";
            this.chkVB.UseVisualStyleBackColor = true;
            // 
            // chkVBN
            // 
            this.chkVBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVBN.AutoSize = true;
            this.chkVBN.Enabled = false;
            this.chkVBN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVBN.Location = new System.Drawing.Point(226, 435);
            this.chkVBN.Name = "chkVBN";
            this.chkVBN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkVBN.Size = new System.Drawing.Size(166, 19);
            this.chkVBN.TabIndex = 25;
            this.chkVBN.Text = "VBN (Verb,past participle)";
            this.chkVBN.UseVisualStyleBackColor = true;
            // 
            // chkCC
            // 
            this.chkCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCC.AutoSize = true;
            this.chkCC.Enabled = false;
            this.chkCC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCC.Location = new System.Drawing.Point(7, 168);
            this.chkCC.Name = "chkCC";
            this.chkCC.Size = new System.Drawing.Size(190, 19);
            this.chkCC.TabIndex = 4;
            this.chkCC.Text = "CC (Coordinating conjunction)";
            this.chkCC.UseVisualStyleBackColor = true;
            // 
            // chkEX
            // 
            this.chkEX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEX.AutoSize = true;
            this.chkEX.Enabled = false;
            this.chkEX.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEX.Location = new System.Drawing.Point(7, 196);
            this.chkEX.Name = "chkEX";
            this.chkEX.Size = new System.Drawing.Size(128, 19);
            this.chkEX.TabIndex = 5;
            this.chkEX.Text = "EX (Extential there)";
            this.chkEX.UseVisualStyleBackColor = true;
            // 
            // chkJJ
            // 
            this.chkJJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJJ.AutoSize = true;
            this.chkJJ.Enabled = false;
            this.chkJJ.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJJ.Location = new System.Drawing.Point(7, 228);
            this.chkJJ.Name = "chkJJ";
            this.chkJJ.Size = new System.Drawing.Size(94, 19);
            this.chkJJ.TabIndex = 6;
            this.chkJJ.Text = "JJ (Adjective)";
            this.chkJJ.UseVisualStyleBackColor = true;
            // 
            // chkLS
            // 
            this.chkLS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLS.AutoSize = true;
            this.chkLS.Enabled = false;
            this.chkLS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLS.Location = new System.Drawing.Point(7, 257);
            this.chkLS.Name = "chkLS";
            this.chkLS.Size = new System.Drawing.Size(136, 19);
            this.chkLS.TabIndex = 7;
            this.chkLS.Text = "LS (List item marker)";
            this.chkLS.UseVisualStyleBackColor = true;
            // 
            // chkPOS
            // 
            this.chkPOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPOS.AutoSize = true;
            this.chkPOS.Enabled = false;
            this.chkPOS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPOS.Location = new System.Drawing.Point(7, 282);
            this.chkPOS.Name = "chkPOS";
            this.chkPOS.Size = new System.Drawing.Size(153, 19);
            this.chkPOS.TabIndex = 8;
            this.chkPOS.Text = "POS (Possesive ending)";
            this.chkPOS.UseVisualStyleBackColor = true;
            // 
            // chkRB
            // 
            this.chkRB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRB.AutoSize = true;
            this.chkRB.Enabled = false;
            this.chkRB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRB.Location = new System.Drawing.Point(7, 328);
            this.chkRB.Name = "chkRB";
            this.chkRB.Size = new System.Drawing.Size(89, 19);
            this.chkRB.TabIndex = 9;
            this.chkRB.Text = "RB (Adverb)";
            this.chkRB.UseVisualStyleBackColor = true;
            // 
            // chkRP
            // 
            this.chkRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRP.AutoSize = true;
            this.chkRP.Enabled = false;
            this.chkRP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRP.Location = new System.Drawing.Point(8, 364);
            this.chkRP.Name = "chkRP";
            this.chkRP.Size = new System.Drawing.Size(96, 19);
            this.chkRP.TabIndex = 10;
            this.chkRP.Text = "RP (Particle )";
            this.chkRP.UseVisualStyleBackColor = true;
            // 
            // chkUH
            // 
            this.chkUH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUH.AutoSize = true;
            this.chkUH.Enabled = false;
            this.chkUH.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUH.Location = new System.Drawing.Point(8, 399);
            this.chkUH.Name = "chkUH";
            this.chkUH.Size = new System.Drawing.Size(116, 19);
            this.chkUH.TabIndex = 11;
            this.chkUH.Text = "UH (Interjection)";
            this.chkUH.UseVisualStyleBackColor = true;
            // 
            // chkVBJ
            // 
            this.chkVBJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVBJ.AutoSize = true;
            this.chkVBJ.Enabled = false;
            this.chkVBJ.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVBJ.Location = new System.Drawing.Point(8, 435);
            this.chkVBJ.Name = "chkVBJ";
            this.chkVBJ.Size = new System.Drawing.Size(145, 34);
            this.chkVBJ.TabIndex = 12;
            this.chkVBJ.Text = "VBG ( Verb, ground or \r\npresent participle)";
            this.chkVBJ.UseVisualStyleBackColor = true;
            // 
            // chkVBZ
            // 
            this.chkVBZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVBZ.AutoSize = true;
            this.chkVBZ.Enabled = false;
            this.chkVBZ.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVBZ.Location = new System.Drawing.Point(8, 483);
            this.chkVBZ.Name = "chkVBZ";
            this.chkVBZ.Size = new System.Drawing.Size(124, 34);
            this.chkVBZ.TabIndex = 13;
            this.chkVBZ.Text = "VBZ (Verb,3rd \r\nperson participle)";
            this.chkVBZ.UseVisualStyleBackColor = true;
            // 
            // chkWPDoller
            // 
            this.chkWPDoller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWPDoller.AutoSize = true;
            this.chkWPDoller.Enabled = false;
            this.chkWPDoller.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWPDoller.Location = new System.Drawing.Point(8, 532);
            this.chkWPDoller.Name = "chkWPDoller";
            this.chkWPDoller.Size = new System.Drawing.Size(183, 19);
            this.chkWPDoller.TabIndex = 14;
            this.chkWPDoller.Text = "WP$(Possesive wh pronoun)";
            this.chkWPDoller.UseVisualStyleBackColor = true;
            // 
            // lblExpectNounSection
            // 
            this.lblExpectNounSection.AutoSize = true;
            this.lblExpectNounSection.Location = new System.Drawing.Point(2, 134);
            this.lblExpectNounSection.Name = "lblExpectNounSection";
            this.lblExpectNounSection.Size = new System.Drawing.Size(402, 15);
            this.lblExpectNounSection.TabIndex = 2;
            this.lblExpectNounSection.Text = "Natural language forms eliminated by default in the algorithm on results";
            // 
            // lkblNounsSection
            // 
            this.lkblNounsSection.AutoSize = true;
            this.lkblNounsSection.Location = new System.Drawing.Point(4, 30);
            this.lkblNounsSection.Name = "lkblNounsSection";
            this.lkblNounsSection.Size = new System.Drawing.Size(454, 15);
            this.lkblNounsSection.TabIndex = 1;
            this.lkblNounsSection.Text = "Natural language with POS Tagging is applied by default in the algorithm on resul" +
    "ts";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(231, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "NNPS (Pronoun,Plural)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(5, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "NNP (Pronoun,Singular)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkNNS
            // 
            this.chkNNS.AutoSize = true;
            this.chkNNS.Checked = true;
            this.chkNNS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNNS.Enabled = false;
            this.chkNNS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNNS.Location = new System.Drawing.Point(231, 60);
            this.chkNNS.Name = "chkNNS";
            this.chkNNS.Size = new System.Drawing.Size(125, 19);
            this.chkNNS.TabIndex = 0;
            this.chkNNS.Text = "NNS (Noun,Plural)";
            this.chkNNS.UseVisualStyleBackColor = true;
            // 
            // chkNN
            // 
            this.chkNN.AutoSize = true;
            this.chkNN.Checked = true;
            this.chkNN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNN.Enabled = false;
            this.chkNN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNN.Location = new System.Drawing.Point(5, 60);
            this.chkNN.Name = "chkNN";
            this.chkNN.Size = new System.Drawing.Size(131, 19);
            this.chkNN.TabIndex = 0;
            this.chkNN.Text = "NN (Noun,Singular)";
            this.chkNN.UseVisualStyleBackColor = true;
            // 
            // pnlCPUUsage
            // 
            this.pnlCPUUsage.Controls.Add(this.lblRAM);
            this.pnlCPUUsage.Controls.Add(this.lblCPU);
            this.pnlCPUUsage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCPUUsage.Location = new System.Drawing.Point(0, 642);
            this.pnlCPUUsage.Name = "pnlCPUUsage";
            this.pnlCPUUsage.Size = new System.Drawing.Size(573, 54);
            this.pnlCPUUsage.TabIndex = 0;
            // 
            // KeywordsTabControl
            // 
            this.KeywordsTabControl.Controls.Add(this.SearchTabPage);
            this.KeywordsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeywordsTabControl.Location = new System.Drawing.Point(0, 0);
            this.KeywordsTabControl.Name = "KeywordsTabControl";
            this.KeywordsTabControl.SelectedIndex = 0;
            this.KeywordsTabControl.Size = new System.Drawing.Size(1224, 728);
            this.KeywordsTabControl.TabIndex = 21;
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.KeywordsSplitContainer);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 22);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(1216, 702);
            this.SearchTabPage.TabIndex = 0;
            this.SearchTabPage.Text = "Search";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // KeywordsOpenFileDialog
            // 
            this.KeywordsOpenFileDialog.FileName = "KeywordsOpenFileDialog";
            // 
            // fmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1224, 728);
            this.Controls.Add(this.KeywordsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmConverter";
            this.Text = "Keyword Search";
            this.Load += new System.EventHandler(this.fmConverter_Load);
            this.KeywordsSplitContainer.Panel1.ResumeLayout(false);
            this.KeywordsSplitContainer.Panel1.PerformLayout();
            this.KeywordsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeywordsSplitContainer)).EndInit();
            this.KeywordsSplitContainer.ResumeLayout(false);
            this.grpResultView.ResumeLayout(false);
            this.grpResultView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchOutput)).EndInit();
            this.grpQuery.ResumeLayout(false);
            this.grpQuery.PerformLayout();
            this.grpTextOperations.ResumeLayout(false);
            this.grpTextOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIndexNumericUpDown)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.grpNLPOperations.ResumeLayout(false);
            this.grpNLPOperations.PerformLayout();
            this.pnlCPUUsage.ResumeLayout(false);
            this.pnlCPUUsage.PerformLayout();
            this.KeywordsTabControl.ResumeLayout(false);
            this.SearchTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SourceQueryText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FtsQueryTextBox;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.SplitContainer KeywordsSplitContainer;
        private System.Windows.Forms.TabControl KeywordsTabControl;
        private System.Windows.Forms.TabPage SearchTabPage;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ComboBox cmbSearchTypes;
        private System.Windows.Forms.Panel pnlCPUUsage;
        private System.Windows.Forms.GroupBox grpTextOperations;
        private System.Windows.Forms.ComboBox cmbSearchDirection;
        private System.Windows.Forms.Label lblSearchDirection;
        private System.Windows.Forms.NumericUpDown SearchIndexNumericUpDown;
        private System.Windows.Forms.Label lblSearchIndex;
        private System.Windows.Forms.DataGridView dgvSearchOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOccurenceCount;
        private System.Windows.Forms.GroupBox grpQuery;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSearchResultsCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TreeView KeywordsTreeView;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpResultView;
        private System.Windows.Forms.Button btnExpandTreeView;
        private System.Windows.Forms.Button btnCollapseTreeview;
        private System.Windows.Forms.GroupBox grpNLPOperations;
        private System.Windows.Forms.CheckBox chkNNS;
        private System.Windows.Forms.CheckBox chkNN;
        private System.Windows.Forms.Label lkblNounsSection;
        private System.Windows.Forms.Label lblExpectNounSection;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkDT;
        private System.Windows.Forms.CheckBox chkIN;
        private System.Windows.Forms.CheckBox chkJJS;
        private System.Windows.Forms.CheckBox chkPDT;
        private System.Windows.Forms.CheckBox chkWP;
        private System.Windows.Forms.CheckBox chkPRPDollar;
        private System.Windows.Forms.CheckBox chkVBP;
        private System.Windows.Forms.CheckBox chkRBS;
        private System.Windows.Forms.CheckBox chkVBD;
        private System.Windows.Forms.CheckBox chkTO;
        private System.Windows.Forms.CheckBox chkCD;
        private System.Windows.Forms.CheckBox chkFW;
        private System.Windows.Forms.CheckBox chkJJR;
        private System.Windows.Forms.CheckBox chkMD;
        private System.Windows.Forms.CheckBox chkPRP;
        private System.Windows.Forms.CheckBox chkRBR;
        private System.Windows.Forms.CheckBox chkWRB;
        private System.Windows.Forms.CheckBox chkSYM;
        private System.Windows.Forms.CheckBox chkWDT;
        private System.Windows.Forms.CheckBox chkVB;
        private System.Windows.Forms.CheckBox chkVBN;
        private System.Windows.Forms.CheckBox chkCC;
        private System.Windows.Forms.CheckBox chkEX;
        private System.Windows.Forms.CheckBox chkJJ;
        private System.Windows.Forms.CheckBox chkLS;
        private System.Windows.Forms.CheckBox chkPOS;
        private System.Windows.Forms.CheckBox chkRB;
        private System.Windows.Forms.CheckBox chkRP;
        private System.Windows.Forms.CheckBox chkUH;
        private System.Windows.Forms.CheckBox chkVBJ;
        private System.Windows.Forms.CheckBox chkVBZ;
        private System.Windows.Forms.CheckBox chkWPDoller;
        private System.Windows.Forms.OpenFileDialog KeywordsOpenFileDialog;
    }
}

