﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainWindow : Form
    {
        private int open;
        public MainWindow()
        {
            open = 0;
            InitializeComponent();
        }

        private void AddRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
          
                var addRentalInfo = new AddRentalInfo();
                addRentalInfo.MdiParent = this;
                addRentalInfo.Show();
                
         

            
            
          
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageCar = new ManageCars();
            manageCar.MdiParent = this;
            manageCar.Show();
        }
    }
}
