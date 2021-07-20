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
    public partial class AddRentalInfo : Form
    {
        private readonly CarRentalEntities carRentalObject;
        public AddRentalInfo()
        {
            InitializeComponent();
            carRentalObject = new CarRentalEntities();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            //form validation
            try
            {
                String customerName = tbCustomerName.Text;
                DateTime dateOfRenting =dateRent.Value;
                DateTime dateOfReturn = dateReturn.Value;
                var carType = cbTypeOfCar.Text;
                bool isValid = true;
                StringBuilder errorMessage = new StringBuilder();
                //Customer name validation
                if (string.IsNullOrWhiteSpace(customerName))
                {
                    errorMessage.AppendLine("Enter a valid name!");
                    isValid = false;
                }
                //car type validation
                if (string.IsNullOrWhiteSpace(carType))
                {
                    errorMessage.AppendLine("Select the type of car!!!");
                    isValid = false;
                }
                //date validation and cost counting
                if (dateOfRenting >= dateOfReturn)
                {
                    errorMessage.Append("Invalid Date!!! \n\r");
                    isValid = false;
                }
                else
                {
                    tbCost.Text = Convert.ToString((dateOfReturn - dateOfRenting).Days * 10);
                }


                if (isValid)
                {
                    var carRentalDetailsObject = new CarRentalDetail();
                    carRentalDetailsObject.customerName = customerName;
                    carRentalDetailsObject.dateRented = dateOfRenting;
                    carRentalDetailsObject.dateReturned = dateOfReturn;
                    carRentalDetailsObject.cost = decimal.Parse(tbCost.Text);
                    carRentalDetailsObject.carType = (int)cbTypeOfCar.SelectedValue;

                    carRentalObject.CarRentalDetails.Add(carRentalDetailsObject);
                    carRentalObject.SaveChanges();
                    

                    MessageBox.Show($"Customer Name: {customerName}\n\rCar Type: {carType}\n\r" +
                    $"Date of Renting: {dateOfRenting}\n\r" +
                    $"Date of Return: {dateOfReturn}\n\r" +
                    $"Cost:${tbCost.Text}\n\r" +
                    $"=======Thank You======="
                    );
                }
                else
                    MessageBox.Show(errorMessage.ToString());


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddRentalInfo_Load(object sender, EventArgs e)
        {
            var Cars = carRentalObject.TypesOfCars.ToList();
            cbTypeOfCar.DataSource = Cars;
            cbTypeOfCar.ValueMember = "id";
            cbTypeOfCar.DisplayMember = "carTypes";
        }

       
    }
}
