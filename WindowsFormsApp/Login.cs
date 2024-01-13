using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities _db;
        public Login()
        {
            InitializeComponent();
            _db= new CarRentalEntities();
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username=tbUserName.Text.Trim();
                var password=tbPassword.Text;

                byte[] data=sha.ComputeHash(Encoding.UTF8.GetBytes(password));  

                StringBuilder sb = new StringBuilder();

                for(int i=0;i<data.Length; i++) 
                { 
                    sb.Append(data[i].ToString("x2"));  
                }

                var hashed_password=sb.ToString();

                var user=_db.Users.FirstOrDefault(q=>q.username == username && q.password== hashed_password);
                if (user==null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {   
                    var role=user.UserRoles.FirstOrDefault();
                    var roleShortName = role.Role.shortname;
                    var mainWindow=new MainWindow(this, roleShortName);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. please try again");    
            }
        }
    }
}
