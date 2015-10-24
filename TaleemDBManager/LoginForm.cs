using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace TaleemDBManager
{
    public partial class LoginForm : MetroForm
    {
        //Using dbtest as my temp. db to access teacher login details table
        String connectionStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
        public LoginForm()
        {
            InitializeComponent();
            loginBtn.Style = MetroColorStyle.Red;
            createNewAcBtn.Style = MetroColorStyle.Purple;
            forgotPassBtn.Style = MetroColorStyle.Blue;
        }

        //When logged in, goes to Main Menu
        private void loginBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionStr);
            try
            {
                String cmdString = "SELECT FirstName, LastName, ClassSection FROM teacherlogin WHERE Username='" + this.userTextBox.Text + "' AND Password='" + this.passTextBox.Text + "'";
                MySqlCommand cmd = new MySqlCommand(cmdString, connection);
                MySqlDataReader reader;
                connection.Open();

                reader = cmd.ExecuteReader();

                int count = 0;

                while(reader.Read())
                {
                    count++;
                }

                if(count == 1)
                {
                    String name = reader.GetString(0) + " " + reader.GetString(1);
                    String classSection = reader.GetString(2);
                    MainMenu main = new MainMenu(name, classSection);
                    this.Hide();
                    main.ShowDialog();
                    //MessageBox.Show(reader.GetString(0) + " " + reader.GetString(1));
                }
                else if(count > 1)
                {
                    MessageBox.Show("Duplicate username/password");
                }
                else
                {
                    MessageBox.Show("Incorrect username/password");
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        //When pressed, goes to CreateNewAccount.cs Form
        private void createNewAcBtn_Click(object sender, EventArgs e)
        {
            CreateNewAccount create = new CreateNewAccount();
            create.Show();
        }

        //When pressed, goes to ForgotPassword.cs Form
        private void forgotPassBtn_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
        }
    }
}
