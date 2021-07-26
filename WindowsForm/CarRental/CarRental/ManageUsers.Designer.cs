
namespace CarRental
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btClose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.BtDeactivateActivateUser = new System.Windows.Forms.Button();
            this.btResetPassword = new System.Windows.Forms.Button();
            this.btAddNewUser = new System.Windows.Forms.Button();
            this.gvManageUsers = new System.Windows.Forms.DataGridView();
            this.btDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvManageUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(811, 483);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(130, 68);
            this.btClose.TabIndex = 28;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("AR JULIAN", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(367, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(351, 58);
            this.lbTitle.TabIndex = 27;
            this.lbTitle.Text = "Manage Users";
            // 
            // BtDeactivateActivateUser
            // 
            this.BtDeactivateActivateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtDeactivateActivateUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtDeactivateActivateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDeactivateActivateUser.Location = new System.Drawing.Point(459, 483);
            this.BtDeactivateActivateUser.Name = "BtDeactivateActivateUser";
            this.BtDeactivateActivateUser.Size = new System.Drawing.Size(130, 68);
            this.BtDeactivateActivateUser.TabIndex = 26;
            this.BtDeactivateActivateUser.Text = "Deactivate/Activate User";
            this.BtDeactivateActivateUser.UseVisualStyleBackColor = false;
            this.BtDeactivateActivateUser.Click += new System.EventHandler(this.BtDeactivateActivateUser_Click);
            // 
            // btResetPassword
            // 
            this.btResetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btResetPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetPassword.Location = new System.Drawing.Point(293, 481);
            this.btResetPassword.Name = "btResetPassword";
            this.btResetPassword.Size = new System.Drawing.Size(130, 69);
            this.btResetPassword.TabIndex = 25;
            this.btResetPassword.Text = "Reset Password";
            this.btResetPassword.UseVisualStyleBackColor = false;
            this.btResetPassword.Click += new System.EventHandler(this.btResetPassword_Click);
            // 
            // btAddNewUser
            // 
            this.btAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAddNewUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewUser.Location = new System.Drawing.Point(132, 482);
            this.btAddNewUser.Name = "btAddNewUser";
            this.btAddNewUser.Size = new System.Drawing.Size(121, 69);
            this.btAddNewUser.TabIndex = 24;
            this.btAddNewUser.Text = "Add New User";
            this.btAddNewUser.UseVisualStyleBackColor = false;
            this.btAddNewUser.Click += new System.EventHandler(this.btAddNewUser_Click);
            // 
            // gvManageUsers
            // 
            this.gvManageUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvManageUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvManageUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvManageUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvManageUsers.Location = new System.Drawing.Point(158, 113);
            this.gvManageUsers.Name = "gvManageUsers";
            this.gvManageUsers.RowHeadersVisible = false;
            this.gvManageUsers.RowHeadersWidth = 62;
            this.gvManageUsers.RowTemplate.Height = 28;
            this.gvManageUsers.Size = new System.Drawing.Size(783, 311);
            this.gvManageUsers.TabIndex = 23;
            // 
            // btDeleteUser
            // 
            this.btDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDeleteUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteUser.Location = new System.Drawing.Point(646, 483);
            this.btDeleteUser.Name = "btDeleteUser";
            this.btDeleteUser.Size = new System.Drawing.Size(130, 68);
            this.btDeleteUser.TabIndex = 29;
            this.btDeleteUser.Text = "Delete User";
            this.btDeleteUser.UseVisualStyleBackColor = false;
            this.btDeleteUser.Click += new System.EventHandler(this.btDeleteUser_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 603);
            this.Controls.Add(this.btDeleteUser);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.BtDeactivateActivateUser);
            this.Controls.Add(this.btResetPassword);
            this.Controls.Add(this.btAddNewUser);
            this.Controls.Add(this.gvManageUsers);
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvManageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button BtDeactivateActivateUser;
        private System.Windows.Forms.Button btResetPassword;
        private System.Windows.Forms.Button btAddNewUser;
        private System.Windows.Forms.DataGridView gvManageUsers;
        private System.Windows.Forms.Button btDeleteUser;
    }
}