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
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _roleName;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Login login,string roleShortName)
        {
            InitializeComponent();
            _login = login;
            _roleName = roleShortName;  
        }

        private void addRentelRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord=new AddEditRentalRecord();
            addRentalRecord.MdiParent=this;
            addRentalRecord.Show();
        }

        private void manageVechicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vechicleListing=new ManageVehicleListing();
            vechicleListing.MdiParent = this;
            vechicleListing.Show();
        }

        private void viewArchieveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecords();
            manageRentalRecords.MdiParent = this;
            manageRentalRecords.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close(); 
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageUsers = new ManageUsers();
            manageUsers.MdiParent = this;
            manageUsers.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_roleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false; 
            }
        }
    }
}
 