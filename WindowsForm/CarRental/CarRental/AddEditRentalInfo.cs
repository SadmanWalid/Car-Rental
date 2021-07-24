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
    public partial class AddEditRentalInfo : Form
    {
        private readonly CarRentalEntities carRentalEntitiesObj=new CarRentalEntities();
        private readonly int editRecordID;
        private readonly bool isEditMode;
        private readonly bool isAddRental;
        private readonly ManageRentalRecords ManageRentalRecordObj;


        public AddEditRentalInfo()
        {
            InitializeComponent();
            lbTitle.Text = "Add Rental Record";
            this.Text = "Add Rental Record";
            isEditMode = false;
            isAddRental = true;
    }
        public AddEditRentalInfo(ManageRentalRecords ManageRecordID)
        {
            ManageRentalRecordObj = ManageRecordID; // to fresh grid of ManageRentalRecords form
            InitializeComponent();
            this.Text = "Add Rental Record";
            lbTitle.Text = "Add Rental Record";
            isEditMode = false;
            isAddRental = false;

        }

        public AddEditRentalInfo(int recordID, ManageRentalRecords ManageRecordID)
        {
            ManageRentalRecordObj = ManageRecordID; // to fresh grid of ManageRentalRecords form
            InitializeComponent();
            editRecordID = recordID;
            isEditMode = true;
            isAddRental = false;
            this.Text = "Edit Rental Record";
            lbTitle.Text = "Edit Rental Record";
            PopulateTextBoxes();


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

                    if(!isEditMode)
                    {
                        //add record code
                        SaveRentalRecord();

                    }

                    else
                    {
                        //edit record code
                        SaveRentalRecord();
                        //ManageRentalRecordObj.RefreshGridView();

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

        private void PopulateTextBoxes()
        {
            var record = carRentalEntitiesObj.CarRentalDetails.FirstOrDefault(x => x.id == editRecordID);
            tbCustomerName.Text = record.customerName;
            tbCost.Text = record.cost.ToString();
            dateRent.Value = record.dateRented.Value;
            dateReturn.Value = record.dateReturned.Value;
            cbTypeOfCar.SelectedItem = record.TypesOfCar.brand+" "+record.TypesOfCar.model;
        }

        private void SaveRentalRecord()
        {
            CarRentalDetail carRentalRecord;
            if (!isEditMode)
                carRentalRecord = new CarRentalDetail();
            else
                carRentalRecord = carRentalEntitiesObj.CarRentalDetails.FirstOrDefault(x => x.id==editRecordID);

            carRentalRecord.customerName = tbCustomerName.Text; 
            carRentalRecord.dateRented = dateRent.Value;
            carRentalRecord.dateReturned = dateReturn.Value;
            carRentalRecord.cost = decimal.Parse(tbCost.Text);
            carRentalRecord.carType = (int)cbTypeOfCar.SelectedValue;

            carRentalEntitiesObj.CarRentalDetails.Add(carRentalRecord);
            carRentalEntitiesObj.SaveChanges();
            

            MessageBox.Show($"Submited Successfully\n" +
                $"Customer Name: {tbCustomerName.Text}\n\rCar Type: {cbTypeOfCar.Text}\n\r" +
            $"Date of Renting: {dateRent.Value}\n\r" +
            $"Date of Return: {dateReturn.Value}\n\r" +
            $"Cost:${tbCost.Text}\n\r" +
            $"=======Thank You======="
            );
        }

        private void AddRentalInfo_Load(object sender, EventArgs e)
        {
            var Cars = carRentalEntitiesObj.TypesOfCars.Select(x => new { carID=x.id, car = x.brand + " " + x.model }).ToList();
            cbTypeOfCar.DataSource = Cars;
            cbTypeOfCar.ValueMember = "carId";
            cbTypeOfCar.DisplayMember = "car";
        }

        private void AddEditRentalInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!isAddRental)
            ManageRentalRecordObj.RefreshGridView();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
