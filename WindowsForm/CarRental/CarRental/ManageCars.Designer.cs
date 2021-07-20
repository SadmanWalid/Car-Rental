
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
            this.gvManageCars = new System.Windows.Forms.DataGridView();
            this.btAddNewCar = new System.Windows.Forms.Button();
            this.btEditCar = new System.Windows.Forms.Button();
            this.btDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvManageCars)).BeginInit();
            this.SuspendLayout();
            // 
            // gvManageCars
            // 
            this.gvManageCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvManageCars.Location = new System.Drawing.Point(21, 43);
            this.gvManageCars.Name = "gvManageCars";
            this.gvManageCars.RowHeadersWidth = 62;
            this.gvManageCars.RowTemplate.Height = 28;
            this.gvManageCars.Size = new System.Drawing.Size(397, 363);
            this.gvManageCars.TabIndex = 0;
            // 
            // btAddNewCar
            // 
            this.btAddNewCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewCar.Location = new System.Drawing.Point(528, 72);
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
            this.btEditCar.Location = new System.Drawing.Point(528, 194);
            this.btEditCar.Name = "btEditCar";
            this.btEditCar.Size = new System.Drawing.Size(130, 57);
            this.btEditCar.TabIndex = 13;
            this.btEditCar.Text = "Edit Car";
            this.btEditCar.UseVisualStyleBackColor = false;
            // 
            // btDeleteCar
            // 
            this.btDeleteCar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteCar.Location = new System.Drawing.Point(528, 309);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
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