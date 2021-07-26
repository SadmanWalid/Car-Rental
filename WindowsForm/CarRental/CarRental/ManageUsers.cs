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

    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities carRentalEntitiesObj = new CarRentalEntities();
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            RefreshGrid();

        }

        public void RefreshGrid()
        {
            var users = carRentalEntitiesObj.Users.
                Select(x => new
                {
                    userName = x.userName,
                    userRole = x.UserRoles.FirstOrDefault().Role.name,
                    userId = x.id,
                    isActive = x.isActive == true ? "Active" : "Deactvie",
                    password = x.password
                }).ToList();

            gvManageUsers.DataSource = users;
            gvManageUsers.Columns["userName"].HeaderText = "Name";
            gvManageUsers.Columns["userRole"].HeaderText = "Role";
            gvManageUsers.Columns["userID"].Visible = false;
            gvManageUsers.Columns["isActive"].HeaderText = "Active/Deactive";
            gvManageUsers.Columns["password"].Visible = false;

        }

        private void BtDeactivateActivateUser_Click(object sender, EventArgs e)
        {
            var rowIndex = gvManageUsers.SelectedCells[0].RowIndex;
            var userID = (int)gvManageUsers.Rows[rowIndex].Cells["userID"].Value;

            var user = carRentalEntitiesObj.Users.FirstOrDefault(x => x.id == userID);

            var isActive = user.isActive;

            if (isActive == true)
                user.isActive = false;
            else
                user.isActive = true;

            carRentalEntitiesObj.SaveChanges();

            string message=isActive==true?"Deactivated":"Activted";
            RefreshGrid();
            MessageBox.Show($"{user.userName}'s Account has been {message}");

      

        }

        private void btResetPassword_Click(object sender, EventArgs e)
        {
            var rowIndex = gvManageUsers.SelectedCells[0].RowIndex;
            var userID = (int)gvManageUsers.Rows[rowIndex].Cells["userID"].Value;

            var user = carRentalEntitiesObj.Users.FirstOrDefault(x => x.id == userID);

            var genericPassword = "password";

            var hashedGenericPassword = Utilities.HashedPassword(genericPassword);

            user.password = hashedGenericPassword;
            carRentalEntitiesObj.SaveChanges();

            MessageBox.Show($"{user.userName}'s password has been changed succesfully");

        }

        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            if(!Utilities.IsFormOpen("Adduser"))
            {
                var addUser = new AddUser(this)
                {
                    MdiParent = this.MdiParent
                };

                addUser.Show();


            }
        }

        private void btDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure, You want to delete the user?",
                "Delete",MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if(dr==DialogResult.Yes)
            {
                var rowIndex = gvManageUsers.SelectedCells[0].RowIndex;
                var userID = (int)gvManageUsers.Rows[rowIndex].Cells["userID"].Value;

                var user = carRentalEntitiesObj.Users.FirstOrDefault(x => x.id == userID);

                var userRole = carRentalEntitiesObj.UserRoles.FirstOrDefault(x => x.userID == userID);

                carRentalEntitiesObj.Users.Remove(user);
                carRentalEntitiesObj.UserRoles.Remove(userRole);
                carRentalEntitiesObj.SaveChanges();
                RefreshGrid();
                MessageBox.Show("User Deleted Successfully");
            }
           





        }
    }
}
