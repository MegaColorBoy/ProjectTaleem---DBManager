using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace TaleemDBManager
{
    public partial class EditStudent : MetroForm
    {
        static String database = "class" + MainMenu.cS + "_db";
        String connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";

        public EditStudent()
        {
            InitializeComponent();
        }

        //Checks if all fields are filled before entering into the database
        private bool checkFields()
        {
            if (idBox.Text.Length > 0 && firstNameTxt.Text.Length > 0 && lastNameTxt.Text.Length > 0 && dobTxt.Text.Length > 0 &&
               blindTxt.Text.Length > 0 && colorBlindTxt.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        //Edit button
        private void EditBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT FirstName, LastName, DOB, isColorBlind, isBlind FROM studentinfo WHERE idStudent='" + idBox.Text + "';";
                MySqlDataReader reader;
                connection.Open();
                reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if(count == 1)
                {
                    firstNameTxt.Text = reader.GetString(0);
                    lastNameTxt.Text = reader.GetString(1);
                    dobTxt.Text = reader.GetString(2);
                    colorBlindTxt.Text = reader.GetString(3);
                    blindTxt.Text = reader.GetString(4);
                }
                reader.Close();
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

        //Submit information
        private void submitBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            if (checkFields() == true)
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE studentinfo SET FirstName='" + firstNameTxt.Text + "', LastName='" + lastNameTxt.Text + "', DOB='" + dobTxt.Text + "', isColorBlind='" + colorBlindTxt.Text + "', isBlind='" + blindTxt.Text + "' WHERE idStudent='" + idBox.Text + "';";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student information updated!");
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
            else
            {
                MessageBox.Show("Please fill all the fields!");
            }
        }
    }
}
