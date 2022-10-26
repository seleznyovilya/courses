using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courses
{
    public partial class LoginView : Form
    {
        Users user = new Users();
        Model db = new Model();
        public LoginView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            
            
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            

            if (login == "admin" & password == "admin")
            {
                View_Users usersView = new View_Users();
                usersView.Show();
            }
            int k = 0;
            var Users = db.GetAllUsers();
            for (int i = 0; i < Users.Count; i++)
            {
                user = Users[i];
                if (user.login == login & user.password == password)
                {
                    k++;
                }
            }
            if (k>0)
            {
                MainView mainView = new MainView();
                mainView.Show();
                
            }

            

        }
    }
}
