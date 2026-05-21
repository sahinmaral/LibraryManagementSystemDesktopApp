namespace LibraryManagementSystem.UI.BookQuery
{
    partial class BookQuery
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
            this.dtGridViewBooks = new System.Windows.Forms.DataGridView();
            this.tblLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPersonForm = new System.Windows.Forms.TableLayoutPanel();
            this.cboBookWriter = new System.Windows.Forms.ComboBox();
            this.txtBoxBookIsbnNo = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookIsbnNo = new System.Windows.Forms.Label();
            this.lblBookWriter = new System.Windows.Forms.Label();
            this.lblBookCategory = new System.Windows.Forms.Label();
            this.txtBoxBookName = new System.Windows.Forms.TextBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lblBookPageCount = new System.Windows.Forms.Label();
            this.cboBookCategory = new System.Windows.Forms.ComboBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.nmrUpDownBookPageCount = new System.Windows.Forms.NumericUpDown();
            this.btnGetPersonAllForms = new System.Windows.Forms.Button();
            this.tblLayoutSearchFilterHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisplayedFields = new System.Windows.Forms.Label();
            this.panelSearchFilters = new System.Windows.Forms.Panel();
            this.tbLayoutSelectSearchOption = new System.Windows.Forms.TableLayoutPanel();
            this.cboSelectSearchOption = new System.Windows.Forms.ComboBox();
            this.lblSelectSearchOption = new System.Windows.Forms.Label();
            this.tblLayoutDisplayOptions = new System.Windows.Forms.TableLayoutPanel();
            this.choName = new System.Windows.Forms.CheckBox();
            this.choWriterNameSurname = new System.Windows.Forms.CheckBox();
            this.choIsbnNo = new System.Windows.Forms.CheckBox();
            this.choCategoryName = new System.Windows.Forms.CheckBox();
            this.choPageCount = new System.Windows.Forms.CheckBox();
            this.tblLayoutPersonAndPenalty = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxSelectedPersonTurkishId = new System.Windows.Forms.TextBox();
            this.txtBoxSelectedPersonSurname = new System.Windows.Forms.TextBox();
            this.txtBoxSelectedPersonName = new System.Windows.Forms.TextBox();
            this.lblSelectedPersonName = new System.Windows.Forms.Label();
            this.lblSelectedPersonSurname = new System.Windows.Forms.Label();
            this.lblSelectedPersonTurkishId = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.choPersonPenaltyStatus = new System.Windows.Forms.CheckBox();
            this.lblPersonPenaltyStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtPickerPersonPenaltyDate = new System.Windows.Forms.DateTimePicker();
            this.lblPersonPenaltyDate = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewBooks)).BeginInit();
            this.tblLayoutMain.SuspendLayout();
            this.tblLayoutPersonForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDownBookPageCount)).BeginInit();
            this.tblLayoutSearchFilterHeader.SuspendLayout();
            this.tbLayoutSelectSearchOption.SuspendLayout();
            this.tblLayoutDisplayOptions.SuspendLayout();
            this.tblLayoutPersonAndPenalty.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewBooks
            // 
            this.dtGridViewBooks.AllowUserToAddRows = false;
            this.dtGridViewBooks.AllowUserToDeleteRows = false;
            this.dtGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewBooks.Location = new System.Drawing.Point(3, 193);
            this.dtGridViewBooks.MultiSelect = false;
            this.dtGridViewBooks.Name = "dtGridViewBooks";
            this.dtGridViewBooks.ReadOnly = true;
            this.dtGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewBooks.Size = new System.Drawing.Size(1257, 222);
            this.dtGridViewBooks.TabIndex = 95;
            this.dtGridViewBooks.SelectionChanged += new System.EventHandler(this.dtGridViewBooks_SelectionChanged);
            // 
            // tblLayoutMain
            // 
            this.tblLayoutMain.ColumnCount = 1;
            this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayoutMain.Controls.Add(this.tblLayoutPersonForm, 0, 2);
            this.tblLayoutMain.Controls.Add(this.tblLayoutSearchFilterHeader, 0, 0);
            this.tblLayoutMain.Controls.Add(this.dtGridViewBooks, 0, 1);
            this.tblLayoutMain.Controls.Add(this.tblLayoutPersonAndPenalty, 0, 3);
            this.tblLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutMain.Location = new System.Drawing.Point(10, 10);
            this.tblLayoutMain.Name = "tblLayoutMain";
            this.tblLayoutMain.RowCount = 4;
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutMain.Size = new System.Drawing.Size(1263, 760);
            this.tblLayoutMain.TabIndex = 107;
            // 
            // tblLayoutPersonForm
            // 
            this.tblLayoutPersonForm.ColumnCount = 4;
            this.tblLayoutPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutPersonForm.Controls.Add(this.cboBookWriter, 1, 2);
            this.tblLayoutPersonForm.Controls.Add(this.txtBoxBookIsbnNo, 1, 1);
            this.tblLayoutPersonForm.Controls.Add(this.lblBookName, 0, 0);
            this.tblLayoutPersonForm.Controls.Add(this.lblBookIsbnNo, 0, 1);
            this.tblLayoutPersonForm.Controls.Add(this.lblBookWriter, 0, 2);
            this.tblLayoutPersonForm.Controls.Add(this.lblBookCategory, 0, 3);
            this.tblLayoutPersonForm.Controls.Add(this.txtBoxBookName, 1, 0);
            this.tblLayoutPersonForm.Controls.Add(this.btnClearForm, 3, 0);
            this.tblLayoutPersonForm.Controls.Add(this.btnSaveBook, 3, 1);
            this.tblLayoutPersonForm.Controls.Add(this.btnUpdateBook, 3, 2);
            this.tblLayoutPersonForm.Controls.Add(this.btnDeleteBook, 3, 3);
            this.tblLayoutPersonForm.Controls.Add(this.lblBookPageCount, 0, 4);
            this.tblLayoutPersonForm.Controls.Add(this.cboBookCategory, 1, 3);
            this.tblLayoutPersonForm.Controls.Add(this.lblBookId, 2, 0);
            this.tblLayoutPersonForm.Controls.Add(this.nmrUpDownBookPageCount, 1, 4);
            this.tblLayoutPersonForm.Controls.Add(this.btnGetPersonAllForms, 3, 4);
            this.tblLayoutPersonForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPersonForm.Location = new System.Drawing.Point(3, 421);
            this.tblLayoutPersonForm.Name = "tblLayoutPersonForm";
            this.tblLayoutPersonForm.RowCount = 6;
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66944F));
            this.tblLayoutPersonForm.Size = new System.Drawing.Size(1257, 184);
            this.tblLayoutPersonForm.TabIndex = 97;
            // 
            // cboBookWriter
            // 
            this.cboBookWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboBookWriter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboBookWriter.FormattingEnabled = true;
            this.cboBookWriter.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cboBookWriter.Location = new System.Drawing.Point(254, 63);
            this.cboBookWriter.Name = "cboBookWriter";
            this.cboBookWriter.Size = new System.Drawing.Size(496, 28);
            this.cboBookWriter.TabIndex = 81;
            // 
            // txtBoxBookIsbnNo
            // 
            this.txtBoxBookIsbnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxBookIsbnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxBookIsbnNo.Location = new System.Drawing.Point(254, 33);
            this.txtBoxBookIsbnNo.Name = "txtBoxBookIsbnNo";
            this.txtBoxBookIsbnNo.Size = new System.Drawing.Size(496, 26);
            this.txtBoxBookIsbnNo.TabIndex = 8;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBookName.Location = new System.Drawing.Point(3, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(32, 20);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Adı";
            // 
            // lblBookIsbnNo
            // 
            this.lblBookIsbnNo.AutoSize = true;
            this.lblBookIsbnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBookIsbnNo.Location = new System.Drawing.Point(3, 30);
            this.lblBookIsbnNo.Name = "lblBookIsbnNo";
            this.lblBookIsbnNo.Size = new System.Drawing.Size(118, 20);
            this.lblBookIsbnNo.TabIndex = 2;
            this.lblBookIsbnNo.Text = "ISBN Numarası";
            // 
            // lblBookWriter
            // 
            this.lblBookWriter.AutoSize = true;
            this.lblBookWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBookWriter.Location = new System.Drawing.Point(3, 60);
            this.lblBookWriter.Name = "lblBookWriter";
            this.lblBookWriter.Size = new System.Drawing.Size(51, 20);
            this.lblBookWriter.TabIndex = 3;
            this.lblBookWriter.Text = "Yazar";
            // 
            // lblBookCategory
            // 
            this.lblBookCategory.AutoSize = true;
            this.lblBookCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBookCategory.Location = new System.Drawing.Point(3, 90);
            this.lblBookCategory.Name = "lblBookCategory";
            this.lblBookCategory.Size = new System.Drawing.Size(68, 20);
            this.lblBookCategory.TabIndex = 4;
            this.lblBookCategory.Text = "Kategori";
            // 
            // txtBoxBookName
            // 
            this.txtBoxBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxBookName.Location = new System.Drawing.Point(254, 3);
            this.txtBoxBookName.Name = "txtBoxBookName";
            this.txtBoxBookName.Size = new System.Drawing.Size(496, 26);
            this.txtBoxBookName.TabIndex = 6;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearForm.Location = new System.Drawing.Point(881, 3);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(373, 24);
            this.btnClearForm.TabIndex = 83;
            this.btnClearForm.Text = "Formu Temizle";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveBook.Location = new System.Drawing.Point(881, 33);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(373, 24);
            this.btnSaveBook.TabIndex = 84;
            this.btnSaveBook.Text = "Kitap Oluştur";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateBook.Location = new System.Drawing.Point(881, 63);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(373, 24);
            this.btnUpdateBook.TabIndex = 85;
            this.btnUpdateBook.Text = "Kitabı Güncelle";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteBook.Location = new System.Drawing.Point(881, 93);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(373, 24);
            this.btnDeleteBook.TabIndex = 86;
            this.btnDeleteBook.Text = "Kitap Sil";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // lblBookPageCount
            // 
            this.lblBookPageCount.AutoSize = true;
            this.lblBookPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBookPageCount.Location = new System.Drawing.Point(3, 120);
            this.lblBookPageCount.Name = "lblBookPageCount";
            this.lblBookPageCount.Size = new System.Drawing.Size(121, 20);
            this.lblBookPageCount.TabIndex = 87;
            this.lblBookPageCount.Text = "Sayfa Numarası";
            // 
            // cboBookCategory
            // 
            this.cboBookCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboBookCategory.FormattingEnabled = true;
            this.cboBookCategory.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cboBookCategory.Location = new System.Drawing.Point(254, 93);
            this.cboBookCategory.Name = "cboBookCategory";
            this.cboBookCategory.Size = new System.Drawing.Size(496, 28);
            this.cboBookCategory.TabIndex = 88;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBookId.Location = new System.Drawing.Point(756, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(0, 20);
            this.lblBookId.TabIndex = 90;
            this.lblBookId.Visible = false;
            // 
            // nmrUpDownBookPageCount
            // 
            this.nmrUpDownBookPageCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmrUpDownBookPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nmrUpDownBookPageCount.Location = new System.Drawing.Point(254, 123);
            this.nmrUpDownBookPageCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrUpDownBookPageCount.Name = "nmrUpDownBookPageCount";
            this.nmrUpDownBookPageCount.Size = new System.Drawing.Size(496, 26);
            this.nmrUpDownBookPageCount.TabIndex = 91;
            this.nmrUpDownBookPageCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGetPersonAllForms
            // 
            this.btnGetPersonAllForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetPersonAllForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGetPersonAllForms.Location = new System.Drawing.Point(881, 123);
            this.btnGetPersonAllForms.Name = "btnGetPersonAllForms";
            this.btnGetPersonAllForms.Size = new System.Drawing.Size(373, 24);
            this.btnGetPersonAllForms.TabIndex = 92;
            this.btnGetPersonAllForms.Text = "Kişinin Bilgilerini Getir";
            this.btnGetPersonAllForms.UseVisualStyleBackColor = true;
            this.btnGetPersonAllForms.Click += new System.EventHandler(this.btnGetPersonAllForms_Click);
            // 
            // tblLayoutSearchFilterHeader
            // 
            this.tblLayoutSearchFilterHeader.ColumnCount = 2;
            this.tblLayoutSearchFilterHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayoutSearchFilterHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutSearchFilterHeader.Controls.Add(this.lblDisplayedFields, 1, 0);
            this.tblLayoutSearchFilterHeader.Controls.Add(this.panelSearchFilters, 0, 1);
            this.tblLayoutSearchFilterHeader.Controls.Add(this.tbLayoutSelectSearchOption, 0, 0);
            this.tblLayoutSearchFilterHeader.Controls.Add(this.tblLayoutDisplayOptions, 1, 1);
            this.tblLayoutSearchFilterHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutSearchFilterHeader.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutSearchFilterHeader.Name = "tblLayoutSearchFilterHeader";
            this.tblLayoutSearchFilterHeader.RowCount = 2;
            this.tblLayoutSearchFilterHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutSearchFilterHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayoutSearchFilterHeader.Size = new System.Drawing.Size(1257, 184);
            this.tblLayoutSearchFilterHeader.TabIndex = 96;
            // 
            // lblDisplayedFields
            // 
            this.lblDisplayedFields.AutoSize = true;
            this.lblDisplayedFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDisplayedFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDisplayedFields.Location = new System.Drawing.Point(1008, 0);
            this.lblDisplayedFields.Name = "lblDisplayedFields";
            this.lblDisplayedFields.Size = new System.Drawing.Size(246, 20);
            this.lblDisplayedFields.TabIndex = 89;
            this.lblDisplayedFields.Text = "Gösterilecek Alanlar";
            this.lblDisplayedFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSearchFilters
            // 
            this.panelSearchFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchFilters.Location = new System.Drawing.Point(3, 39);
            this.panelSearchFilters.Name = "panelSearchFilters";
            this.panelSearchFilters.Size = new System.Drawing.Size(999, 142);
            this.panelSearchFilters.TabIndex = 85;
            // 
            // tbLayoutSelectSearchOption
            // 
            this.tbLayoutSelectSearchOption.ColumnCount = 3;
            this.tbLayoutSelectSearchOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbLayoutSelectSearchOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tbLayoutSelectSearchOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbLayoutSelectSearchOption.Controls.Add(this.cboSelectSearchOption, 1, 0);
            this.tbLayoutSelectSearchOption.Controls.Add(this.lblSelectSearchOption, 0, 0);
            this.tbLayoutSelectSearchOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutSelectSearchOption.Location = new System.Drawing.Point(3, 3);
            this.tbLayoutSelectSearchOption.Name = "tbLayoutSelectSearchOption";
            this.tbLayoutSelectSearchOption.RowCount = 1;
            this.tbLayoutSelectSearchOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutSelectSearchOption.Size = new System.Drawing.Size(999, 30);
            this.tbLayoutSelectSearchOption.TabIndex = 88;
            // 
            // cboSelectSearchOption
            // 
            this.cboSelectSearchOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSelectSearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectSearchOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSelectSearchOption.FormattingEnabled = true;
            this.cboSelectSearchOption.Items.AddRange(new object[] {
            "İsme Göre",
            "Yazara Göre",
            "ISBN Numarasına Göre"});
            this.cboSelectSearchOption.Location = new System.Drawing.Point(252, 3);
            this.cboSelectSearchOption.Name = "cboSelectSearchOption";
            this.cboSelectSearchOption.Size = new System.Drawing.Size(343, 28);
            this.cboSelectSearchOption.TabIndex = 1;
            this.cboSelectSearchOption.SelectedIndexChanged += new System.EventHandler(this.cboSelectSearchOption_SelectedIndexChanged);
            // 
            // lblSelectSearchOption
            // 
            this.lblSelectSearchOption.AutoSize = true;
            this.lblSelectSearchOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectSearchOption.Location = new System.Drawing.Point(3, 0);
            this.lblSelectSearchOption.Name = "lblSelectSearchOption";
            this.lblSelectSearchOption.Size = new System.Drawing.Size(88, 20);
            this.lblSelectSearchOption.TabIndex = 0;
            this.lblSelectSearchOption.Text = "Arama türü";
            // 
            // tblLayoutDisplayOptions
            // 
            this.tblLayoutDisplayOptions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tblLayoutDisplayOptions.ColumnCount = 1;
            this.tblLayoutDisplayOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayoutDisplayOptions.Controls.Add(this.choName, 0, 1);
            this.tblLayoutDisplayOptions.Controls.Add(this.choWriterNameSurname, 0, 4);
            this.tblLayoutDisplayOptions.Controls.Add(this.choIsbnNo, 0, 3);
            this.tblLayoutDisplayOptions.Controls.Add(this.choCategoryName, 0, 5);
            this.tblLayoutDisplayOptions.Controls.Add(this.choPageCount, 0, 6);
            this.tblLayoutDisplayOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutDisplayOptions.Location = new System.Drawing.Point(1008, 39);
            this.tblLayoutDisplayOptions.Name = "tblLayoutDisplayOptions";
            this.tblLayoutDisplayOptions.RowCount = 7;
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayoutDisplayOptions.Size = new System.Drawing.Size(246, 142);
            this.tblLayoutDisplayOptions.TabIndex = 90;
            // 
            // choName
            // 
            this.choName.AutoSize = true;
            this.choName.Checked = true;
            this.choName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choName.Location = new System.Drawing.Point(3, 3);
            this.choName.Name = "choName";
            this.choName.Size = new System.Drawing.Size(51, 24);
            this.choName.TabIndex = 80;
            this.choName.Text = "Adı";
            this.choName.UseVisualStyleBackColor = true;
            // 
            // choWriterNameSurname
            // 
            this.choWriterNameSurname.AutoSize = true;
            this.choWriterNameSurname.Checked = true;
            this.choWriterNameSurname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choWriterNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choWriterNameSurname.Location = new System.Drawing.Point(3, 63);
            this.choWriterNameSurname.Name = "choWriterNameSurname";
            this.choWriterNameSurname.Size = new System.Drawing.Size(149, 24);
            this.choWriterNameSurname.TabIndex = 84;
            this.choWriterNameSurname.Text = "Yazar Adı Soyadı";
            this.choWriterNameSurname.UseVisualStyleBackColor = true;
            // 
            // choIsbnNo
            // 
            this.choIsbnNo.AutoSize = true;
            this.choIsbnNo.Checked = true;
            this.choIsbnNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choIsbnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choIsbnNo.Location = new System.Drawing.Point(3, 33);
            this.choIsbnNo.Name = "choIsbnNo";
            this.choIsbnNo.Size = new System.Drawing.Size(137, 24);
            this.choIsbnNo.TabIndex = 83;
            this.choIsbnNo.Text = "ISBN Numarası";
            this.choIsbnNo.UseVisualStyleBackColor = true;
            // 
            // choCategoryName
            // 
            this.choCategoryName.AutoSize = true;
            this.choCategoryName.Checked = true;
            this.choCategoryName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choCategoryName.Location = new System.Drawing.Point(3, 93);
            this.choCategoryName.Name = "choCategoryName";
            this.choCategoryName.Size = new System.Drawing.Size(87, 24);
            this.choCategoryName.TabIndex = 82;
            this.choCategoryName.Text = "Kategori";
            this.choCategoryName.UseVisualStyleBackColor = true;
            // 
            // choPageCount
            // 
            this.choPageCount.AutoSize = true;
            this.choPageCount.Checked = true;
            this.choPageCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choPageCount.Location = new System.Drawing.Point(3, 123);
            this.choPageCount.Name = "choPageCount";
            this.choPageCount.Size = new System.Drawing.Size(114, 24);
            this.choPageCount.TabIndex = 85;
            this.choPageCount.Text = "Sayfa Sayısı";
            this.choPageCount.UseVisualStyleBackColor = true;
            // 
            // tblLayoutPersonAndPenalty
            // 
            this.tblLayoutPersonAndPenalty.ColumnCount = 4;
            this.tblLayoutPersonAndPenalty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPersonAndPenalty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutPersonAndPenalty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutPersonAndPenalty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutPersonAndPenalty.Controls.Add(this.txtBoxSelectedPersonTurkishId, 1, 2);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.txtBoxSelectedPersonSurname, 1, 1);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.txtBoxSelectedPersonName, 1, 0);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.lblSelectedPersonName, 0, 0);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.lblSelectedPersonSurname, 0, 1);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.lblSelectedPersonTurkishId, 0, 2);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.lblPersonId, 2, 0);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.btnReturnBook, 3, 3);
            this.tblLayoutPersonAndPenalty.Controls.Add(this.btnBorrowBook, 3, 2);
            this.tblLayoutPersonAndPenalty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPersonAndPenalty.Location = new System.Drawing.Point(3, 611);
            this.tblLayoutPersonAndPenalty.Name = "tblLayoutPersonAndPenalty";
            this.tblLayoutPersonAndPenalty.RowCount = 4;
            this.tblLayoutPersonAndPenalty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tblLayoutPersonAndPenalty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tblLayoutPersonAndPenalty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tblLayoutPersonAndPenalty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tblLayoutPersonAndPenalty.Size = new System.Drawing.Size(1257, 146);
            this.tblLayoutPersonAndPenalty.TabIndex = 98;
            // 
            // txtBoxSelectedPersonTurkishId
            // 
            this.txtBoxSelectedPersonTurkishId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxSelectedPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxSelectedPersonTurkishId.Location = new System.Drawing.Point(254, 75);
            this.txtBoxSelectedPersonTurkishId.Name = "txtBoxSelectedPersonTurkishId";
            this.txtBoxSelectedPersonTurkishId.Size = new System.Drawing.Size(496, 26);
            this.txtBoxSelectedPersonTurkishId.TabIndex = 96;
            // 
            // txtBoxSelectedPersonSurname
            // 
            this.txtBoxSelectedPersonSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxSelectedPersonSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxSelectedPersonSurname.Location = new System.Drawing.Point(254, 39);
            this.txtBoxSelectedPersonSurname.Name = "txtBoxSelectedPersonSurname";
            this.txtBoxSelectedPersonSurname.Size = new System.Drawing.Size(496, 26);
            this.txtBoxSelectedPersonSurname.TabIndex = 92;
            // 
            // txtBoxSelectedPersonName
            // 
            this.txtBoxSelectedPersonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxSelectedPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxSelectedPersonName.Location = new System.Drawing.Point(254, 3);
            this.txtBoxSelectedPersonName.Name = "txtBoxSelectedPersonName";
            this.txtBoxSelectedPersonName.Size = new System.Drawing.Size(496, 26);
            this.txtBoxSelectedPersonName.TabIndex = 90;
            // 
            // lblSelectedPersonName
            // 
            this.lblSelectedPersonName.AutoSize = true;
            this.lblSelectedPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectedPersonName.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedPersonName.Name = "lblSelectedPersonName";
            this.lblSelectedPersonName.Size = new System.Drawing.Size(137, 20);
            this.lblSelectedPersonName.TabIndex = 88;
            this.lblSelectedPersonName.Text = "Seçilen Kişinin Adı";
            // 
            // lblSelectedPersonSurname
            // 
            this.lblSelectedPersonSurname.AutoSize = true;
            this.lblSelectedPersonSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectedPersonSurname.Location = new System.Drawing.Point(3, 36);
            this.lblSelectedPersonSurname.Name = "lblSelectedPersonSurname";
            this.lblSelectedPersonSurname.Size = new System.Drawing.Size(162, 20);
            this.lblSelectedPersonSurname.TabIndex = 89;
            this.lblSelectedPersonSurname.Text = "Seçilen Kişinin Soyadı";
            // 
            // lblSelectedPersonTurkishId
            // 
            this.lblSelectedPersonTurkishId.AutoSize = true;
            this.lblSelectedPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectedPersonTurkishId.Location = new System.Drawing.Point(3, 72);
            this.lblSelectedPersonTurkishId.Name = "lblSelectedPersonTurkishId";
            this.lblSelectedPersonTurkishId.Size = new System.Drawing.Size(182, 36);
            this.lblSelectedPersonTurkishId.TabIndex = 93;
            this.lblSelectedPersonTurkishId.Text = "Seçilen Kişinin TC Kimlik Numarası";
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonId.Location = new System.Drawing.Point(756, 0);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(0, 20);
            this.lblPersonId.TabIndex = 99;
            this.lblPersonId.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.choPersonPenaltyStatus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPersonPenaltyStatus, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 32);
            this.tableLayoutPanel1.TabIndex = 100;
            // 
            // choPersonPenaltyStatus
            // 
            this.choPersonPenaltyStatus.AutoSize = true;
            this.choPersonPenaltyStatus.Enabled = false;
            this.choPersonPenaltyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choPersonPenaltyStatus.Location = new System.Drawing.Point(101, 3);
            this.choPersonPenaltyStatus.Name = "choPersonPenaltyStatus";
            this.choPersonPenaltyStatus.Size = new System.Drawing.Size(15, 14);
            this.choPersonPenaltyStatus.TabIndex = 95;
            this.choPersonPenaltyStatus.UseVisualStyleBackColor = true;
            // 
            // lblPersonPenaltyStatus
            // 
            this.lblPersonPenaltyStatus.AutoSize = true;
            this.lblPersonPenaltyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonPenaltyStatus.Location = new System.Drawing.Point(3, 0);
            this.lblPersonPenaltyStatus.Name = "lblPersonPenaltyStatus";
            this.lblPersonPenaltyStatus.Size = new System.Drawing.Size(85, 20);
            this.lblPersonPenaltyStatus.TabIndex = 94;
            this.lblPersonPenaltyStatus.Text = "Cezalı Mı ?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.07258F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.92742F));
            this.tableLayoutPanel2.Controls.Add(this.dtPickerPersonPenaltyDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPersonPenaltyDate, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(254, 111);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(496, 32);
            this.tableLayoutPanel2.TabIndex = 101;
            // 
            // dtPickerPersonPenaltyDate
            // 
            this.dtPickerPersonPenaltyDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtPickerPersonPenaltyDate.Enabled = false;
            this.dtPickerPersonPenaltyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtPickerPersonPenaltyDate.Location = new System.Drawing.Point(171, 3);
            this.dtPickerPersonPenaltyDate.Name = "dtPickerPersonPenaltyDate";
            this.dtPickerPersonPenaltyDate.Size = new System.Drawing.Size(322, 26);
            this.dtPickerPersonPenaltyDate.TabIndex = 94;
            // 
            // lblPersonPenaltyDate
            // 
            this.lblPersonPenaltyDate.AutoSize = true;
            this.lblPersonPenaltyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonPenaltyDate.Location = new System.Drawing.Point(3, 0);
            this.lblPersonPenaltyDate.Name = "lblPersonPenaltyDate";
            this.lblPersonPenaltyDate.Size = new System.Drawing.Size(154, 20);
            this.lblPersonPenaltyDate.TabIndex = 93;
            this.lblPersonPenaltyDate.Text = "Cezasının Bitiş Tarihi";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReturnBook.Location = new System.Drawing.Point(881, 111);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(373, 32);
            this.btnReturnBook.TabIndex = 97;
            this.btnReturnBook.Text = "Kitabı İade Et";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrowBook.Location = new System.Drawing.Point(881, 75);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(373, 30);
            this.btnBorrowBook.TabIndex = 98;
            this.btnBorrowBook.Text = "Kitabı Al";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // BookQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 780);
            this.ControlBox = false;
            this.Controls.Add(this.tblLayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookQuery";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Yazar Sorgulama";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewBooks)).EndInit();
            this.tblLayoutMain.ResumeLayout(false);
            this.tblLayoutPersonForm.ResumeLayout(false);
            this.tblLayoutPersonForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDownBookPageCount)).EndInit();
            this.tblLayoutSearchFilterHeader.ResumeLayout(false);
            this.tblLayoutSearchFilterHeader.PerformLayout();
            this.tbLayoutSelectSearchOption.ResumeLayout(false);
            this.tbLayoutSelectSearchOption.PerformLayout();
            this.tblLayoutDisplayOptions.ResumeLayout(false);
            this.tblLayoutDisplayOptions.PerformLayout();
            this.tblLayoutPersonAndPenalty.ResumeLayout(false);
            this.tblLayoutPersonAndPenalty.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridViewBooks;
        private System.Windows.Forms.TableLayoutPanel tblLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tblLayoutSearchFilterHeader;
        private System.Windows.Forms.Label lblDisplayedFields;
        private System.Windows.Forms.Panel panelSearchFilters;
        private System.Windows.Forms.TableLayoutPanel tbLayoutSelectSearchOption;
        private System.Windows.Forms.ComboBox cboSelectSearchOption;
        private System.Windows.Forms.Label lblSelectSearchOption;
        private System.Windows.Forms.TableLayoutPanel tblLayoutDisplayOptions;
        private System.Windows.Forms.CheckBox choName;
        private System.Windows.Forms.CheckBox choWriterNameSurname;
        private System.Windows.Forms.CheckBox choIsbnNo;
        private System.Windows.Forms.CheckBox choCategoryName;
        private System.Windows.Forms.CheckBox choPageCount;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPersonForm;
        private System.Windows.Forms.ComboBox cboBookWriter;
        private System.Windows.Forms.TextBox txtBoxBookIsbnNo;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookIsbnNo;
        private System.Windows.Forms.Label lblBookWriter;
        private System.Windows.Forms.Label lblBookCategory;
        private System.Windows.Forms.TextBox txtBoxBookName;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label lblBookPageCount;
        private System.Windows.Forms.ComboBox cboBookCategory;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.NumericUpDown nmrUpDownBookPageCount;
        private System.Windows.Forms.Button btnGetPersonAllForms;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPersonAndPenalty;
        private System.Windows.Forms.Label lblSelectedPersonName;
        private System.Windows.Forms.TextBox txtBoxSelectedPersonSurname;
        private System.Windows.Forms.TextBox txtBoxSelectedPersonName;
        private System.Windows.Forms.Label lblSelectedPersonSurname;
        private System.Windows.Forms.TextBox txtBoxSelectedPersonTurkishId;
        private System.Windows.Forms.Label lblSelectedPersonTurkishId;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPersonPenaltyDate;
        private System.Windows.Forms.Label lblPersonPenaltyStatus;
        private System.Windows.Forms.CheckBox choPersonPenaltyStatus;
        private System.Windows.Forms.DateTimePicker dtPickerPersonPenaltyDate;
    }
}