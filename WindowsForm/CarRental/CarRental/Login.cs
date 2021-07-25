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

            ///encryption
            //Create a sha256 object
            SHA256 sha = SHA256.Create();
            //convert password into hash values and store in a  bytes array
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            // create a string builder to collect the hashed data in byte array to create string from them

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2")); 

            }

                var hashedPassword = sBuilder.ToString();


            var user = carRentalEntitiesObj.Users.FirstOrDefault(x => x.userName == userName && x.password == hashedPassword);

            if (user != null)
            {
                if (!cbRememberPassword.Checked)
                {
                    tbUserName.Text = string.Empty;
                    tbPassword.Text = string.Empty;
                }

                this.Hide();
                var role = user.UserRoles.FirstOrDefault().Role.shortName;
                var mainWindow = new MainWindow(role, this);
                mainWindow.Show();
            }
            else
                MessageBox.Show("Please, Enter correct Credentials!!!");


        }
    }
}
