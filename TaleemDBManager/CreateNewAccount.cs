using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework;

//Creates a new user account + creates individual schemas for each teacher
//Making it easier to manage data and improve security
namespace TaleemDBManager
{
    public partial class CreateNewAccount : MetroForm
    {
        public CreateNewAccount()
        {
            InitializeComponent();
            this.Text = "Create a new user account";
        }

        //Submit button
        private void submitBtn_Click(object sender, EventArgs e)
        {
            String firstName=firstNameBox.Text;
            String lastName=lastNameBox.Text;
            String classSection=classSectionBox.Text;
            String userName=usernameBox.Text;
            String password=passwordBox.Text;

            String connectionStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connectionStr);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO teacherlogin (FirstName, LastName, ClassSection, Username, Password) VALUES (@FirstName, @LastName, @ClassSection, @Username, @Password)";
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@ClassSection", classSection);
                cmd.Parameters.AddWithValue("@Username", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                //MessageBox.Show("Please fill in the blanks");
                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    //Create DB and Create Tables
                    CreateNewDB(classSection);
                    CreateNewTables(classSection);
                    connection.Close();
                }
            }
        }

        //Create Schema/Database for new users
        private void CreateNewDB(String classSection)
        {
            String connectionStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connectionStr);

            try
            {
                connection.Open();
                MySqlCommand cmd;
                cmd = connection.CreateCommand();
                //e.g: class1a_db
                cmd.CommandText = "CREATE SCHEMA IF NOT EXISTS class" + classSection + "_db";
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //Insert new tables for new users
        private void CreateNewTables(String classSection)
        {
            String database = "class" + classSection + "_db";
            String connectionStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connectionStr);

            try
            {
                String cmdString = @"CREATE TABLE IF NOT EXISTS studentinfo (
                                    idStudent INT NOT NULL AUTO_INCREMENT,
                                    FirstName VARCHAR(45) NULL,
                                    LastName VARCHAR(45) NULL,
                                    DOB VARCHAR(45) NULL,
                                    isColorBlind VARCHAR(45) NULL,
                                    isBlind VARCHAR(45) NULL,
                                    Image MEDIUMBLOB NULL,
                                    PRIMARY KEY(idStudent));";

                String cmdString2 = @"CREATE TABLE IF NOT EXISTS levelmngr (
                                    idPhases INT NOT NULL AUTO_INCREMENT,
                                    Phases INT NOT NULL,
                                    Levels VARCHAR(45) NULL,
                                    isSet VARCHAR(45) NULL,
                                    PRIMARY KEY(idPhases));";

                MySqlCommand cmd = new MySqlCommand(cmdString, connection);
                MySqlCommand cmd2 = new MySqlCommand(cmdString2, connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
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
    }
}
