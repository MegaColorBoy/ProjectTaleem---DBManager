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

//Adds phases to the Database, gives much more flexibility for the teachers
//to enter any letters they wanted for any phase with a maximum of 4 letters per phase
namespace TaleemDBManager
{
    public partial class AddPhase : MetroForm
    {
        int size = 0;
        static int counter = 0;
        Button[] buttons;
        bool[] setValues;
        static String database = "class" + MainMenu.cS + "_db";
        String connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
        //The 42-letter of Jollyphonics
        String[] jollyPhonics = {"S", "A", "T", "I", "P", "N",
                                 "CK", "E", "H", "R", "M", "D",
                                 "G", "O", "U", "F", "B",
                                 "AI", "J", "OA", "IE", "EE", "OR",
                                 "Z", "W", "NG", "V", "OO", "OO",
                                 "Y", "X", "CH", "SH", "TH", "TH",
                                 "QU", "OU", "OI", "UE", "ER", "AR"};
        static List<String> list = new List<String>();
        String strToSubmit = "";

        public AddPhase()
        {
            InitializeComponent();
            generateButtons();
        }

        //Generates buttons with different letters
        private void generateButtons()
        {
            buttons = new Button[jollyPhonics.Length];
            setValues = new bool[jollyPhonics.Length];
            for(int i=0; i<buttons.Length; i++)
            {

                buttons[i] = new Button();
                buttons[i].Height = 50;
                buttons[i].Width = 50;
                buttons[i].Name = "Phase " + (i + 1);
                buttons[i].TabIndex = (i);
                buttons[i].Text = jollyPhonics[i];
                setValues[i] = false;
                buttons[i].Click += new System.EventHandler(ButtonEventHandler);
                this.flowLayoutPanel1.Controls.Add(buttons[i]);
            }
        }

        //Button events, if the button is pressed, the button color changes and the letter is inserted into a list
        //if pressed again, the button color changes and it'll be removed from the list
        private void ButtonEventHandler(object sender, EventArgs e)
        {
            int index = ((Button)sender).TabIndex;
            String text = ((Button)sender).Text;
            if(setValues[index] == false)
            {
                buttons[index].BackColor = Color.Red;
                setValues[index] = true;
                addLetter(text);
                size = list.Count;
                counter++;
            }
            else if(setValues[index] == true)
            {
                buttons[index].BackColor = Color.Transparent;
                setValues[index] = false;
                removeLetter(text);
                size--;
                counter--;
            }
        }

        //Add the letter
        private void addLetter(String letter)
        {
            list.Add(letter);
            letterLabel.Text += letter + " ";
            strToSubmit = letterLabel.Text;
        }

        //Removes the letter
        private void removeLetter(String letter)
        {
            list.Remove(letter);
            letterLabel.Text = String.Join(" ", list.ToArray()) + " ";
            strToSubmit = letterLabel.Text;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //String formatting using semi-colon
        private String addColon(String str)
        {
            char[] charArr = str.ToCharArray();
            for(int i=0; i<charArr.Length; i++)
            {
                if(charArr[i] == ' ')
                {
                    charArr[i] = ';';
                }
            }
            return String.Join("", charArr.ToArray());
        }

        //Submit button, inserts the phase into the DB
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(phaseBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a phase before you submit !");
            }
            else if (counter < 1 || counter > 4)
            {
                MessageBox.Show("You can select from 1 to 4 letters only !");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                try
                {
                    String cmdString = "INSERT INTO levelmngr (Phases, Levels, isSet) VALUES (@Phases, @Levels, @isSet)";
                    MySqlCommand cmd = new MySqlCommand(cmdString, connection);
                    cmd.Parameters.AddWithValue("@Phases", int.Parse(phaseBox.Text));
                    cmd.Parameters.AddWithValue("@Levels", addColon(strToSubmit));
                    //Set to "N" by default
                    cmd.Parameters.AddWithValue("@isSet", "N");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New phase has been added !");
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelManager levelmngr = new LevelManager();
            levelmngr.ShowDialog();
        }
    }
}
