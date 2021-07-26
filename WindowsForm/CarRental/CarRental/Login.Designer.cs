
namespace CarRental
{
    partial class Login
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.cbRememberPassword = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbUserName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(160, 84);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(119, 74);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(239, 26);
            this.tbPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(8, 77);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(78, 20);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(3, 19);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(89, 20);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "User Name";
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUserName.Location = new System.Drawing.Point(119, 16);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(239, 26);
            this.tbUserName.TabIndex = 1;
            // 
            // btClose
            // 
            this.btClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(350, 277);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(137, 38);
            this.btClose.TabIndex = 14;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(204, 277);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(121, 38);
            this.btLogin.TabIndex = 15;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // cbRememberPassword
            // 
            this.cbRememberPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRememberPassword.AutoSize = true;
            this.cbRememberPassword.Location = new System.Drawing.Point(245, 217);
            this.cbRememberPassword.Name = "cbRememberPassword";
            this.cbRememberPassword.Size = new System.Drawing.Size(196, 24);
            this.cbRememberPassword.TabIndex = 16;
            this.cbRememberPassword.Text = "Remember Password?";
            this.cbRememberPassword.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 367);
            this.Controls.Add(this.cbRememberPassword);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental System";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.CheckBox cbRememberPassword;
    }
}