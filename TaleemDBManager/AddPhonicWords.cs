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

//Add phonic words to the word bank
namespace TaleemDBManager
{
    public partial class AddPhonicWords : MetroForm
    {
        Button[] buttons;
        String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
        List<String> letters;
        private NAudio.Wave.WaveFileReader wave = null;
        private NAudio.Wave.DirectSoundOut output = null;

        public AddPhonicWords()
        {
            InitializeComponent();
            wordLabel.Text = null;
            letters = getLetters();
            generateButtons(letters);
        }

        private List<String> getLetters()
        {
            String dir = "TeacherWAV";
            String[] files = Directory.GetFiles(dir, "*.wav");
            List<String> list = new List<String>();
            for (int i = 0; i < files.Length; i++)
            {
                list.Add(splitDir(files[i]));
            }
            return list;
        }

        //Extracts the filename
        private String splitDir(String filename)
        {
            String[] splitArr = filename.Split('\\');
            String[] splitJPG = splitArr[splitArr.Length - 1].Split('.');
            return splitJPG[0];
        }

        private void generateButtons(List<String>letters)
        {
            buttons = new Button[letters.Count];
            for(int i=0; i<letters.Count; i++)
            {
                buttons[i] = new Button();
                buttons[i].Size = new System.Drawing.Size(50, 50);
                buttons[i].Text = letters[i];
                flowLayoutPanel1.Controls.Add(buttons[i]);
                buttons[i].Click += new System.EventHandler(ButtonEventHandler);
            }
        }

        private void ButtonEventHandler(object sender, EventArgs e)
        {
            String text = ((Button)sender).Text;
            wordLabel.Text += text + " ";
        }

        //Create directories to store concatenated words and audio
        private void createDirectories()
        {
            if(!Directory.Exists("PhonicsWord_Image"))
            {
                Directory.CreateDirectory("PhonicsWord_Image");
            }

            if (!Directory.Exists("PhonicsWord_Audio"))
            {
                Directory.CreateDirectory("PhonicsWord_Audio");
            }
        }

        //Create the concatenated audio and image of the word
        private void createWordBtn_Click(object sender, EventArgs e)
        {
            if (wordLabel.Text.Length > 0)
            {
                createDirectories();

                String word = wordLabel.Text;
                String[] letters = word.Split(' ');
                List<String> files = new List<String>(), files2 = new List<String>();

                String outputFile = "PhonicsWord_Image\\" + word + ".jpg", outputFile2 = @"PhonicsWord_Audio\" + word + ".wav";
                String directory = "Images", directory2 = "TeacherWAV";

                for (int i = 0; i < letters.Length - 1; i++)
                {
                    files.Add(directory + @"\" + letters[i] + ".jpg");
                    files2.Add(directory2 + @"\" + letters[i] + ".wav");
                }

                //MessageBox.Show(files[0]);
                concatenateAudio(outputFile2, files2);
                concatenateImage(outputFile, files);
            }
            else
            {
                MessageBox.Show("Word isn't created yet !");
            }
        }

        //Concatenates the audio files
        private void concatenateAudio(String outputFile, List<String> sourceFiles)
        {
            byte[] buffer = new byte[1024];
            WaveFileWriter waveFileWriter = null;

            try
            {
                foreach (string sourceFile in sourceFiles)
                {
                    using (WaveFileReader reader = new WaveFileReader(sourceFile))
                    {
                        if (waveFileWriter == null)
                        {
                            // first time in create new Writer
                            waveFileWriter = new WaveFileWriter(outputFile, reader.WaveFormat);
                        }
                        else
                        {
                            if (!reader.WaveFormat.Equals(waveFileWriter.WaveFormat))
                            {
                                throw new InvalidOperationException("Can't concatenate WAV Files that don't share the same format");
                            }
                        }

                        int read;
                        while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            waveFileWriter.WriteData(buffer, 0, read);
                        }
                    }
                }
            }
            finally
            {
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                }
            }
        }

        //Concatenates the image files
        private void concatenateImage(String outputFile, List<String> files)
        {
            List<int> imageHeight = new List<int>();
            int nIndex = 0;
            int width = 0;
            foreach (String file in files)
            {
                Image img = Image.FromFile(file);
                imageHeight.Add(img.Height);
                width += img.Width;
                img.Dispose();
            }

            imageHeight.Sort();
            //Max height
            int height = imageHeight[imageHeight.Count - 1];
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(SystemColors.AppWorkspace);

            foreach (String file in files)
            {
                Image img = Image.FromFile(file);
                if (nIndex == 0)
                {
                    g.DrawImage(img, new Point(0, 0));
                    nIndex++;
                    width = img.Width;
                }
                else
                {
                    //Concatenate image horizontally
                    g.DrawImage(img, new Point(width, 0));
                    width += img.Width;
                }
                img.Dispose();
            }
            g.Dispose();
            bmp.Save(outputFile, System.Drawing.Imaging.ImageFormat.Jpeg);
            bmp.Dispose();
            wordPicbox.ImageLocation = outputFile;
            this.wordPicbox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //Plays the concatenated phonics words, this is for teacher's to test if it sounds good or not !
        private void testWordBtn_Click(object sender, EventArgs e)
        {
            if (wordLabel.Text.Length > 0)
            {
                String word = wordLabel.Text;
                String filename = @"PhonicsWord_Audio\" + word + ".wav";
                DisposeWave();

                wave = new NAudio.Wave.WaveFileReader(filename);
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(new NAudio.Wave.WaveChannel32(wave));
                output.Play();
            }
            else
            {
                MessageBox.Show("Word isn't created yet !");
            }
        }

        //Dispose the wave
        private void DisposeWave()
        {
            if (output != null)
            {
                //If it's still playing, stop
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Stop();
                }
                output.Dispose();
                output = null;
            }
            if (wave != null)
            {
                wave.Dispose();
                wave = null;
            }
        }

