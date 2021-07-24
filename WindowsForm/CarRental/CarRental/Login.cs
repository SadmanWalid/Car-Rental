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

            var isValidUser = carRentalEntitiesObj.Users.Any(x => x.userName == userName && x.password == password);

            if(isValidUser)
            {
                this.Hide();
                var mainWindow = new MainWindow(this);
                mainWindow.Show();
            }


        }
    }
}
