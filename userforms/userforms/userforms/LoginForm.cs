using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userforms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Dell\\Documents\\userdata\\userdata.txt";
            string username = UserTBox.Text;
            string password = PassTBox.Text;
            try
            {
                // Input Validation
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    label1.Text = ("Username and password cannot be empty.");
                    return;
                }
                if (UserLogin(username, password, path))
                {
                    label1.Text = ("Login Successful!");
                    return;
                }
                else
                {
                    label1.Text = ("Username or password incorrect!");
                }
            }
            catch (FileNotFoundException ex)
            {
                label1.Text = ($"File not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                label1.Text = ($"An I/O error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                label1.Text = ($"An unexpected error occurred: {ex.Message}");
            }
        }
        private bool UserLogin(string username, string password, string path)// To check if username and password match
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] userdata = line.Split(':');
                        if (username == userdata[0] && password == userdata[1])
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = ($"Error reading file: {ex.Message}");
                return false;
            }
            return false;
        }

        private void Signuplbl_Click(object sender, EventArgs e)
        {
        }

        private void Signuplbl_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm signup = new SignupForm();
            signup.Show();

        }
    }
}
