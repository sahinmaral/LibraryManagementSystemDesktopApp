namespace LibraryManagementSystem.UI.PersonQuery
{
    partial class SearchBookByIsbnNo
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
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookIsbnNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxBookIsbnNo = new System.Windows.Forms.TextBox();
            this.searchTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 3;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.searchTableLayoutPanel.Controls.Add(this.txtBoxBookIsbnNo, 1, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lblBookIsbnNo, 0, 0);
            this.searchTableLayoutPanel.Controls.Add(this.btnSearch, 1, 3);
            this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 4;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(541, 125);
            this.searchTableLayoutPanel.TabIndex = 107;
            // 
            // lblBookIsbnNo
            // 
            this.lblBookIsbnNo.AutoSize = true;
            this.lblBookIsbnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookIsbnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIsbnNo.Location = new System.Drawing.Point(3, 0);
            this.lblBookIsbnNo.Name = "lblBookIsbnNo";
            this.lblBookIsbnNo.Size = new System.Drawing.Size(129, 31);
            this.lblBookIsbnNo.TabIndex = 22;
            this.lblBookIsbnNo.Text = "ISBN Numarası :";
            this.lblBookIsbnNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Location = new System.Drawing.Point(138, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 26);
            this.btnSearch.TabIndex = 94;
            this.btnSearch.Text = "Tarat";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxBookIsbnNo
            // 
            this.txtBoxBookIsbnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxBookIsbnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxBookIsbnNo.Location = new System.Drawing.Point(138, 3);
            this.txtBoxBookIsbnNo.Name = "txtBoxBookIsbnNo";
            this.txtBoxBookIsbnNo.Size = new System.Drawing.Size(183, 26);
            this.txtBoxBookIsbnNo.TabIndex = 95;
            // 
            // SearchBookByIsbnNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchTableLayoutPanel);
            this.Name = "SearchBookByIsbnNo";
            this.Size = new System.Drawing.Size(541, 125);
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Label lblBookIsbnNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxBookIsbnNo;
    }
}
