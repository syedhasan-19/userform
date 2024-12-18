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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
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

                // check if username aleady exists
                if (DoesUserExists(username, path))
                {
                    label1.Text = ("Username already exists!");
                    return;
                }


                // saves username and password
                Saveinfo(username, password, path);
                label1.Text = ("Signup successful!");
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
                //// Check if username exists
                //if (IsUsernameExists(username))
                //{
                //    MessageBox.Show("Username already exists!");
                //    return;
                //}

                //// Save user credentials to a file
                //SaveCredentials(username, password, customFilePath);

                //MessageBox.Show("Signup successful!");
                //// Navigate to login form or close the current form
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
        private bool DoesUserExists(string username, string path)// To check if user already exists
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] userexists = line.Split(':');
                        if (username == userexists[0])
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = ($"Error reading file: {ex.Message}");
                return true; // Handle file reading errors gracefully
            }
            return true;
        }

        //private bool IsUsernameExists(string username)
        //{
        //    // Since we're using file handling, no database check is needed
        //    return File.Exists(GetCredentialsFilePath(username));
        //    return false; // Assuming username uniqueness is handled elsewhere

        //    // Uncomment the following if you want to check for existing usernames in the file
        //}

        private void Saveinfo(string username, string password, string path)
        {
            try
            {
                // Check if the file exists
                if (!File.Exists(path))
                {
                    // Create an empty file if it doesn't exist
                    File.Create(path).Dispose();
                }
                string data = username + " : " + password; // Separate username and password with colon
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                label1.Text = ($"Error reading file: {ex.Message}");
            }

        }

        

        private void Loginlbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        //private string GetCredentialsFilePath(string username)
        //{
        //    // Define a folder or path to store credential files
        //    string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "userdata");

        //    // Create the folder if it doesn't exist
        //    Directory.CreateDirectory(folderPath);

        //    // Combine folder path with username to create a unique file path
        //    return Path.Combine(folderPath, username + ".txt");
        //}
    }
}
