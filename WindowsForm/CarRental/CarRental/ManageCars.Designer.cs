
namespace CarRental
{
    partial class ManageCars
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
            this.gvManageCars = new System.Windows.Forms.DataGridView();
            this.btAddNewCar = new System.Windows.Forms.Button();
            this.btEditCar = new System.Windows.Forms.Button();
            this.btDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvManageCars)).BeginInit();
            this.SuspendLayout();
            // 
            // gvManageCars
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvManageCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvManageCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvManageCars.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvManageCars.Location = new System.Drawing.Point(21, 43);
            this.gvManageCars.Name = "gvManageCars";
            this.gvManageCars.RowHeadersVisible = false;
            this.gvManageCars.RowHeadersWidth = 62;
            this.gvManageCars.RowTemplate.Height = 28;
            this.gvManageCars.Size = new System.Drawing.Size(752, 363);
            this.gvManageCars.TabIndex = 0;
            // 
            // btAddNewCar
            // 
            this.btAddNewCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewCar.Location = new System.Drawing.Point(109, 425);
            this.btAddNewCar.Name = "btAddNewCar";
            this.btAddNewCar.Size = new System.Drawing.Size(121, 69);
            this.btAddNewCar.TabIndex = 12;
            this.btAddNewCar.Text = "Add New Car";
            this.btAddNewCar.UseVisualStyleBackColor = false;
            // 
            // btEditCar
            // 
            this.btEditCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditCar.Location = new System.Drawing.Point(337, 427);
            this.btEditCar.Name = "btEditCar";
            this.btEditCar.Size = new System.Drawing.Size(130, 64);
            this.btEditCar.TabIndex = 13;
            this.btEditCar.Text = "Edit Car";
            this.btEditCar.UseVisualStyleBackColor = false;
            // 
            // btDeleteCar
            // 
            this.btDeleteCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteCar.Location = new System.Drawing.Point(570, 432);
            this.btDeleteCar.Name = "btDeleteCar";
            this.btDeleteCar.Size = new System.Drawing.Size(130, 62);
            this.btDeleteCar.TabIndex = 14;
            this.btDeleteCar.Text = "Delete Car";
            this.btDeleteCar.UseVisualStyleBackColor = false;
            // 
            // ManageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btDeleteCar);
            this.Controls.Add(this.btEditCar);
            this.Controls.Add(this.btAddNewCar);
            this.Controls.Add(this.gvManageCars);
            this.Name = "ManageCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Cars";
            this.Load += new System.EventHandler(this.ManageCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvManageCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvManageCars;
        private System.Windows.Forms.Button btAddNewCar;
        private System.Windows.Forms.Button btEditCar;
        private System.Windows.Forms.Button btDeleteCar;
    }
}