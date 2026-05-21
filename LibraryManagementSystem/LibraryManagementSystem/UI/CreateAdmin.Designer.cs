namespace LibraryManagementSystem.UI
{
    partial class CreateAdmin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.txtBoxAdminUsername = new System.Windows.Forms.TextBox();
            this.txtBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAdminPasswordRepeat = new System.Windows.Forms.TextBox();
            this.btnSaveAdmin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnSaveAdmin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxAdminPasswordRepeat, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxAdminUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxAdminPassword, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 209);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdminUsername.Location = new System.Drawing.Point(3, 0);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(93, 20);
            this.lblAdminUsername.TabIndex = 1;
            this.lblAdminUsername.Text = "Kullanıcı Adı";
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdminPassword.Location = new System.Drawing.Point(3, 52);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(42, 20);
            this.lblAdminPassword.TabIndex = 2;
            this.lblAdminPassword.Text = "Şifre";
            // 
            // txtBoxAdminUsername
            // 
            this.txtBoxAdminUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxAdminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxAdminUsername.Location = new System.Drawing.Point(102, 3);
            this.txtBoxAdminUsername.Name = "txtBoxAdminUsername";
            this.txtBoxAdminUsername.Size = new System.Drawing.Size(343, 26);
            this.txtBoxAdminUsername.TabIndex = 7;
            // 
            // txtBoxAdminPassword
            // 
            this.txtBoxAdminPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdminPassword.Location = new System.Drawing.Point(102, 55);
            this.txtBoxAdminPassword.Name = "txtBoxAdminPassword";
            this.txtBoxAdminPassword.Size = new System.Drawing.Size(343, 26);
            this.txtBoxAdminPassword.TabIndex = 8;
            this.txtBoxAdminPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifre Tekrar";
            // 
            // txtBoxAdminPasswordRepeat
            // 
            this.txtBoxAdminPasswordRepeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxAdminPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdminPasswordRepeat.Location = new System.Drawing.Point(102, 107);
            this.txtBoxAdminPasswordRepeat.Name = "txtBoxAdminPasswordRepeat";
            this.txtBoxAdminPasswordRepeat.Size = new System.Drawing.Size(343, 26);
            this.txtBoxAdminPasswordRepeat.TabIndex = 10;
            this.txtBoxAdminPasswordRepeat.UseSystemPasswordChar = true;
            // 
            // btnSaveAdmin
            // 
            this.btnSaveAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSaveAdmin.Location = new System.Drawing.Point(102, 159);
            this.btnSaveAdmin.Name = "btnSaveAdmin";
            this.btnSaveAdmin.Size = new System.Drawing.Size(343, 47);
            this.btnSaveAdmin.TabIndex = 94;
            this.btnSaveAdmin.Text = "Admin Oluştur";
            this.btnSaveAdmin.UseVisualStyleBackColor = true;
            this.btnSaveAdmin.Click += new System.EventHandler(this.btnSaveAdmin_Click);
            // 
            // CreateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(487, 237);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAdmin";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "CreateAdmin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.TextBox txtBoxAdminUsername;
        private System.Windows.Forms.TextBox txtBoxAdminPassword;
        private System.Windows.Forms.TextBox txtBoxAdminPasswordRepeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAdmin;
    }
}