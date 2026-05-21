namespace LibraryManagementSystem.UI.PersonQuery
{
    partial class SearchBookByName
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
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBoxBookName = new System.Windows.Forms.TextBox();
            this.tblLayoutSearchPersonByNameSurname.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutSearchPersonByNameSurname
            // 
            this.tblLayoutSearchPersonByNameSurname.ColumnCount = 3;
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayoutSearchPersonByNameSurname.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.btnSearch, 1, 3);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.lblBookName, 0, 0);
            this.tblLayoutSearchPersonByNameSurname.Controls.Add(this.txtBoxBookName, 1, 0);
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
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.Location = new System.Drawing.Point(3, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(40, 20);
            this.lblBookName.TabIndex = 68;
            this.lblBookName.Text = "Adı :";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxBookName
            // 
            this.txtBoxBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxBookName.Location = new System.Drawing.Point(138, 3);
            this.txtBoxBookName.Name = "txtBoxBookName";
            this.txtBoxBookName.Size = new System.Drawing.Size(183, 26);
            this.txtBoxBookName.TabIndex = 64;
            // 
            // SearchBookByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutSearchPersonByNameSurname);
            this.Name = "SearchBookByName";
            this.Size = new System.Drawing.Size(541, 160);
            this.tblLayoutSearchPersonByNameSurname.ResumeLayout(false);
            this.tblLayoutSearchPersonByNameSurname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutSearchPersonByNameSurname;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBoxBookName;
        private System.Windows.Forms.Button btnSearch;
    }
}
