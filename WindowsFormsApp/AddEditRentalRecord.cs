using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;

        private readonly CarRentalEntities _db;
        public AddEditRentalRecord()
        {       
            InitializeComponent();
            lblTitle.Text = "Add New Rental";
            this.Text = "Add New Rental";
            isEditMode = false;
            _db = new CarRentalEntities();
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                PopulateFields(recordToEdit);
            }
        }
        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbCustomerName.Text = recordToEdit.CustomerName;
            dtRented.Value = (DateTime)recordToEdit.DateRented;
            dtReturned.Value = (DateTime)recordToEdit.DateReturned;
            tbCost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtReturned.Value;
                var carType = cbTypeOfCar.Text;
                double cost = Convert.ToDouble(tbCost.Text);
                var isValid = true;
                var errorMessages = "";

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(carType))
                {
                    isValid = false;
                   errorMessages+="Error: Enter Missing data.\n\r";
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessages += "Error: Illegal Date Selection.\n\r";
                }
                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();

                    if (isEditMode)
                    {
                        var id = int.Parse(lblRecordId.Text);
                        rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
                    }
                   
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

                    if (!isEditMode)
                        _db.CarRentalRecords.Add(rentalRecord);

                    _db.SaveChanges();

                    MessageBox.Show($"Customer Name: {customerName}\n\r" +
                      $"Date Rented: {dateOut}\n\r" +
                      $"Date Returned: {dateIn}\n\r" +
                      $"Cost : {cost}\n\r" +
                      $"Car Type: {carType}\n\r" +
                      $"THANK YOU FOR YOUR BUSINESS");

                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessages);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message); 
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = _db.TypesOfCars
                .Select(q => new { Id = q.Id, Name = q.Make + " " + q.Model })
                .ToList();
            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "Id";
            cbTypeOfCar.DataSource= cars;

        }

       
    }
}
