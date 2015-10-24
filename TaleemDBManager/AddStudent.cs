using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace TaleemDBManager
{
    public partial class AddStudent : MetroForm
    {
        static String database = "class" + MainMenu.cS + "_db";
        String connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";

        public AddStudent()
        {
            InitializeComponent();
        }

        //Upload images
        private void imgUploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image file |*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageURLBox.Text = ofd.FileName;
                    studentPicBox.Image = Image.FromFile(ofd.FileName);
                    this.studentPicBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool checkFields()
        {
            if (firstnameBox.Text.Length > 0 && lastnameBox.Text.Length > 0 && dobBox.Text.Length > 0 &&
                colorblindBox.Text.Length > 0 && blindBox.Text.Length > 0 && imageURLBox.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            MySqlCommand cmd;
            BinaryReader br;
            FileStream fs;

            if (checkFields() == true)
            {
                try
                {
                    String filename = imageURLBox.Text;
                    byte[] ImageData;
                    fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    String cmdString = "INSERT INTO studentinfo(FirstName, LastName, DOB, isColorBlind, isBlind, Image) VALUES (@FirstName, @LastName, @DOB, @isColorBlind, @isBlind, @Image)";
                    cmd = new MySqlCommand(cmdString, connection);
                    cmd.Parameters.AddWithValue("@FirstName", firstnameBox.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastnameBox.Text);
                    cmd.Parameters.AddWithValue("@DOB", dobBox.Text);
                    cmd.Parameters.AddWithValue("@isColorBlind", colorblindBox.Text);
                    cmd.Parameters.AddWithValue("@isBlind", blindBox.Text);
                    cmd.Parameters.AddWithValue("@Image", ImageData);
                    connection.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        
                        MessageBox.Show("Student entry was successful!");
                        firstnameBox.Clear();
                        lastnameBox.Clear();
                        dobBox.Clear();
                        colorblindBox.Clear();
                        blindBox.Clear();
                        imageURLBox.Clear();
                        studentPicBox.Image = null;
                    }
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
