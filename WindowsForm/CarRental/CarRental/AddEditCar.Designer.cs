
namespace CarRental
{
    partial class AddEditCar
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
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbLicenseNumber = new System.Windows.Forms.TextBox();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbVIN = new System.Windows.Forms.Label();
            this.lbLincenseNumber = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSaveChanges = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbYear, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbLicenseNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbVIN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbBrand, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbModel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbVIN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbLincenseNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbYear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbBrand, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(751, 249);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(378, 199);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(370, 26);
            this.tbYear.TabIndex = 9;
            // 
            // tbLicenseNumber
            // 
            this.tbLicenseNumber.Location = new System.Drawing.Point(378, 150);
            this.tbLicenseNumber.Name = "tbLicenseNumber";
            this.tbLicenseNumber.Size = new System.Drawing.Size(370, 26);
            this.tbLicenseNumber.TabIndex = 8;
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(378, 101);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(370, 26);
            this.tbVIN.TabIndex = 7;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(378, 52);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(370, 26);
            this.tbModel.TabIndex = 6;
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(3, 0);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(52, 20);
            this.lbBrand.TabIndex = 0;
            this.lbBrand.Text = "Brand";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(3, 49);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(52, 20);
            this.lbModel.TabIndex = 1;
            this.lbModel.Text = "Model";
            // 
            // lbVIN
            // 
            this.lbVIN.AutoSize = true;
            this.lbVIN.Location = new System.Drawing.Point(3, 98);
            this.lbVIN.Name = "lbVIN";
            this.lbVIN.Size = new System.Drawing.Size(177, 20);
            this.lbVIN.TabIndex = 2;
            this.lbVIN.Text = "Vehicle Identity Number";
            // 
            // lbLincenseNumber
            // 
            this.lbLincenseNumber.AutoSize = true;
            this.lbLincenseNumber.Location = new System.Drawing.Point(3, 147);
            this.lbLincenseNumber.Name = "lbLincenseNumber";
            this.lbLincenseNumber.Size = new System.Drawing.Size(124, 20);
            this.lbLincenseNumber.TabIndex = 4;
            this.lbLincenseNumber.Text = "License Number";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(3, 196);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(43, 20);
            this.lbYear.TabIndex = 3;
            this.lbYear.Text = "Year";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(378, 3);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(370, 26);
            this.tbBrand.TabIndex = 5;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(535, 350);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 69);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSaveChanges
            // 
            this.btSaveChanges.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveChanges.Location = new System.Drawing.Point(116, 350);
            this.btSaveChanges.Name = "btSaveChanges";
            this.btSaveChanges.Size = new System.Drawing.Size(121, 69);
            this.btSaveChanges.TabIndex = 14;
            this.btSaveChanges.Text = "Save Changes";
            this.btSaveChanges.UseVisualStyleBackColor = false;
            this.btSaveChanges.Click += new System.EventHandler(this.btSaveChanges_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("AR JULIAN", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(223, -2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(368, 58);
            this.lbTitle.TabIndex = 15;
            this.lbTitle.Text = "Add Edit Cars";
            // 
            // AddEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btSaveChanges);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditCar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEditCar_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSaveChanges;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbLicenseNumber;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbVIN;
        private System.Windows.Forms.Label lbLincenseNumber;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox tbBrand;
    }
}