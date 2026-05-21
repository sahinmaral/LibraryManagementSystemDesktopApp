namespace LibraryManagementSystem.UI.PersonQuery
{
    partial class SearchPersonByTurkishId
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
            this.lblPersonTurkishId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxPersonTurkishId = new System.Windows.Forms.TextBox();
            this.tblLayoutSearchPersonByNameSurname.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutSearchPersonByNameSurname
            // 
            this.tblLayoutSearchPersonByNameSurname.ColumnCount = 3;
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.lblPersonTurkishId, 0, 0);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.txtBoxPersonTurkishId, 1, 0);
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
            // lblPersonTurkishId
            // 
            this.lblPersonTurkishId.AutoSize = true;
            this.lblPersonTurkishId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonTurkishId.Location = new System.Drawing.Point(3, 0);
            this.lblPersonTurkishId.Name = "lblPersonTurkishId";
            this.lblPersonTurkishId.Size = new System.Drawing.Size(129, 31);
            this.lblPersonTurkishId.TabIndex = 68;
            this.lblPersonTurkishId.Text = "Kişinin TC kimlik numarası :";
            this.lblPersonTurkishId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Location = new System.Drawing.Point(138, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 26);
            this.btnSearch.TabIndex = 67;
            this.btnSearch.Text = "Tarat";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxPersonTurkishId
            // 
            this.txtBoxPersonTurkishId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPersonTurkishId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPersonTurkishId.Location = new System.Drawing.Point(138, 3);
            this.txtBoxPersonTurkishId.Name = "txtBoxPersonTurkishId";
            this.txtBoxPersonTurkishId.Size = new System.Drawing.Size(183, 26);
            this.txtBoxPersonTurkishId.TabIndex = 64;
            // 
            // SearchPersonByTurkishId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutSearchPersonByNameSurname);
            this.Name = "SearchPersonByTurkishId";
            this.Size = new System.Drawing.Size(541, 125);
            this.tblLayoutSearchPersonByNameSurname.ResumeLayout(false);
            this.tblLayoutSearchPersonByNameSurname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutSearchPersonByNameSurname;
        private System.Windows.Forms.Label lblPersonTurkishId;
        private System.Windows.Forms.TextBox txtBoxPersonTurkishId;
        private System.Windows.Forms.Button btnSearch;
    }
}
