using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities carRentalEntitiesObj = new CarRentalEntities(); 
        public Login()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            
            var userName = tbUserName.Text.Trim();
            var password = tbPassword.Text;


            var hashedPassword = Utilities.HashedPassword(password);


            var user = carRentalEntitiesObj.Users.FirstOrDefault(x => x.userName == userName && x.password == hashedPassword );

            if (user != null)
            {
                var isActive = user.isActive;
                if(isActive==true)
                {
                    if (!cbRememberPassword.Checked)
                    {
                        tbUserName.Text = string.Empty;
                        tbPassword.Text = string.Empty;
                    }


                    this.Hide();

                    var mainWindow = new MainWindow(user, this);
                    mainWindow.Show();
                }
                else
                  MessageBox.Show("Your Acount is not Active!!!");


            }
            else
            {
                 MessageBox.Show("Please, Enter correct Credentials!!!");

            }

        }
    }
}
