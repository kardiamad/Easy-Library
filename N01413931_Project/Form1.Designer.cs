
namespace N01413931_Project
{
    partial class frmMain
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
            System.Windows.Forms.Label lblISBNFind;
            System.Windows.Forms.Label lblTitleFind;
            System.Windows.Forms.Label lblTypeFind;
            System.Windows.Forms.Label lblStatusFind;
            System.Windows.Forms.Label lblGenreFind;
            System.Windows.Forms.Label lblPublisherFind;
            System.Windows.Forms.Label lblPublDateFind;
            System.Windows.Forms.Label lblDescFind;
            System.Windows.Forms.Label lblISBN;
            System.Windows.Forms.Label lblTitle;
            System.Windows.Forms.Label lblStatus;
            System.Windows.Forms.Label lblGenre;
            System.Windows.Forms.Label lblPublisher;
            System.Windows.Forms.Label lblPublDate;
            System.Windows.Forms.Label lblDesc;
            System.Windows.Forms.Label lblType;
            this.btnSign = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.tbBooks = new System.Windows.Forms.TabControl();
            this.tbpAdd = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtxtbxDesc = new System.Windows.Forms.RichTextBox();
            this.dtpAdd = new System.Windows.Forms.DateTimePicker();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.tbpFind = new System.Windows.Forms.TabPage();
            this.dtpChange = new System.Windows.Forms.DateTimePicker();
            this.cmbxGenreChange = new System.Windows.Forms.ComboBox();
            this.cmbxStatusChange = new System.Windows.Forms.ComboBox();
            this.cmbxTypeChange = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.rtxtbxDescFind = new System.Windows.Forms.RichTextBox();
            this.txtPublisherFind = new System.Windows.Forms.TextBox();
            this.txtTitleFind = new System.Windows.Forms.TextBox();
            this.txtISBNFind = new System.Windows.Forms.TextBox();
            this.tbpDisplay = new System.Windows.Forms.TabPage();
            this.bookTableDataGridView = new System.Windows.Forms.DataGridView();
            this.bookTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseLibraryDataSet = new N01413931_Project.DatabaseLibraryDataSet();
            this.bookTableTableAdapter = new N01413931_Project.DatabaseLibraryDataSetTableAdapters.BookTableTableAdapter();
            this.tableAdapterManager = new N01413931_Project.DatabaseLibraryDataSetTableAdapters.TableAdapterManager();
            this.mnuLibrary = new System.Windows.Forms.MenuStrip();
            this.mnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblISBNFind = new System.Windows.Forms.Label();
            lblTitleFind = new System.Windows.Forms.Label();
            lblTypeFind = new System.Windows.Forms.Label();
            lblStatusFind = new System.Windows.Forms.Label();
            lblGenreFind = new System.Windows.Forms.Label();
            lblPublisherFind = new System.Windows.Forms.Label();
            lblPublDateFind = new System.Windows.Forms.Label();
            lblDescFind = new System.Windows.Forms.Label();
            lblISBN = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblGenre = new System.Windows.Forms.Label();
            lblPublisher = new System.Windows.Forms.Label();
            lblPublDate = new System.Windows.Forms.Label();
            lblDesc = new System.Windows.Forms.Label();
            lblType = new System.Windows.Forms.Label();
            this.tbBooks.SuspendLayout();
            this.tbpAdd.SuspendLayout();
            this.tbpFind.SuspendLayout();
            this.tbpDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLibraryDataSet)).BeginInit();
            this.mnuLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblISBNFind
            // 
            lblISBNFind.AutoSize = true;
            lblISBNFind.Location = new System.Drawing.Point(86, 28);
            lblISBNFind.Name = "lblISBNFind";
            lblISBNFind.Size = new System.Drawing.Size(57, 20);
            lblISBNFind.TabIndex = 0;
            lblISBNFind.Text = "*ISBN:";
            // 
            // lblTitleFind
            // 
            lblTitleFind.AutoSize = true;
            lblTitleFind.Location = new System.Drawing.Point(95, 64);
            lblTitleFind.Name = "lblTitleFind";
            lblTitleFind.Size = new System.Drawing.Size(42, 20);
            lblTitleFind.TabIndex = 2;
            lblTitleFind.Text = "Title:";
            // 
            // lblTypeFind
            // 
            lblTypeFind.AutoSize = true;
            lblTypeFind.Location = new System.Drawing.Point(90, 96);
            lblTypeFind.Name = "lblTypeFind";
            lblTypeFind.Size = new System.Drawing.Size(47, 20);
            lblTypeFind.TabIndex = 4;
            lblTypeFind.Text = "Type:";
            // 
            // lblStatusFind
            // 
            lblStatusFind.AutoSize = true;
            lblStatusFind.Location = new System.Drawing.Point(77, 130);
            lblStatusFind.Name = "lblStatusFind";
            lblStatusFind.Size = new System.Drawing.Size(60, 20);
            lblStatusFind.TabIndex = 6;
            lblStatusFind.Text = "Status:";
            // 
            // lblGenreFind
            // 
            lblGenreFind.AutoSize = true;
            lblGenreFind.Location = new System.Drawing.Point(79, 162);
            lblGenreFind.Name = "lblGenreFind";
            lblGenreFind.Size = new System.Drawing.Size(58, 20);
            lblGenreFind.TabIndex = 8;
            lblGenreFind.Text = "Genre:";
            // 
            // lblPublisherFind
            // 
            lblPublisherFind.AutoSize = true;
            lblPublisherFind.Location = new System.Drawing.Point(59, 194);
            lblPublisherFind.Name = "lblPublisherFind";
            lblPublisherFind.Size = new System.Drawing.Size(78, 20);
            lblPublisherFind.TabIndex = 10;
            lblPublisherFind.Text = "Publisher:";
            // 
            // lblPublDateFind
            // 
            lblPublDateFind.AutoSize = true;
            lblPublDateFind.Location = new System.Drawing.Point(13, 228);
            lblPublDateFind.Name = "lblPublDateFind";
            lblPublDateFind.Size = new System.Drawing.Size(124, 20);
            lblPublDateFind.TabIndex = 12;
            lblPublDateFind.Text = "Publishing Date:";
            // 
            // lblDescFind
            // 
            lblDescFind.AutoSize = true;
            lblDescFind.Location = new System.Drawing.Point(44, 262);
            lblDescFind.Name = "lblDescFind";
            lblDescFind.Size = new System.Drawing.Size(93, 20);
            lblDescFind.TabIndex = 14;
            lblDescFind.Text = "Description:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new System.Drawing.Point(39, 18);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new System.Drawing.Size(57, 20);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "*ISBN:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(39, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(48, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "*Title:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(39, 114);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(66, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "*Status:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new System.Drawing.Point(39, 146);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new System.Drawing.Size(58, 20);
            lblGenre.TabIndex = 8;
            lblGenre.Text = "Genre:";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new System.Drawing.Point(39, 178);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new System.Drawing.Size(78, 20);
            lblPublisher.TabIndex = 10;
            lblPublisher.Text = "Publisher:";
            // 
            // lblPublDate
            // 
            lblPublDate.AutoSize = true;
            lblPublDate.Location = new System.Drawing.Point(39, 210);
            lblPublDate.Name = "lblPublDate";
            lblPublDate.Size = new System.Drawing.Size(124, 20);
            lblPublDate.TabIndex = 12;
            lblPublDate.Text = "Publishing Date:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new System.Drawing.Point(39, 242);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new System.Drawing.Size(93, 20);
            lblDesc.TabIndex = 14;
            lblDesc.Text = "Description:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new System.Drawing.Point(39, 80);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(53, 20);
            lblType.TabIndex = 15;
            lblType.Text = "*Type:";
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.DarkGray;
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSign.Location = new System.Drawing.Point(757, 27);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(118, 36);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "Sign In";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(580, 40);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(64, 13);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "User name: ";
            this.lblAccount.Click += new System.EventHandler(this.lblAccount_Click);
            // 
            // tbBooks
            // 
            this.tbBooks.Controls.Add(this.tbpAdd);
            this.tbBooks.Controls.Add(this.tbpFind);
            this.tbBooks.Controls.Add(this.tbpDisplay);
            this.tbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBooks.Location = new System.Drawing.Point(12, 69);
            this.tbBooks.Name = "tbBooks";
            this.tbBooks.SelectedIndex = 0;
            this.tbBooks.Size = new System.Drawing.Size(893, 373);
            this.tbBooks.TabIndex = 2;
            this.tbBooks.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbBooks_Selected);
            // 
            // tbpAdd
            // 
            this.tbpAdd.AutoScroll = true;
            this.tbpAdd.BackColor = System.Drawing.Color.LightGray;
            this.tbpAdd.Controls.Add(this.btnAdd);
            this.tbpAdd.Controls.Add(this.rtxtbxDesc);
            this.tbpAdd.Controls.Add(this.dtpAdd);
            this.tbpAdd.Controls.Add(this.txtPublisher);
            this.tbpAdd.Controls.Add(this.cmbxGenre);
            this.tbpAdd.Controls.Add(this.cmbxStatus);
            this.tbpAdd.Controls.Add(this.cmbxType);
            this.tbpAdd.Controls.Add(this.txtTitle);
            this.tbpAdd.Controls.Add(this.txtISBN);
            this.tbpAdd.Controls.Add(lblType);
            this.tbpAdd.Controls.Add(lblISBN);
            this.tbpAdd.Controls.Add(lblTitle);
            this.tbpAdd.Controls.Add(lblStatus);
            this.tbpAdd.Controls.Add(lblGenre);
            this.tbpAdd.Controls.Add(lblPublisher);
            this.tbpAdd.Controls.Add(lblPublDate);
            this.tbpAdd.Controls.Add(lblDesc);
            this.tbpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpAdd.Location = new System.Drawing.Point(4, 29);
            this.tbpAdd.Name = "tbpAdd";
            this.tbpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdd.Size = new System.Drawing.Size(885, 340);
            this.tbpAdd.TabIndex = 0;
            this.tbpAdd.Text = "Add Books";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(741, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtxtbxDesc
            // 
            this.rtxtbxDesc.Location = new System.Drawing.Point(206, 239);
            this.rtxtbxDesc.Name = "rtxtbxDesc";
            this.rtxtbxDesc.Size = new System.Drawing.Size(442, 80);
            this.rtxtbxDesc.TabIndex = 23;
            this.rtxtbxDesc.Text = "";
            // 
            // dtpAdd
            // 
            this.dtpAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdd.Location = new System.Drawing.Point(206, 205);
            this.dtpAdd.Name = "dtpAdd";
            this.dtpAdd.Size = new System.Drawing.Size(142, 26);
            this.dtpAdd.TabIndex = 22;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(206, 175);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(628, 26);
            this.txtPublisher.TabIndex = 21;
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Location = new System.Drawing.Point(206, 143);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(226, 28);
            this.cmbxGenre.TabIndex = 20;
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Location = new System.Drawing.Point(206, 111);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(226, 28);
            this.cmbxStatus.TabIndex = 19;
            // 
            // cmbxType
            // 
            this.cmbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Location = new System.Drawing.Point(206, 77);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(226, 28);
            this.cmbxType.TabIndex = 18;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(206, 47);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(628, 26);
            this.txtTitle.TabIndex = 17;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(206, 15);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(406, 26);
            this.txtISBN.TabIndex = 16;
            // 
            // tbpFind
            // 
            this.tbpFind.AutoScroll = true;
            this.tbpFind.BackColor = System.Drawing.Color.LightGray;
            this.tbpFind.Controls.Add(this.dtpChange);
            this.tbpFind.Controls.Add(this.cmbxGenreChange);
            this.tbpFind.Controls.Add(this.cmbxStatusChange);
            this.tbpFind.Controls.Add(this.cmbxTypeChange);
            this.tbpFind.Controls.Add(this.btnChange);
            this.tbpFind.Controls.Add(this.btnRem);
            this.tbpFind.Controls.Add(this.btnFind);
            this.tbpFind.Controls.Add(this.rtxtbxDescFind);
            this.tbpFind.Controls.Add(this.txtPublisherFind);
            this.tbpFind.Controls.Add(this.txtTitleFind);
            this.tbpFind.Controls.Add(this.txtISBNFind);
            this.tbpFind.Controls.Add(lblDescFind);
            this.tbpFind.Controls.Add(lblPublDateFind);
            this.tbpFind.Controls.Add(lblPublisherFind);
            this.tbpFind.Controls.Add(lblGenreFind);
            this.tbpFind.Controls.Add(lblStatusFind);
            this.tbpFind.Controls.Add(lblTypeFind);
            this.tbpFind.Controls.Add(lblTitleFind);
            this.tbpFind.Controls.Add(lblISBNFind);
            this.tbpFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpFind.Location = new System.Drawing.Point(4, 29);
            this.tbpFind.Name = "tbpFind";
            this.tbpFind.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFind.Size = new System.Drawing.Size(885, 340);
            this.tbpFind.TabIndex = 1;
            this.tbpFind.Text = "Find/Change/Remove";
            // 
            // dtpChange
            // 
            this.dtpChange.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChange.Location = new System.Drawing.Point(173, 223);
            this.dtpChange.Name = "dtpChange";
            this.dtpChange.Size = new System.Drawing.Size(150, 26);
            this.dtpChange.TabIndex = 28;
            // 
            // cmbxGenreChange
            // 
            this.cmbxGenreChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxGenreChange.FormattingEnabled = true;
            this.cmbxGenreChange.Location = new System.Drawing.Point(173, 159);
            this.cmbxGenreChange.Name = "cmbxGenreChange";
            this.cmbxGenreChange.Size = new System.Drawing.Size(238, 28);
            this.cmbxGenreChange.TabIndex = 27;
            // 
            // cmbxStatusChange
            // 
            this.cmbxStatusChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStatusChange.FormattingEnabled = true;
            this.cmbxStatusChange.Location = new System.Drawing.Point(173, 127);
            this.cmbxStatusChange.Name = "cmbxStatusChange";
            this.cmbxStatusChange.Size = new System.Drawing.Size(238, 28);
            this.cmbxStatusChange.TabIndex = 26;
            // 
            // cmbxTypeChange
            // 
            this.cmbxTypeChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTypeChange.FormattingEnabled = true;
            this.cmbxTypeChange.Location = new System.Drawing.Point(173, 93);
            this.cmbxTypeChange.Name = "cmbxTypeChange";
            this.cmbxTypeChange.Size = new System.Drawing.Size(238, 28);
            this.cmbxTypeChange.TabIndex = 25;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DarkGray;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.Location = new System.Drawing.Point(692, 282);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(89, 38);
            this.btnChange.TabIndex = 24;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRem
            // 
            this.btnRem.BackColor = System.Drawing.Color.DarkGray;
            this.btnRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRem.Location = new System.Drawing.Point(787, 282);
            this.btnRem.Name = "btnRem";
            this.btnRem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRem.Size = new System.Drawing.Size(92, 38);
            this.btnRem.TabIndex = 23;
            this.btnRem.Text = "Remove";
            this.btnRem.UseVisualStyleBackColor = false;
            this.btnRem.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DarkGray;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(594, 282);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(92, 38);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // rtxtbxDescFind
            // 
            this.rtxtbxDescFind.Enabled = false;
            this.rtxtbxDescFind.Location = new System.Drawing.Point(173, 259);
            this.rtxtbxDescFind.Name = "rtxtbxDescFind";
            this.rtxtbxDescFind.Size = new System.Drawing.Size(402, 61);
            this.rtxtbxDescFind.TabIndex = 22;
            this.rtxtbxDescFind.Text = "";
            // 
            // txtPublisherFind
            // 
            this.txtPublisherFind.Enabled = false;
            this.txtPublisherFind.Location = new System.Drawing.Point(173, 191);
            this.txtPublisherFind.Name = "txtPublisherFind";
            this.txtPublisherFind.Size = new System.Drawing.Size(575, 26);
            this.txtPublisherFind.TabIndex = 20;
            // 
            // txtTitleFind
            // 
            this.txtTitleFind.Location = new System.Drawing.Point(173, 61);
            this.txtTitleFind.Name = "txtTitleFind";
            this.txtTitleFind.Size = new System.Drawing.Size(575, 26);
            this.txtTitleFind.TabIndex = 16;
            // 
            // txtISBNFind
            // 
            this.txtISBNFind.Location = new System.Drawing.Point(173, 25);
            this.txtISBNFind.Name = "txtISBNFind";
            this.txtISBNFind.Size = new System.Drawing.Size(385, 26);
            this.txtISBNFind.TabIndex = 15;
            // 
            // tbpDisplay
            // 
            this.tbpDisplay.AutoScroll = true;
            this.tbpDisplay.Controls.Add(this.bookTableDataGridView);
            this.tbpDisplay.Location = new System.Drawing.Point(4, 29);
            this.tbpDisplay.Name = "tbpDisplay";
            this.tbpDisplay.Size = new System.Drawing.Size(885, 340);
            this.tbpDisplay.TabIndex = 2;
            this.tbpDisplay.Text = "Display";
            this.tbpDisplay.UseVisualStyleBackColor = true;
            // 
            // bookTableDataGridView
            // 
            this.bookTableDataGridView.AutoGenerateColumns = false;
            this.bookTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.PublDate,
            this.dataGridViewTextBoxColumn8});
            this.bookTableDataGridView.DataSource = this.bookTableBindingSource;
            this.bookTableDataGridView.Location = new System.Drawing.Point(20, 3);
            this.bookTableDataGridView.Name = "bookTableDataGridView";
            this.bookTableDataGridView.Size = new System.Drawing.Size(849, 331);
            this.bookTableDataGridView.TabIndex = 0;
            // 
            // bookTableBindingSource
            // 
            this.bookTableBindingSource.DataMember = "BookTable";
            this.bookTableBindingSource.DataSource = this.databaseLibraryDataSet;
            // 
            // databaseLibraryDataSet
            // 
            this.databaseLibraryDataSet.DataSetName = "DatabaseLibraryDataSet";
            this.databaseLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableTableAdapter
            // 
            this.bookTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableTableAdapter = this.bookTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = N01413931_Project.DatabaseLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mnuLibrary
            // 
            this.mnuLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFile});
            this.mnuLibrary.Location = new System.Drawing.Point(0, 0);
            this.mnuLibrary.Name = "mnuLibrary";
            this.mnuLibrary.Size = new System.Drawing.Size(917, 24);
            this.mnuLibrary.TabIndex = 3;
            this.mnuLibrary.Text = "Library";
            // 
            // mnuItemFile
            // 
            this.mnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemExit});
            this.mnuItemFile.Name = "mnuItemFile";
            this.mnuItemFile.Size = new System.Drawing.Size(37, 20);
            this.mnuItemFile.Text = "File";
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(93, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn6.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // PublDate
            // 
            this.PublDate.DataPropertyName = "PublDate";
            this.PublDate.HeaderText = "PublDate";
            this.PublDate.Name = "PublDate";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(917, 454);
            this.Controls.Add(this.tbBooks);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.mnuLibrary);
            this.MainMenuStrip = this.mnuLibrary;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Library";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbBooks.ResumeLayout(false);
            this.tbpAdd.ResumeLayout(false);
            this.tbpAdd.PerformLayout();
            this.tbpFind.ResumeLayout(false);
            this.tbpFind.PerformLayout();
            this.tbpDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLibraryDataSet)).EndInit();
            this.mnuLibrary.ResumeLayout(false);
            this.mnuLibrary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSign;
        public System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TabControl tbBooks;
        private System.Windows.Forms.TabPage tbpAdd;
        private System.Windows.Forms.TabPage tbpFind;
        private System.Windows.Forms.TabPage tbpDisplay;
        private DatabaseLibraryDataSet databaseLibraryDataSet;
        private System.Windows.Forms.BindingSource bookTableBindingSource;
        private DatabaseLibraryDataSetTableAdapters.BookTableTableAdapter bookTableTableAdapter;
        private DatabaseLibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtxtbxDesc;
        private System.Windows.Forms.DateTimePicker dtpAdd;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.ComboBox cmbxGenre;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.ComboBox cmbxType;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RichTextBox rtxtbxDescFind;
        private System.Windows.Forms.TextBox txtPublisherFind;
        private System.Windows.Forms.TextBox txtTitleFind;
        private System.Windows.Forms.TextBox txtISBNFind;
        private System.Windows.Forms.MenuStrip mnuLibrary;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.DateTimePicker dtpChange;
        private System.Windows.Forms.ComboBox cmbxGenreChange;
        private System.Windows.Forms.ComboBox cmbxStatusChange;
        private System.Windows.Forms.ComboBox cmbxTypeChange;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

