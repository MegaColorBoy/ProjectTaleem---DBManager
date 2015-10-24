using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace TaleemDBManager
{
    public partial class AddDeleteWord : MetroForm
    {
        String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
        public AddDeleteWord()
        {
            InitializeComponent();
            ViewDB();
        }

        //Upload the image of the word
        private void upldImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image file |*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgURLText.Text = ofd.FileName;
                    wordPicBox.Image = Image.FromFile(ofd.FileName);
                    this.wordPicBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool checkFields()
        {
            if(imgURLText.Text.Length > 0 && wordText.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        //Inserts the word into the DB
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(checkFields() == true)
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                MySqlCommand cmd;
                BinaryReader br;
                FileStream fs;

                try
                {
                    String filename = imgURLText.Text;
                    byte[] ImageData;
                    fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    String cmdString = "INSERT INTO spelltable_db(Word, Image) VALUES (@Word, @Image)";
                    cmd = new MySqlCommand(cmdString, connection);
                    cmd.Parameters.AddWithValue("@Word", wordText.Text);
                    cmd.Parameters.AddWithValue("@Image", ImageData);
                    connection.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {

                        MessageBox.Show("Word added!");
                        wordText.Clear();
                        imgURLText.Clear();
                        wordPicBox.Image = null;
                        ViewDB();
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
            else
            {
                MessageBox.Show("Please fill in the fields");
            }
        }

        public void ViewDB()
        {
            String connectionStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connectionStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Word, Image FROM spelltable_db";
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
                    connection.Clone();
                }
            }
        }

        private void delWordBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            if (delWordText.Text.Length > 0)
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE from spelltable_db WHERE Word='" + delWordText.Text + "';";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Word deleted!");
                    ViewDB();
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
                MessageBox.Show("Please type the word to be deleted !");
            }
        }
    }
}
