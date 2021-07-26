
namespace CarRental
{
    partial class ManageRentalRecords
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.BtDeleteRecord = new System.Windows.Forms.Button();
            this.btEditRecord = new System.Windows.Forms.Button();
            this.btAddNewRecord = new System.Windows.Forms.Button();
            this.gvManageRentalRecords = new System.Windows.Forms.DataGridView();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvManageRentalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("AR JULIAN", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(217, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(411, 58);
            this.lbTitle.TabIndex = 20;
            this.lbTitle.Text = "Manage Records";
            // 
            // BtDeleteRecord
            // 
            this.BtDeleteRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtDeleteRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDeleteRecord.Location = new System.Drawing.Point(439, 427);
            this.BtDeleteRecord.Name = "BtDeleteRecord";
            this.BtDeleteRecord.Size = new System.Drawing.Size(130, 68);
            this.BtDeleteRecord.TabIndex = 19;
            this.BtDeleteRecord.Text = "Delete Record";
            this.BtDeleteRecord.UseVisualStyleBackColor = false;
            this.BtDeleteRecord.Click += new System.EventHandler(this.BtDeleteRecord_Click);
            // 
            // btEditRecord
            // 
            this.btEditRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEditRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditRecord.Location = new System.Drawing.Point(258, 427);
            this.btEditRecord.Name = "btEditRecord";
            this.btEditRecord.Size = new System.Drawing.Size(130, 69);
            this.btEditRecord.TabIndex = 18;
            this.btEditRecord.Text = "Edit Record";
            this.btEditRecord.UseVisualStyleBackColor = false;
            this.btEditRecord.Click += new System.EventHandler(this.btEditRecord_Click);
            // 
            // btAddNewRecord
            // 
            this.btAddNewRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAddNewRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddNewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewRecord.Location = new System.Drawing.Point(72, 426);
            this.btAddNewRecord.Name = "btAddNewRecord";
            this.btAddNewRecord.Size = new System.Drawing.Size(121, 69);
            this.btAddNewRecord.TabIndex = 17;
            this.btAddNewRecord.Text = "Add New Record";
            this.btAddNewRecord.UseVisualStyleBackColor = false;
            this.btAddNewRecord.Click += new System.EventHandler(this.btAddNewRecord_Click);
            // 
            // gvManageRentalRecords
            // 
            this.gvManageRentalRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvManageRentalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvManageRentalRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvManageRentalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvManageRentalRecords.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvManageRentalRecords.Location = new System.Drawing.Point(50, 85);
            this.gvManageRentalRecords.Name = "gvManageRentalRecords";
            this.gvManageRentalRecords.RowHeadersVisible = false;
            this.gvManageRentalRecords.RowHeadersWidth = 62;
            this.gvManageRentalRecords.RowTemplate.Height = 28;
            this.gvManageRentalRecords.Size = new System.Drawing.Size(752, 327);
            this.gvManageRentalRecords.TabIndex = 16;
            // 
            // btClose
            // 
            this.btClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(628, 426);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(130, 68);
            this.btClose.TabIndex = 21;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 514);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.BtDeleteRecord);
            this.Controls.Add(this.btEditRecord);
            this.Controls.Add(this.btAddNewRecord);
            this.Controls.Add(this.gvManageRentalRecords);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageRentalRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Rental Records";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvManageRentalRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button BtDeleteRecord;
        private System.Windows.Forms.Button btEditRecord;
        private System.Windows.Forms.Button btAddNewRecord;
        private System.Windows.Forms.DataGridView gvManageRentalRecords;
        private System.Windows.Forms.Button btClose;
    }
}