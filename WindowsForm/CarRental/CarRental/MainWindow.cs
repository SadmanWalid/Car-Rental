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
        public string _role;


        public MainWindow(string role, Login objFromLoginForm = null)
        {
            _role = role;
            loginObj = objFromLoginForm;
            InitializeComponent();
        }

        private void AddRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>().ToList();

            var Isopen = openForms.Any<Form>(x => x.Name == "AddEditRentalInfo");


            if (!Isopen)
            {
                var addRentalInfo = new AddEditRentalInfo();
                addRentalInfo.MdiParent = this;
                addRentalInfo.Show();

            }

        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>().ToList();

            var Isopen = openForms.Any<Form>(x => x.Name == "ManageCars");


            if (!Isopen)
            {
                var manageCar = new ManageCars();
                manageCar.MdiParent = this;
                manageCar.Show();
            }
            
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>().ToList();

            var Isopen = openForms.Any<Form>(x => x.Name == "ManageRentalRecords");


            if (!Isopen)
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
            var openForms = Application.OpenForms.Cast<Form>().ToList();

            var isOpen = openForms.Any(x => x.Name == "ManageUser");

            if(!isOpen)
            {
                var manageUser = new ManageUser()
                {
                    MdiParent = this
                };
                manageUser.Show();
            }


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_role!="admin")
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
