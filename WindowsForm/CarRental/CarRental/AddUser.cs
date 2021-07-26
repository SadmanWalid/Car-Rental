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
    
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities carRentalEntitiesObj = new CarRentalEntities();
        private readonly ManageUsers _manageUser;
        public AddUser(ManageUsers user)
        {
            _manageUser = user;
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            var userName = tbUserName.Text.Trim();
            var roleID = (int)cbUserRole.SelectedValue;

            var isValid = true;
            

            try
            {

                if (string.IsNullOrEmpty(userName))
                    isValid = false;


                if (isValid)
                {
                    var user = new User()
                    {
                        userName = userName,
                        isActive = true,
                        password = Utilities.HashGenericPassword(),


                    };

                    carRentalEntitiesObj.Users.Add(user);
                    carRentalEntitiesObj.SaveChanges();


                    var userID = user.id;

                    var role = new UserRole()
                    {
                        userID = userID,
                        roleID = roleID,

                    };

                    carRentalEntitiesObj.UserRoles.Add(role);
                    carRentalEntitiesObj.SaveChanges();

                    MessageBox.Show("User Added Successfully");

                    Close();
                }
                else
                    MessageBox.Show("Enter Valid User Name");




            }
            catch ( Exception  )
            {

                MessageBox.Show("There is some Errors!!!");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = carRentalEntitiesObj.Roles.ToList();
            cbUserRole.DataSource = roles;
            cbUserRole.ValueMember = "id";
            cbUserRole.DisplayMember = "name";

        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            _manageUser.RefreshGrid();
        }

     
    }
}
