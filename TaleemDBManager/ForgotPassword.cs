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
    public partial class ForgotPassword : MetroForm
    {
        String connStr = "Server=localhost; Port=3306; Database=dbtest; Uid=root; Pwd=admin;";
        public ForgotPassword()
        {
            InitializeComponent();
        }

        //Submit details
        private void submitBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            if (usernameBox.Text.Length == 0 || enterPassBox.Text.Length == 0 || reEnterPassBox.Text.Length == 0)
            {
                MessageBox.Show("Please fill in the blanks");
            }
            else
            {
                if (enterPassBox.Text.Equals(reEnterPassBox.Text))
                {
                    try
                    {
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "UPDATE teacher_table SET Password='" + this.enterPassBox.Text + "' WHERE Username='" + this.usernameBox.Text + "';";
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your new password is saved !");
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
                    MessageBox.Show("Please enter your new password again !");
                }
            }
        }
    }
}
