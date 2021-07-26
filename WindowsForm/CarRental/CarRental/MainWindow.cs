using System;
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
        private readonly Login loginObj;
        public User _user;


        public MainWindow(User user, Login objFromLoginForm = null)
        {
            _user = user;
            loginObj = objFromLoginForm;
            InitializeComponent();
        }

        private void AddRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isOpen = Utilities.IsFormOpen("AddEditRentalInfo");


            if (!isOpen)
            {
                var addRentalInfo = new AddEditRentalInfo();
                addRentalInfo.MdiParent = this;
                addRentalInfo.Show();

            }

        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isOpen = Utilities.IsFormOpen("ManageCars");


            if (!isOpen)
            {
                var manageCar = new ManageCars();
                manageCar.MdiParent = this;
                manageCar.Show();
            }
            
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isOpen = Utilities.IsFormOpen("ManageRentalRecords");


            if (!isOpen)
            {
                var viewArchive = new ManageRentalRecords();
                viewArchive.MdiParent = this;
                viewArchive.Show();
            }
            

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
           loginObj.Visible=true;
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var isOpen = Utilities.IsFormOpen("ManageUsers");

            if (!isOpen)
            {
                var manageUser = new ManageUsers()
                {
                    MdiParent = this
                };
                manageUser.Show();
            }


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var userRole = _user.UserRoles.FirstOrDefault().Role.shortName.ToString();
            if (userRole != "admin")
            {
               
                manageUsersToolStripMenuItem.Visible = false;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginObj.Visible = true;
            this.Close();
        }
    }
}
