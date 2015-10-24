using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace TaleemDBManager
{
    public partial class DeletePhase : MetroForm
    {
        static String database = "class" + MainMenu.cS + "_db";
        String connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
        public DeletePhase()
        {
            InitializeComponent();
            viewPhases(connStr);
        }

        //Deletes the selected phase
        private void delBtn_Click(object sender, EventArgs e)
        {
            if (phaseBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a phase !");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                try
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE FROM levelmngr where Phases='" + int.Parse(phaseBox.Text) + "';";
                    cmd.ExecuteNonQuery();
                    viewPhases(connStr);
                    MessageBox.Show("Phase has been deleted!");
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

        //Displays the current phases in the DB
        //It helps the user to decide which one to remove
        private void viewPhases(String connStr)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Phases, Levels FROM levelmngr";
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
                    connection.Close();
                }
            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelManager levelmngr = new LevelManager();
            levelmngr.ShowDialog();
        }
    }
}
