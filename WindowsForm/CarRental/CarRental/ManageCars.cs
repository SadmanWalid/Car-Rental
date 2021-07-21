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
        private readonly CarRentalEntities carRentalEntitiesObj = new CarRentalEntities();
        public ManageCars()
        {
            InitializeComponent();

            
        }


        private void ManageCars_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        public  void RefreshGridView()
        {
            var cars = carRentalEntitiesObj.TypesOfCars.
                Select
                (x => new
                {
                    carName = x.brand,
                    modelName = x.model,
                    vin = x.vin,
                    licensePlate = x.licensePlate,
                    year = x.year,
                    carID = x.id
                }
                ).ToList();

            gvManageCars.DataSource = cars;
            gvManageCars.Columns[0].HeaderText = "Brand";
            gvManageCars.Columns[1].HeaderText = "Model";
            gvManageCars.Columns[2].HeaderText = "VIN";
            gvManageCars.Columns[3].HeaderText = "License Plate";
            gvManageCars.Columns[4].HeaderText = "Year";
            gvManageCars.Columns[5].Visible = false;
        }

        private void btAddNewCar_Click(object sender, EventArgs e)
        {
            var addEditCar = new AddEditCar(this);
            addEditCar.MdiParent = this.MdiParent;
            addEditCar.Show();
            
        }

        private void btEditCar_Click(object sender, EventArgs e)
        {

            
            var selectedRowIndex = gvManageCars.SelectedCells[0].RowIndex;
            var ID = (int)gvManageCars.Rows[selectedRowIndex].Cells["carID"].Value;
            
            var editCar = carRentalEntitiesObj.TypesOfCars.FirstOrDefault(x => x.id == ID );
            var addEditCar = new AddEditCar(editCar,this);
            addEditCar.MdiParent = this.MdiParent;
            addEditCar.Show();
           

        }

      
    }
}
