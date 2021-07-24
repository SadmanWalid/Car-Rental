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
    public partial class AddEditCar : Form
    {
        private ManageCars manageCarObj;

        private readonly CarRentalEntities carRentalEntityobj= new CarRentalEntities();
        private bool isEditMode;
        private readonly int editCarID;
        public AddEditCar(ManageCars manageCar)
        {
            manageCarObj = manageCar; // to call RefreshGridView method of ManageCars form, when AddEdit form is closed
            InitializeComponent();
            this.Text = "Add New Car";
            lbTitle.Text = "Add New Car";
            lbTitle.Visible = true;
            isEditMode = false;
        }

        public AddEditCar(int ID, ManageCars manageCar)
        {
            manageCarObj = manageCar; // to call RefreshGridView method of ManageCars form, when AddEdit form is closed
            editCarID = ID;
            InitializeComponent();
            this.Text = "Edit Car";
            lbTitle.Text = "Edit Car";
            lbTitle.Visible = true;
            PopulateTextFields(editCarID);
            isEditMode = true;
        }

        private void PopulateTextFields(int id)
        {
            var editCar = carRentalEntityobj.TypesOfCars.FirstOrDefault(x => x.id == id);
            tbBrand.Text = editCar.brand;
            tbModel.Text = editCar.model;
            tbVIN.Text = editCar.vin;
            tbLicenseNumber.Text = editCar.licensePlate;
            tbYear.Text = editCar.year.ToString();
        }

        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            string brand = tbBrand.Text;
            string model = tbModel.Text;
            string vin = tbVIN.Text;
            string Lincense = tbLicenseNumber.Text;

            if (int.TryParse(tbYear.Text, out int year)) ;
            
            var currentYear = DateTime.Now.Year;
            StringBuilder errorMessage = new StringBuilder("Errors!!!!\n");


            bool isValid = true;
      
            try
            {
                //brand
                if (string.IsNullOrWhiteSpace(brand))
                {
                    errorMessage.AppendLine("Enter Brand Name");
                    isValid = false;
                }
                else
                    isValid = true;
                //model
                if (string.IsNullOrWhiteSpace(model))
                {
                    errorMessage.AppendLine("Enter model Name");
                    isValid = false;
                }
               
                //vin
                if (string.IsNullOrWhiteSpace(vin))
                {
                    errorMessage.AppendLine("Enter Vehicle Identity Number");
                    isValid = false;
                }
                
                //lincense
                if (string.IsNullOrWhiteSpace(Lincense))
                {
                    errorMessage.AppendLine("Enter Lincense Number");
                    isValid = false;
                }

                //year
                if (!(year > 1900 && year < currentYear))
                {
                    errorMessage.AppendLine("Enter a Valid Year between 1900 and" +" "+currentYear);
                    isValid = false;
                }

                if (isValid)
                {

                    if (isEditMode)
                    {


                        var car = carRentalEntityobj.TypesOfCars.FirstOrDefault(x => x.id == editCarID);
                        car.brand = brand;
                        car.model = model;
                        car.vin = vin;
                        car.licensePlate = Lincense;
                        car.year = year;
                        carRentalEntityobj.SaveChanges();
                        manageCarObj.RefreshGridView();
                        MessageBox.Show("Changes Saved Successfully");
                        btCancel.Text = "Close";


                    }
                    else
                    {
                        //add code

                        var newCar = new TypesOfCar();
                        newCar.brand = tbBrand.Text;
                        newCar.model = tbModel.Text;
                        newCar.vin = tbVIN.Text;
                        newCar.licensePlate = tbLicenseNumber.Text;
                        newCar.year = int.Parse(tbYear.Text);

                        carRentalEntityobj.TypesOfCars.Add(newCar);
                        carRentalEntityobj.SaveChanges();
                        manageCarObj.RefreshGridView();
                        btCancel.Text = "Close";
                        MessageBox.Show("Car Added Successfully");

                    }





                }
                else
                    MessageBox.Show(errorMessage.ToString());
    


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void AddEditCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            manageCarObj.RefreshGridView();
         
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
