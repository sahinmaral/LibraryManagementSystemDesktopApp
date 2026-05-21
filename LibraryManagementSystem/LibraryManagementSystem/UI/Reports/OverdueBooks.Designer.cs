namespace LibraryManagementSystem.UI.Reports
{
    partial class OverdueBooks
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
            this.tblLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tblLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutMain
            // 
            this.tblLayoutMain.ColumnCount = 1;
            this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutMain.Controls.Add(this.dtGridView, 0, 2);
            this.tblLayoutMain.Controls.Add(this.lblHeader, 0, 0);
            this.tblLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutMain.Name = "tblLayoutMain";
            this.tblLayoutMain.Padding = new System.Windows.Forms.Padding(10);
            this.tblLayoutMain.RowCount = 3;
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLayoutMain.Size = new System.Drawing.Size(800, 450);
            this.tblLayoutMain.TabIndex = 0;
            // 
            // dtGridView
            // 
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridView.Location = new System.Drawing.Point(13, 185);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(774, 252);
            this.dtGridView.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHeader.Location = new System.Drawing.Point(13, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(774, 129);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "İadesi Geçmiş Kitaplar";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // OverdueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblLayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverdueBooks";
            this.Text = "BorrowedBooks";
            this.tblLayoutMain.ResumeLayout(false);
            this.tblLayoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutMain;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Label lblHeader;
    }
}