        //Clears the word
        private void clearWordBtn_Click(object sender, EventArgs e)
        {
            wordLabel.Text = null;
            wordPicbox.Image = null;
        }

        //Inserts the audio and image into the Word Bank table
        private void submitWordBtn_Click(object sender, EventArgs e)
        {
            String filename = "PhonicsWord_Image\\" + wordLabel.Text + ".jpg";
            String filename2 = "PhonicsWord_Audio\\" + wordLabel.Text + ".wav";

            if (!File.Exists(filename) && !File.Exists(filename2))
            {
                MessageBox.Show("Word isn't created yet !");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                MySqlCommand cmd;
                BinaryReader br, br2;
                FileStream fs, fs2;

                try
                {
                    byte[] ImageData;
                    byte[] AudioData;

                    fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    fs2 = new FileStream(filename2, FileMode.Open, FileAccess.Read);
                    br2 = new BinaryReader(fs2);
                    AudioData = br2.ReadBytes((int)fs2.Length);
                    br2.Close();
                    fs2.Close();

                    String cmdString = "INSERT INTO wordbank_db(Word, Image, Audio) VALUES (@Word, @Image, @Audio)";
                    cmd = new MySqlCommand(cmdString, connection);
                    cmd.Parameters.AddWithValue("@Word", wordLabel.Text + ";");
                    cmd.Parameters.AddWithValue("@Image", ImageData);
                    cmd.Parameters.AddWithValue("@Audio", AudioData);
                    connection.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Word added!");
                        wordLabel.Text = null;
                        wordPicbox.Image = null;
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
        }


        //private void downloadAudio(String connStr)
        //{
        //    letters = new List<String>();
        //    MySqlConnection connection = new MySqlConnection(connStr);
        //    MySqlDataReader reader;
        //    connection.Open();

        //    try
        //    {
        //        String audioName;
        //        MySqlCommand cmd = connection.CreateCommand();
        //        cmd.CommandText = "SELECT PhonicsName, Audio FROM audio_db";
        //        FileStream fs;
        //        BinaryWriter bw;
        //        int bufferSize = 1024;
        //        byte[] AudioData = new byte[bufferSize];
        //        long nBytesReturned, startIndex = 0;

        //        reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
        //        if (!Directory.Exists("Audio"))
        //        {
        //            Directory.CreateDirectory("Audio");
        //        }

        //        while (reader.Read())
        //        {
        //            audioName = reader.GetString(0);
        //            // storing the letters based on the amount of audio files available
        //            letters.Add(audioName); 
        //            fs = new FileStream("Audio\\" + audioName.ToString() + ".wav", FileMode.OpenOrCreate, FileAccess.Write);
        //            bw = new BinaryWriter(fs);
        //            startIndex = 0;
        //            nBytesReturned = reader.GetBytes(1, startIndex, AudioData, 0, bufferSize);
        //            while (nBytesReturned == bufferSize)
        //            {
        //                bw.Write(AudioData);
        //                bw.Flush();
        //                startIndex += bufferSize;
        //                nBytesReturned = reader.GetBytes(1, startIndex, AudioData, 0, bufferSize);
        //            }
        //            bw.Write(AudioData, 0, (int)nBytesReturned - 1);
        //            bw.Close();
        //            fs.Close();
        //        }
        //        reader.Close();
        //    }
        //    catch(Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if(connection.State == ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        //private void downloadImages(String connStr)
        //{
        //    MySqlConnection connection = new MySqlConnection(connStr);
        //    MySqlDataReader reader;
        //    connection.Open();
        //    try
        //    {
        //        String imgName;
        //        MySqlCommand cmd = connection.CreateCommand();
        //        cmd.CommandText = "SELECT PhonicsName, Image FROM image_db";
        //        FileStream fs;
        //        BinaryWriter bw;
        //        int bufferSize = 1024;
        //        byte[] ImageData = new byte[bufferSize];
        //        long nBytesReturned, startIndex = 0;

        //        reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
        //        if (!Directory.Exists("Images"))
        //        {
        //            Directory.CreateDirectory("Images");
        //        }

        //        while (reader.Read())
        //        {
        //            imgName = reader.GetString(0);
        //            fs = new FileStream("Images\\" + imgName.ToString() + ".jpg", FileMode.OpenOrCreate, FileAccess.Write);
        //            bw = new BinaryWriter(fs);
        //            startIndex = 0;
        //            nBytesReturned = reader.GetBytes(1, startIndex, ImageData, 0, bufferSize);
        //            while (nBytesReturned == bufferSize)
        //            {
        //                bw.Write(ImageData);
        //                bw.Flush();
        //                startIndex += bufferSize;
        //                nBytesReturned = reader.GetBytes(1, startIndex, ImageData, 0, bufferSize);
        //            }
        //            bw.Write(ImageData, 0, (int)nBytesReturned - 1);
        //            bw.Close();
        //            fs.Close();
        //        }
        //        reader.Close();
        //    }
        //    catch(Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if(connection.State == ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

    }
}
