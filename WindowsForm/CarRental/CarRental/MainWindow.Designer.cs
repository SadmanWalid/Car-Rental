
namespace CarRental
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVehicleListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVehivleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehicleListingToolStripMenuItem,
            this.maneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1410, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVehicleListingToolStripMenuItem
            // 
            this.manageVehicleListingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.removeVehicleToolStripMenuItem,
            this.editVehivleToolStripMenuItem,
            this.viewListingToolStripMenuItem});
            this.manageVehicleListingToolStripMenuItem.Name = "manageVehicleListingToolStripMenuItem";
            this.manageVehicleListingToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.manageVehicleListingToolStripMenuItem.Text = "Manage Vehicle Listing";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            // 
            // removeVehicleToolStripMenuItem
            // 
            this.removeVehicleToolStripMenuItem.Name = "removeVehicleToolStripMenuItem";
            this.removeVehicleToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.removeVehicleToolStripMenuItem.Text = "Remove Vehicle";
            // 
            // editVehivleToolStripMenuItem
            // 
            this.editVehivleToolStripMenuItem.Name = "editVehivleToolStripMenuItem";
            this.editVehivleToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.editVehivleToolStripMenuItem.Text = "Edit Vehivle";
            // 
            // viewListingToolStripMenuItem
            // 
            this.viewListingToolStripMenuItem.Name = "viewListingToolStripMenuItem";
            this.viewListingToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.viewListingToolStripMenuItem.Text = "View Listing";
            // 
            // maneToolStripMenuItem
            // 
            this.maneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRentalRecordToolStripMenuItem,
            this.viewArchiveToolStripMenuItem,
            this.editRentalRecordToolStripMenuItem});
            this.maneToolStripMenuItem.Name = "maneToolStripMenuItem";
            this.maneToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.maneToolStripMenuItem.Text = "Manage Rental Records";
            // 
            // AddRentalRecordToolStripMenuItem
            // 
            this.AddRentalRecordToolStripMenuItem.Name = "AddRentalRecordToolStripMenuItem";
            this.AddRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.AddRentalRecordToolStripMenuItem.Text = "Add Rental Record";
            this.AddRentalRecordToolStripMenuItem.Click += new System.EventHandler(this.AddRentalRecordToolStripMenuItem_Click);
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.viewArchiveToolStripMenuItem.Text = "View Archive";
            // 
            // editRentalRecordToolStripMenuItem
            // 
            this.editRentalRecordToolStripMenuItem.Name = "editRentalRecordToolStripMenuItem";
            this.editRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.editRentalRecordToolStripMenuItem.Text = "Edit Rental Record";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVehicleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVehivleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalRecordToolStripMenuItem;
    }
}