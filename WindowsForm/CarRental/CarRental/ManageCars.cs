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
            var cars = carRentalEntitiesObj.TypesOfCars.Select(x => new 
                { carName = x.brand, modelName =x.model,
                vin =x.vin, licensePlate = x.licensePlate,
                year= x.year}).ToList();
            gvManageCars.DataSource = cars;
            gvManageCars.Columns[0].HeaderText = "Brand";
            gvManageCars.Columns[1].HeaderText = "Model";
            gvManageCars.Columns[2].HeaderText = "VIN";
            gvManageCars.Columns[3].HeaderText = "License Plate";
            gvManageCars.Columns[4].HeaderText = "Year";
        }
    }
}
