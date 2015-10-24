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
    public partial class MainMenu : MetroForm
    {
        public String classSec;
        public static String cS;
        public MainMenu(String name, String classSection)
        {
            InitializeComponent();
            cS = classSection;
            this.classSec = classSection;

            //Creates a DB, just incase something goes wrong !
            CreateNewDB(classSec);

            this.Text = "Welcome " + name + " of " + classSection;
            addStudentBtn.Style = MetroColorStyle.Red;
            deleteStudentBtn.Style = MetroColorStyle.Green;
            editStudentBtn.Style = MetroColorStyle.Blue;
            levelMngrBtn.Style = MetroColorStyle.Yellow;
            exitBtn.Style = MetroColorStyle.Purple;
            ViewDB();
        }

        public void ViewDB()
        {
            String database = "class" + classSec + "_db";
            String connectionStr = "Server=localhost; Port=3306; Database=" + database +"; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connectionStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM studentinfo";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Clone();
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
                CreateNewTables(classSection);
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        //Add Student
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.Show();
        }

        //Edit Student
        private void editStudentBtn_Click(object sender, EventArgs e)
        {
            EditStudent edit = new EditStudent();
            edit.Show();
        }

        //Delete Student
        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            DeleteStudent delete = new DeleteStudent();
            delete.Show();
        }

        //Exit application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Level Manager
        private void levelMngrBtn_Click(object sender, EventArgs e)
        {
            LevelManager levelManager = new LevelManager();
            levelManager.Show();
        }

        //Refresh button
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ViewDB();
        }
    }
}
