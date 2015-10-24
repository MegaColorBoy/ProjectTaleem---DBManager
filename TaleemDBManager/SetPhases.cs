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

//Improved version of setting the phases/levels.
namespace TaleemDBManager
{
    public partial class SetPhases : MetroForm
    {
        Button[] buttons;
        int size = 0;
        List<String> Levels;
        List<String> SetValues;
        static String database = "class" + MainMenu.cS + "_db";
        String connStr = "Server=localhost; Port=3306; Database="+database+"; Uid=root; Pwd=admin;";

        public SetPhases()
        {
            InitializeComponent();
            Levels = getLevels(connStr);
            SetValues = getSetValues(connStr);
            generateButtons(Levels, SetValues);
        }

        //Get levels from DB
        private List<String> getLevels(String connStr)
        {
            List<String> list = new List<String>();
            MySqlConnection connection = new MySqlConnection(connStr);
            MySqlDataReader reader = null;
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Levels FROM levelmngr";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                    size = list.Count;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return list;
        }

        //Get the values set from DB
        private List<String> getSetValues(String connStr)
        {
            List<String> list = new List<String>();
            MySqlConnection connection = new MySqlConnection(connStr);
            MySqlDataReader reader = null;
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT isSet FROM levelmngr";
                reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return list;
        }

        //Generates "phases" buttons based on the number of phases stored in the DB
        private void generateButtons(List<String>list, List<String> values)
        {
            buttons = new Button[size];
            for(int i=0; i<buttons.Length; i++)
            {
                String set = values[i];
                buttons[i] = new Button();
                buttons[i].Height = 100;
                buttons[i].Width = 100;
                buttons[i].Name = "Phase " + (i + 1);
                buttons[i].TabIndex = (i);
                buttons[i].Text = list[i];
                if(set == "N")
                {
                    buttons[i].BackColor = Color.White;
                }
                else if(set == "Y")
                {
                    buttons[i].BackColor = Color.BlanchedAlmond;
                }
                buttons[i].Click += new System.EventHandler(ButtonEventHandler);
                this.flowLayoutPanel1.Controls.Add(buttons[i]);

            }
        }

        //When clicked, the level is set to 'Y' else, to 'N'
        private void ButtonEventHandler(object sender, EventArgs e)
        {
            int buttonIndex = ((Button)sender).TabIndex;
            String buttonText = Levels[buttonIndex];
            String setText = SetValues[buttonIndex];
            MySqlConnection connection = new MySqlConnection(connStr);
            MySqlDataReader reader = null;
            try
            {
                String cmdString;
                if(setText.Equals("Y"))
                {
                    cmdString = "UPDATE levelmngr SET isSet='N' WHERE isSet='Y' AND Levels='" + buttonText + "';";
                    SetValues[buttonIndex] = "N";
                    buttons[buttonIndex].BackColor = Color.White;
                }
                else
                {
                    cmdString = "UPDATE levelmngr SET isSet='Y' WHERE isSet='N' AND Levels='" + buttonText + "';";
                    SetValues[buttonIndex] = "Y";
                    buttons[buttonIndex].BackColor = Color.BlanchedAlmond;
                }
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(cmdString, connection);
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelManager levelmngr = new LevelManager();
            levelmngr.ShowDialog();
        }

    }
}
