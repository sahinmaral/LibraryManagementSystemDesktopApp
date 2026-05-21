namespace LibraryManagementSystem.UI.PersonQuery
{
    partial class SearchPersonByNameSurname
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblLayoutSearchPersonByNameSurname = new System.Windows.Forms.TableLayoutPanel();
            this.cboPersonGender = new System.Windows.Forms.ComboBox();
            this.lblPersonGender = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblPersonSurname = new System.Windows.Forms.Label();
            this.txtBoxPersonSurname = new System.Windows.Forms.TextBox();
            this.txtBoxPersonName = new System.Windows.Forms.TextBox();
            this.tblLayoutSearchPersonByNameSurname.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutSearchPersonByNameSurname
            // 
            this.tblLayoutSearchPersonByNameSurname.ColumnCount = 3;
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.cboPersonGender, 1, 2);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.lblPersonGender, 0, 2);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.btnSearch, 1, 3);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.lblPersonName, 0, 0);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.lblPersonSurname, 0, 1);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.txtBoxPersonSurname, 1, 1);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.txtBoxPersonName, 1, 0);
            this.tblLayoutSearchPersonByNameSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutSearchPersonByNameSurname.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutSearchPersonByNameSurname.Name = "tblLayoutSearchPersonByNameSurname";
            this.tblLayoutSearchPersonByNameSurname.RowCount = 4;
            this.tblLayoutSearchPersonByNameSurname.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.Size = new System.Drawing.Size(541, 160);
            this.tblLayoutSearchPersonByNameSurname.TabIndex = 84;
            // 
            // cboPersonGender
            // 
            this.cboPersonGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPersonGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboPersonGender.FormattingEnabled = true;
            this.cboPersonGender.Items.AddRange(new object[] {
            "(Bütün)",
            "Kadın",
            "Erkek"});
            this.cboPersonGender.Location = new System.Drawing.Point(138, 83);
            this.cboPersonGender.Name = "cboPersonGender";
            this.cboPersonGender.Size = new System.Drawing.Size(183, 28);
            this.cboPersonGender.TabIndex = 78;
            // 
            // lblPersonGender
            // 
            this.lblPersonGender.AutoSize = true;
            this.lblPersonGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersonGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonGender.Location = new System.Drawing.Point(3, 80);
            this.lblPersonGender.Name = "lblPersonGender";
            this.lblPersonGender.Size = new System.Drawing.Size(129, 40);
            this.lblPersonGender.TabIndex = 77;
            this.lblPersonGender.Text = "Kişinin cinsiyeti :";
            this.lblPersonGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Location = new System.Drawing.Point(138, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 34);
            this.btnSearch.TabIndex = 76;
            this.btnSearch.Text = "Tarat";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonName.Location = new System.Drawing.Point(3, 0);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(129, 40);
            this.lblPersonName.TabIndex = 68;
            this.lblPersonName.Text = "Kişinin adı :";
            this.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPersonSurname
            // 
            this.lblPersonSurname.AutoSize = true;
            this.lblPersonSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersonSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonSurname.Location = new System.Drawing.Point(3, 40);
            this.lblPersonSurname.Name = "lblPersonSurname";
            this.lblPersonSurname.Size = new System.Drawing.Size(129, 40);
            this.lblPersonSurname.TabIndex = 69;
            this.lblPersonSurname.Text = "Kişinin soyadı :";
            this.lblPersonSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxPersonSurname
            // 
            this.txtBoxPersonSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPersonSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPersonSurname.Location = new System.Drawing.Point(138, 43);
            this.txtBoxPersonSurname.Name = "txtBoxPersonSurname";
            this.txtBoxPersonSurname.Size = new System.Drawing.Size(183, 26);
            this.txtBoxPersonSurname.TabIndex = 65;
            // 
            // txtBoxPersonName
            // 
            this.txtBoxPersonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPersonName.Location = new System.Drawing.Point(138, 3);
            this.txtBoxPersonName.Name = "txtBoxPersonName";
            this.txtBoxPersonName.Size = new System.Drawing.Size(183, 26);
            this.txtBoxPersonName.TabIndex = 64;
            // 
            // SearchPersonByNameSurname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutSearchPersonByNameSurname);
            this.Name = "SearchPersonByNameSurname";
            this.Size = new System.Drawing.Size(541, 160);
            this.tblLayoutSearchPersonByNameSurname.ResumeLayout(false);
            this.tblLayoutSearchPersonByNameSurname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutSearchPersonByNameSurname;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblPersonSurname;
        private System.Windows.Forms.TextBox txtBoxPersonSurname;
        private System.Windows.Forms.TextBox txtBoxPersonName;
        private System.Windows.Forms.Label lblPersonGender;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboPersonGender;
    }
}
