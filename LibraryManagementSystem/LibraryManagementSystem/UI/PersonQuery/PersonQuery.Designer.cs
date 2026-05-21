namespace LibraryManagementSystem.UI.PersonQuery
{
    partial class PersonQuery
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
            this.dtGridViewPerson = new System.Windows.Forms.DataGridView();
            this.panelSearchFilters = new System.Windows.Forms.Panel();
            this.tblLayoutSearchFilterHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisplayedFields = new System.Windows.Forms.Label();
            this.tbLayoutSelectSearchOption = new System.Windows.Forms.TableLayoutPanel();
            this.cboSelectSearchOption = new System.Windows.Forms.ComboBox();
            this.lblSelectSearchOption = new System.Windows.Forms.Label();
            this.tblLayoutDisplayOptions = new System.Windows.Forms.TableLayoutPanel();
            this.choName = new System.Windows.Forms.CheckBox();
            this.choGender = new System.Windows.Forms.CheckBox();
            this.choSurname = new System.Windows.Forms.CheckBox();
            this.choTurkishId = new System.Windows.Forms.CheckBox();
            this.tblLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutPersonForm = new System.Windows.Forms.TableLayoutPanel();
            this.cboPersonGender = new System.Windows.Forms.ComboBox();
            this.txtBoxPersonTurkishId = new System.Windows.Forms.TextBox();
            this.txtBoxPersonSurname = new System.Windows.Forms.TextBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblPersonSurname = new System.Windows.Forms.Label();
            this.lblPersonGender = new System.Windows.Forms.Label();
            this.lblPersonTurkıshId = new System.Windows.Forms.Label();
            this.txtBoxPersonName = new System.Windows.Forms.TextBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnSavePerson = new System.Windows.Forms.Button();
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnSavePersonAllForms = new System.Windows.Forms.Button();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.tblLayoutUserPenalty = new System.Windows.Forms.TableLayoutPanel();
            this.lblPersonPenaltyStatus = new System.Windows.Forms.Label();
            this.lblPersonPenaltyDate = new System.Windows.Forms.Label();
            this.choPersonPenaltyStatus = new System.Windows.Forms.CheckBox();
            this.dtPickerPersonPenaltyDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPerson)).BeginInit();
            this.tblLayoutSearchFilterHeader.SuspendLayout();
            this.tbLayoutSelectSearchOption.SuspendLayout();
            this.tblLayoutDisplayOptions.SuspendLayout();
            this.tblLayoutMain.SuspendLayout();
            this.tblLayoutPersonForm.SuspendLayout();
            this.tblLayoutUserPenalty.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewPerson
            // 
            this.dtGridViewPerson.AllowUserToAddRows = false;
            this.dtGridViewPerson.AllowUserToDeleteRows = false;
            this.dtGridViewPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewPerson.Location = new System.Drawing.Point(3, 222);
            this.dtGridViewPerson.MultiSelect = false;
            this.dtGridViewPerson.Name = "dtGridViewPerson";
            this.dtGridViewPerson.ReadOnly = true;
            this.dtGridViewPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewPerson.Size = new System.Drawing.Size(1085, 249);
            this.dtGridViewPerson.TabIndex = 71;
            this.dtGridViewPerson.SelectionChanged += new System.EventHandler(this.dtGridViewPerson_SelectionChanged);
            // 
            // panelSearchFilters
            // 
            this.panelSearchFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchFilters.Location = new System.Drawing.Point(3, 45);
            this.panelSearchFilters.Name = "panelSearchFilters";
            this.panelSearchFilters.Size = new System.Drawing.Size(862, 165);
            this.panelSearchFilters.TabIndex = 85;
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
            this.tblLayoutSearchFilterHeader.Size = new System.Drawing.Size(1085, 213);
            this.tblLayoutSearchFilterHeader.TabIndex = 87;
            // 
            // lblDisplayedFields
            // 
            this.lblDisplayedFields.AutoSize = true;
            this.lblDisplayedFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDisplayedFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDisplayedFields.Location = new System.Drawing.Point(871, 0);
            this.lblDisplayedFields.Name = "lblDisplayedFields";
            this.lblDisplayedFields.Size = new System.Drawing.Size(211, 20);
            this.lblDisplayedFields.TabIndex = 89;
            this.lblDisplayedFields.Text = "Gösterilecek Alanlar";
            this.lblDisplayedFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tbLayoutSelectSearchOption.Size = new System.Drawing.Size(862, 36);
            this.tbLayoutSelectSearchOption.TabIndex = 88;
            // 
            // cboSelectSearchOption
            // 
            this.cboSelectSearchOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSelectSearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectSearchOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSelectSearchOption.FormattingEnabled = true;
            this.cboSelectSearchOption.Items.AddRange(new object[] {
            "Ad ve Soyada Göre",
            "TC Kimlik Numarasına Göre",
            "Aldığı Kitap Adına Göre"});
            this.cboSelectSearchOption.Location = new System.Drawing.Point(218, 3);
            this.cboSelectSearchOption.Name = "cboSelectSearchOption";
            this.cboSelectSearchOption.Size = new System.Drawing.Size(295, 28);
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
            this.tblLayoutDisplayOptions.Controls.Add(this.choGender, 0, 4);
            this.tblLayoutDisplayOptions.Controls.Add(this.choSurname, 0, 3);
            this.tblLayoutDisplayOptions.Controls.Add(this.choTurkishId, 0, 5);
            this.tblLayoutDisplayOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutDisplayOptions.Location = new System.Drawing.Point(871, 45);
            this.tblLayoutDisplayOptions.Name = "tblLayoutDisplayOptions";
            this.tblLayoutDisplayOptions.RowCount = 6;
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutDisplayOptions.Size = new System.Drawing.Size(211, 165);
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
            // choGender
            // 
            this.choGender.AutoSize = true;
            this.choGender.Checked = true;
            this.choGender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choGender.Location = new System.Drawing.Point(3, 63);
            this.choGender.Name = "choGender";
            this.choGender.Size = new System.Drawing.Size(83, 24);
            this.choGender.TabIndex = 84;
            this.choGender.Text = "Cinsiyet";
            this.choGender.UseVisualStyleBackColor = true;
            // 
            // choSurname
            // 
            this.choSurname.AutoSize = true;
            this.choSurname.Checked = true;
            this.choSurname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choSurname.Location = new System.Drawing.Point(3, 33);
            this.choSurname.Name = "choSurname";
            this.choSurname.Size = new System.Drawing.Size(76, 24);
            this.choSurname.TabIndex = 83;
            this.choSurname.Text = "Soyadı";
            this.choSurname.UseVisualStyleBackColor = true;
            // 
            // choTurkishId
            // 
            this.choTurkishId.AutoSize = true;
            this.choTurkishId.Checked = true;
            this.choTurkishId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.choTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choTurkishId.Location = new System.Drawing.Point(3, 93);
            this.choTurkishId.Name = "choTurkishId";
            this.choTurkishId.Size = new System.Drawing.Size(163, 24);
            this.choTurkishId.TabIndex = 82;
            this.choTurkishId.Text = "TC Kimlik Numarası";
            this.choTurkishId.UseVisualStyleBackColor = true;
            // 
            // tblLayoutMain
            // 
            this.tblLayoutMain.ColumnCount = 1;
            this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayoutMain.Controls.Add(this.dtGridViewPerson, 0, 1);
            this.tblLayoutMain.Controls.Add(this.tblLayoutSearchFilterHeader, 0, 0);
            this.tblLayoutMain.Controls.Add(this.tblLayoutPersonForm, 0, 2);
            this.tblLayoutMain.Controls.Add(this.tblLayoutUserPenalty, 0, 3);
            this.tblLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutMain.Location = new System.Drawing.Point(10, 10);
            this.tblLayoutMain.Name = "tblLayoutMain";
            this.tblLayoutMain.RowCount = 4;
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutMain.Size = new System.Drawing.Size(1091, 730);
            this.tblLayoutMain.TabIndex = 88;
            // 
            // tblLayoutPersonForm
            // 
            this.tblLayoutPersonForm.ColumnCount = 4;
            this.tblLayoutPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPersonForm.Controls.Add(this.cboPersonGender, 1, 2);
            this.tblLayoutPersonForm.Controls.Add(this.txtBoxPersonTurkishId, 1, 3);
            this.tblLayoutPersonForm.Controls.Add(this.txtBoxPersonSurname, 1, 1);
            this.tblLayoutPersonForm.Controls.Add(this.lblPersonName, 0, 0);
            this.tblLayoutPersonForm.Controls.Add(this.lblPersonSurname, 0, 1);
            this.tblLayoutPersonForm.Controls.Add(this.lblPersonGender, 0, 2);
            this.tblLayoutPersonForm.Controls.Add(this.lblPersonTurkıshId, 0, 3);
            this.tblLayoutPersonForm.Controls.Add(this.txtBoxPersonName, 1, 0);
            this.tblLayoutPersonForm.Controls.Add(this.btnClearForm, 3, 0);
            this.tblLayoutPersonForm.Controls.Add(this.btnSavePerson, 3, 1);
            this.tblLayoutPersonForm.Controls.Add(this.btnUpdatePerson, 3, 2);
            this.tblLayoutPersonForm.Controls.Add(this.btnDeletePerson, 3, 3);
            this.tblLayoutPersonForm.Controls.Add(this.btnSavePersonAllForms, 3, 4);
            this.tblLayoutPersonForm.Controls.Add(this.lblPersonId, 0, 4);
            this.tblLayoutPersonForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPersonForm.Location = new System.Drawing.Point(3, 477);
            this.tblLayoutPersonForm.Name = "tblLayoutPersonForm";
            this.tblLayoutPersonForm.RowCount = 5;
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLayoutPersonForm.Size = new System.Drawing.Size(1085, 176);
            this.tblLayoutPersonForm.TabIndex = 88;
            // 
            // cboPersonGender
            // 
            this.cboPersonGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPersonGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboPersonGender.FormattingEnabled = true;
            this.cboPersonGender.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cboPersonGender.Location = new System.Drawing.Point(220, 73);
            this.cboPersonGender.Name = "cboPersonGender";
            this.cboPersonGender.Size = new System.Drawing.Size(319, 28);
            this.cboPersonGender.TabIndex = 81;
            // 
            // txtBoxPersonTurkishId
            // 
            this.txtBoxPersonTurkishId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxPersonTurkishId.Location = new System.Drawing.Point(220, 108);
            this.txtBoxPersonTurkishId.Name = "txtBoxPersonTurkishId";
            this.txtBoxPersonTurkishId.Size = new System.Drawing.Size(319, 26);
            this.txtBoxPersonTurkishId.TabIndex = 12;
            // 
            // txtBoxPersonSurname
            // 
            this.txtBoxPersonSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPersonSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxPersonSurname.Location = new System.Drawing.Point(220, 38);
            this.txtBoxPersonSurname.Name = "txtBoxPersonSurname";
            this.txtBoxPersonSurname.Size = new System.Drawing.Size(319, 26);
            this.txtBoxPersonSurname.TabIndex = 8;
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonName.Location = new System.Drawing.Point(3, 0);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(32, 20);
            this.lblPersonName.TabIndex = 1;
            this.lblPersonName.Text = "Adı";
            // 
            // lblPersonSurname
            // 
            this.lblPersonSurname.AutoSize = true;
            this.lblPersonSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonSurname.Location = new System.Drawing.Point(3, 35);
            this.lblPersonSurname.Name = "lblPersonSurname";
            this.lblPersonSurname.Size = new System.Drawing.Size(57, 20);
            this.lblPersonSurname.TabIndex = 2;
            this.lblPersonSurname.Text = "Soyadı";
            // 
            // lblPersonGender
            // 
            this.lblPersonGender.AutoSize = true;
            this.lblPersonGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonGender.Location = new System.Drawing.Point(3, 70);
            this.lblPersonGender.Name = "lblPersonGender";
            this.lblPersonGender.Size = new System.Drawing.Size(67, 20);
            this.lblPersonGender.TabIndex = 3;
            this.lblPersonGender.Text = "Cinsiyeti";
            // 
            // lblPersonTurkıshId
            // 
            this.lblPersonTurkıshId.AutoSize = true;
            this.lblPersonTurkıshId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonTurkıshId.Location = new System.Drawing.Point(3, 105);
            this.lblPersonTurkıshId.Name = "lblPersonTurkıshId";
            this.lblPersonTurkıshId.Size = new System.Drawing.Size(144, 20);
            this.lblPersonTurkıshId.TabIndex = 4;
            this.lblPersonTurkıshId.Text = "TC Kimlik Numarası";
            // 
            // txtBoxPersonName
            // 
            this.txtBoxPersonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxPersonName.Location = new System.Drawing.Point(220, 3);
            this.txtBoxPersonName.Name = "txtBoxPersonName";
            this.txtBoxPersonName.Size = new System.Drawing.Size(319, 26);
            this.txtBoxPersonName.TabIndex = 6;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearForm.Location = new System.Drawing.Point(762, 3);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(320, 29);
            this.btnClearForm.TabIndex = 83;
            this.btnClearForm.Text = "Formu Temizle";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnSavePerson
            // 
            this.btnSavePerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSavePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSavePerson.Location = new System.Drawing.Point(762, 38);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(320, 29);
            this.btnSavePerson.TabIndex = 84;
            this.btnSavePerson.Text = "Kişi Oluştur";
            this.btnSavePerson.UseVisualStyleBackColor = true;
            this.btnSavePerson.Click += new System.EventHandler(this.btnSavePerson_Click);
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdatePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdatePerson.Location = new System.Drawing.Point(762, 73);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(320, 29);
            this.btnUpdatePerson.TabIndex = 85;
            this.btnUpdatePerson.Text = "Kişiyi Güncelle";
            this.btnUpdatePerson.UseVisualStyleBackColor = true;
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeletePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeletePerson.Location = new System.Drawing.Point(762, 108);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(320, 29);
            this.btnDeletePerson.TabIndex = 86;
            this.btnDeletePerson.Text = "Kişiyi Sil";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnSavePersonAllForms
            // 
            this.btnSavePersonAllForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSavePersonAllForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSavePersonAllForms.Location = new System.Drawing.Point(762, 143);
            this.btnSavePersonAllForms.Name = "btnSavePersonAllForms";
            this.btnSavePersonAllForms.Size = new System.Drawing.Size(320, 30);
            this.btnSavePersonAllForms.TabIndex = 87;
            this.btnSavePersonAllForms.Text = "Kişinin Bilgilerini Kaydet";
            this.btnSavePersonAllForms.UseVisualStyleBackColor = true;
            this.btnSavePersonAllForms.Click += new System.EventHandler(this.btnSavePersonAllForms_Click);
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Location = new System.Drawing.Point(3, 140);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(0, 13);
            this.lblPersonId.TabIndex = 82;
            this.lblPersonId.Visible = false;
            // 
            // tblLayoutUserPenalty
            // 
            this.tblLayoutUserPenalty.ColumnCount = 3;
            this.tblLayoutUserPenalty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutUserPenalty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutUserPenalty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutUserPenalty.Controls.Add(this.lblPersonPenaltyStatus, 0, 0);
            this.tblLayoutUserPenalty.Controls.Add(this.lblPersonPenaltyDate, 0, 1);
            this.tblLayoutUserPenalty.Controls.Add(this.choPersonPenaltyStatus, 1, 0);
            this.tblLayoutUserPenalty.Controls.Add(this.dtPickerPersonPenaltyDate, 1, 1);
            this.tblLayoutUserPenalty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutUserPenalty.Location = new System.Drawing.Point(3, 659);
            this.tblLayoutUserPenalty.Name = "tblLayoutUserPenalty";
            this.tblLayoutUserPenalty.RowCount = 2;
            this.tblLayoutUserPenalty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutUserPenalty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutUserPenalty.Size = new System.Drawing.Size(1085, 68);
            this.tblLayoutUserPenalty.TabIndex = 89;
            // 
            // lblPersonPenaltyStatus
            // 
            this.lblPersonPenaltyStatus.AutoSize = true;
            this.lblPersonPenaltyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonPenaltyStatus.Location = new System.Drawing.Point(3, 0);
            this.lblPersonPenaltyStatus.Name = "lblPersonPenaltyStatus";
            this.lblPersonPenaltyStatus.Size = new System.Drawing.Size(85, 20);
            this.lblPersonPenaltyStatus.TabIndex = 5;
            this.lblPersonPenaltyStatus.Text = "Cezalı Mı ?";
            // 
            // lblPersonPenaltyDate
            // 
            this.lblPersonPenaltyDate.AutoSize = true;
            this.lblPersonPenaltyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersonPenaltyDate.Location = new System.Drawing.Point(3, 34);
            this.lblPersonPenaltyDate.Name = "lblPersonPenaltyDate";
            this.lblPersonPenaltyDate.Size = new System.Drawing.Size(154, 20);
            this.lblPersonPenaltyDate.TabIndex = 6;
            this.lblPersonPenaltyDate.Text = "Cezasının Bitiş Tarihi";
            // 
            // choPersonPenaltyStatus
            // 
            this.choPersonPenaltyStatus.AutoSize = true;
            this.choPersonPenaltyStatus.Enabled = false;
            this.choPersonPenaltyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choPersonPenaltyStatus.Location = new System.Drawing.Point(220, 3);
            this.choPersonPenaltyStatus.Name = "choPersonPenaltyStatus";
            this.choPersonPenaltyStatus.Size = new System.Drawing.Size(15, 14);
            this.choPersonPenaltyStatus.TabIndex = 7;
            this.choPersonPenaltyStatus.UseVisualStyleBackColor = true;
            // 
            // dtPickerPersonPenaltyDate
            // 
            this.dtPickerPersonPenaltyDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPickerPersonPenaltyDate.Enabled = false;
            this.dtPickerPersonPenaltyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtPickerPersonPenaltyDate.Location = new System.Drawing.Point(220, 37);
            this.dtPickerPersonPenaltyDate.Name = "dtPickerPersonPenaltyDate";
            this.dtPickerPersonPenaltyDate.Size = new System.Drawing.Size(319, 26);
            this.dtPickerPersonPenaltyDate.TabIndex = 8;
            // 
            // PersonQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1111, 750);
            this.ControlBox = false;
            this.Controls.Add(this.tblLayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonQuery";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Kişi Sorgulama - Ad/Soyad";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPerson)).EndInit();
            this.tblLayoutSearchFilterHeader.ResumeLayout(false);
            this.tblLayoutSearchFilterHeader.PerformLayout();
            this.tbLayoutSelectSearchOption.ResumeLayout(false);
            this.tbLayoutSelectSearchOption.PerformLayout();
            this.tblLayoutDisplayOptions.ResumeLayout(false);
            this.tblLayoutDisplayOptions.PerformLayout();
            this.tblLayoutMain.ResumeLayout(false);
            this.tblLayoutPersonForm.ResumeLayout(false);
            this.tblLayoutPersonForm.PerformLayout();
            this.tblLayoutUserPenalty.ResumeLayout(false);
            this.tblLayoutUserPenalty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridViewPerson;
        private System.Windows.Forms.Panel panelSearchFilters;
        private System.Windows.Forms.TableLayoutPanel tblLayoutSearchFilterHeader;
        private System.Windows.Forms.Label lblDisplayedFields;
        private System.Windows.Forms.TableLayoutPanel tbLayoutSelectSearchOption;
        private System.Windows.Forms.Label lblSelectSearchOption;
        private System.Windows.Forms.ComboBox cboSelectSearchOption;
        private System.Windows.Forms.TableLayoutPanel tblLayoutDisplayOptions;
        private System.Windows.Forms.CheckBox choName;
        private System.Windows.Forms.CheckBox choGender;
        private System.Windows.Forms.CheckBox choSurname;
        private System.Windows.Forms.CheckBox choTurkishId;
        private System.Windows.Forms.TableLayoutPanel tblLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPersonForm;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblPersonSurname;
        private System.Windows.Forms.Label lblPersonGender;
        private System.Windows.Forms.Label lblPersonTurkıshId;
        private System.Windows.Forms.TextBox txtBoxPersonName;
        private System.Windows.Forms.TextBox txtBoxPersonTurkishId;
        private System.Windows.Forms.TextBox txtBoxPersonSurname;
        private System.Windows.Forms.ComboBox cboPersonGender;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnSavePerson;
        private System.Windows.Forms.Button btnUpdatePerson;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnSavePersonAllForms;
        private System.Windows.Forms.TableLayoutPanel tblLayoutUserPenalty;
        private System.Windows.Forms.Label lblPersonPenaltyStatus;
        private System.Windows.Forms.Label lblPersonPenaltyDate;
        private System.Windows.Forms.CheckBox choPersonPenaltyStatus;
        private System.Windows.Forms.DateTimePicker dtPickerPersonPenaltyDate;
    }
}