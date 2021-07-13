
namespace CarRental
{
    partial class Form1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbRentDate = new System.Windows.Forms.Label();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.lbTypeOfCar = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.dateRent = new System.Windows.Forms.DateTimePicker();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("AR JULIAN", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(158, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(477, 58);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Car Rental System";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.Location = new System.Drawing.Point(49, 117);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(179, 28);
            this.lbCustomerName.TabIndex = 1;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(460, 117);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(91, 28);
            this.lbCost.TabIndex = 2;
            this.lbCost.Text = "Cost($)";
            // 
            // lbRentDate
            // 
            this.lbRentDate.AutoSize = true;
            this.lbRentDate.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRentDate.Location = new System.Drawing.Point(49, 206);
            this.lbRentDate.Name = "lbRentDate";
            this.lbRentDate.Size = new System.Drawing.Size(192, 28);
            this.lbRentDate.TabIndex = 3;
            this.lbRentDate.Text = "Date of Renting";
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnDate.Location = new System.Drawing.Point(460, 206);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(191, 28);
            this.lbReturnDate.TabIndex = 4;
            this.lbReturnDate.Text = "Date Of Return";
            // 
            // lbTypeOfCar
            // 
            this.lbTypeOfCar.AutoSize = true;
            this.lbTypeOfCar.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeOfCar.Location = new System.Drawing.Point(49, 304);
            this.lbTypeOfCar.Name = "lbTypeOfCar";
            this.lbTypeOfCar.Size = new System.Drawing.Size(152, 28);
            this.lbTypeOfCar.TabIndex = 5;
            this.lbTypeOfCar.Text = "Type Of Car";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.BackColor = System.Drawing.SystemColors.Window;
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(42, 148);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(330, 28);
            this.tbCustomerName.TabIndex = 6;
            // 
            // tbCost
            // 
            this.tbCost.BackColor = System.Drawing.SystemColors.Window;
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(453, 148);
            this.tbCost.Name = "tbCost";
            this.tbCost.ReadOnly = true;
            this.tbCost.Size = new System.Drawing.Size(335, 28);
            this.tbCost.TabIndex = 7;
            // 
            // dateRent
            // 
            this.dateRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRent.Location = new System.Drawing.Point(42, 246);
            this.dateRent.MinDate = new System.DateTime(2021, 7, 11, 0, 0, 0, 0);
            this.dateRent.Name = "dateRent";
            this.dateRent.Size = new System.Drawing.Size(330, 28);
            this.dateRent.TabIndex = 8;
            // 
            // dateReturn
            // 
            this.dateReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturn.Location = new System.Drawing.Point(453, 246);
            this.dateReturn.MinDate = new System.DateTime(2021, 7, 11, 0, 0, 0, 0);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(335, 28);
            this.dateReturn.TabIndex = 9;
            this.dateReturn.Value = new System.DateTime(2021, 7, 12, 0, 0, 0, 0);
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(42, 354);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(330, 30);
            this.cbTypeOfCar.Sorted = true;
            this.cbTypeOfCar.TabIndex = 10;
            // 
            // btSubmit
            // 
            this.btSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(507, 324);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(199, 81);
            this.btSubmit.TabIndex = 11;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = false;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.dateRent);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lbTypeOfCar);
            this.Controls.Add(this.lbReturnDate);
            this.Controls.Add(this.lbRentDate);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbRentDate;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.Label lbTypeOfCar;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.DateTimePicker dateRent;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Button btSubmit;
    }
}

