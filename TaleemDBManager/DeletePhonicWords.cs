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
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using NAudio;
using NAudio.Wave;
using MySql.Data.MySqlClient;

namespace TaleemDBManager
{
    public partial class DeletePhonicWords : MetroForm
    {
        String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
        public DeletePhonicWords()
        {
            InitializeComponent();
            viewPhases(connStr);
        }

        //Displays the current phases in the DB
        //It helps the user to decide which one to remove
        private void viewPhases(String connStr)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Word, Image FROM wordbank_db";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
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

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (wordBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a word !");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                try
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE FROM wordbank_db where Word='" + wordBox.Text + "';";
                    cmd.ExecuteNonQuery();
                    viewPhases(connStr);
                    MessageBox.Show("Word has been deleted!");
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
        }
    }
}
