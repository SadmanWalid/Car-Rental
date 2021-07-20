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
    public partial class ManageCars : Form
    {
        private readonly CarRentalEntities carRentalEntitiesObj;
        public ManageCars()
        {
            carRentalEntitiesObj = new CarRentalEntities();
            InitializeComponent();
        }

        private void ManageCars_Load(object sender, EventArgs e)
        {
            var cars = carRentalEntitiesObj.TypesOfCars.Select(x => new { ID = x.id, Name = x.carTypes }).ToList();
            gvManageCars.DataSource = cars;

        }
    }
}
