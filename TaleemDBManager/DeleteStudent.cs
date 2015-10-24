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
    public partial class DeleteStudent : MetroForm
    {
        static String database = "class" + MainMenu.cS + "_db";
        String connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";

        public DeleteStudent()
        {
            InitializeComponent();
        }

        //Delete button
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE from studentinfo WHERE idStudent='" + idTxtBox.Text + "';";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student information deleted!");
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
