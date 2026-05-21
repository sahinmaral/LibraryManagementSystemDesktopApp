namespace LibraryManagementSystem.UI.PersonQuery
{
    partial class SearchPersonByTakenBook
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPersonTakenBook = new System.Windows.Forms.Label();
            this.txtBoxPersonTakenBook = new System.Windows.Forms.TextBox();
            this.tblLayoutSearchPersonByNameSurname.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutSearchPersonByNameSurname
            // 
            this.tblLayoutSearchPersonByNameSurname.ColumnCount = 3;
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.lblPersonTakenBook, 0, 0);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.txtBoxPersonTakenBook, 1, 0);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.btnSearch, 1, 3);
            this.tblLayoutSearchPersonByNameSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutSearchPersonByNameSurname.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutSearchPersonByNameSurname.Name = "tblLayoutSearchPersonByNameSurname";
            this.tblLayoutSearchPersonByNameSurname.RowCount = 4;
            this.tblLayoutSearchPersonByNameSurname.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.Size = new System.Drawing.Size(541, 125);
            this.tblLayoutSearchPersonByNameSurname.TabIndex = 84;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Location = new System.Drawing.Point(138, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 26);
            this.btnSearch.TabIndex = 71;
            this.btnSearch.Text = "Tarat";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPersonTakenBook
            // 
            this.lblPersonTakenBook.AutoSize = true;
            this.lblPersonTakenBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersonTakenBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonTakenBook.Location = new System.Drawing.Point(3, 0);
            this.lblPersonTakenBook.Name = "lblPersonTakenBook";
            this.lblPersonTakenBook.Size = new System.Drawing.Size(129, 31);
            this.lblPersonTakenBook.TabIndex = 68;
            this.lblPersonTakenBook.Text = "Kitap Adı : ";
            this.lblPersonTakenBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxPersonTakenBook
            // 
            this.txtBoxPersonTakenBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPersonTakenBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPersonTakenBook.Location = new System.Drawing.Point(138, 3);
            this.txtBoxPersonTakenBook.Name = "txtBoxPersonTakenBook";
            this.txtBoxPersonTakenBook.Size = new System.Drawing.Size(183, 26);
            this.txtBoxPersonTakenBook.TabIndex = 64;
            // 
            // SearchPersonByTakenBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutSearchPersonByNameSurname);
            this.Name = "SearchPersonByTakenBook";
            this.Size = new System.Drawing.Size(541, 125);
            this.tblLayoutSearchPersonByNameSurname.ResumeLayout(false);
            this.tblLayoutSearchPersonByNameSurname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutSearchPersonByNameSurname;
        private System.Windows.Forms.Label lblPersonTakenBook;
        private System.Windows.Forms.TextBox txtBoxPersonTakenBook;
        private System.Windows.Forms.Button btnSearch;
    }
}
