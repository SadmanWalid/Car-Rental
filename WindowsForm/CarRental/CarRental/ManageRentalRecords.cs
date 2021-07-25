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
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities carRentalEntitiesObj = new CarRentalEntities();
        public ManageRentalRecords()
        {
           
            InitializeComponent();
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {

            RefreshGridView();
           
        }

        public void RefreshGridView()
        {
            var records = carRentalEntitiesObj.CarRentalDetails.
               Select
              (x => new
              {
                  Customer = x.customerName,
                  dateRented = (DateTime)x.dateRented,
                  dateReturned = (DateTime)x.dateReturned,
                  Cost = x.cost,
                  carType = x.TypesOfCar.brand + " " + x.TypesOfCar.model,
                  ID = x.id,

              }
               ).ToList();
            gvManageRentalRecords.DataSource = records;
            gvManageRentalRecords.Columns["dateRented"].HeaderText = "Date of Renting";
            gvManageRentalRecords.Columns["dateReturned"].HeaderText = "Date of Returning";
            gvManageRentalRecords.Columns["carType"].HeaderText = "Car";
            gvManageRentalRecords.Columns["ID"].Visible = false;
        }

        private void btAddNewRecord_Click(object sender, EventArgs e)
        {
            var record = new AddEditRentalInfo(this)
            {
                MdiParent = this.MdiParent
            };

            record.Show();

                
        }

        private void btEditRecord_Click(object sender, EventArgs e)
        {
            var rowIndex = gvManageRentalRecords.SelectedCells[0].RowIndex;
            var editRecordID = (int)gvManageRentalRecords.Rows[rowIndex].Cells["ID"].Value;
            var record = new AddEditRentalInfo(editRecordID,this)
            { 
                MdiParent =this.MdiParent,
            };

            record.Show();
        }

        private void BtDeleteRecord_Click(object sender, EventArgs e)
        {
            var rowIndex = gvManageRentalRecords.SelectedCells[0].RowIndex;
            var recordID = (int)gvManageRentalRecords.Rows[rowIndex].Cells["ID"].Value;

            DialogResult dr = MessageBox.Show("Are You Sure, You Want to Delete This Record?",
                "Delete", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);
            if(dr==DialogResult.Yes)
            {
                var record = carRentalEntitiesObj.CarRentalDetails.FirstOrDefault(x => x.id == recordID);
                carRentalEntitiesObj.CarRentalDetails.Remove(record);
                carRentalEntitiesObj.SaveChanges();
                RefreshGridView();
                MessageBox.Show("Record Deleted Successfully");
            }    
           

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
