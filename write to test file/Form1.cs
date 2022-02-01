using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//imported stuff
using System.IO;

namespace write_to_test_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This is the name o the file
        //The file is created in the project folder in the bin in debug but can be created in a spesific area using the following format C:\User\(Username)\(area)\(filename) 
        public string fileName = "WriteFile.txt";
        private void Fill_Comb_Box() {
            //prevents the same items being loaded into your comboboxes
            comboBox1.Items.Clear();

            //Creates the reader  to whole document
            using (StreamReader streamReader = new StreamReader(fileName)) {
                //Retrieves all the text in the file & stores it in a string
                string s = streamReader.ReadToEnd();

                //divides the preives string into a seious of substrings & stores them in this array
                //The ~ is what allows the split method to differentate between the different substrings
                string[] sArray = s.Split('~');

                //Scans all the lines in the document & prevents a blank line at the end of the combobox
                for (int j = 0; j < (sArray.Length - 1); j++) {
                    comboBox1.Items.Add(sArray[j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            //This writes text into the text file
            // creates the stream writer object & selects the text file to write too
            using (StreamWriter outputFile = new StreamWriter(fileName, true)) {
                //Here is were your sentance is decited
                outputFile.WriteLine(textBox1.Text + "~");
            }
            Fill_Comb_Box();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Fill_Comb_Box();
        }

        private void button2_Click(object sender, EventArgs e) {
            //reads the whole file & rewrites the file execept the selected text
            string s = "";

            using (StreamReader streamReader = new StreamReader(fileName)) {
                s = streamReader.ReadToEnd();
            }
            
            string cleanString = s.Trim();
            string[] sArray = cleanString.Split('~');
            bool found = false;

            using (StreamWriter outputFile = new StreamWriter(fileName)) {
                for (int j = 0; j < (sArray.Length); j++) {
                    //writes all the data from the array as long as they dont match the selected item
                    if (sArray[j] != comboBox1.Text && found == false) {
                        outputFile.Write(sArray[j] + "~");
                    }
                    //writes text from the text box into the text file
                    else if (found == false) {
                        outputFile.Write(textBox1.Text + "~");
                        found = true;
                    }
                    //continues writing after the first instance is edited
                    else if (sArray[j].Length > 1) {
                        outputFile.Write(sArray[j] + "~");
                    }
                }
            }
            comboBox1.Text = "";
            Fill_Comb_Box();
        }

        private void Delete_Text_Click(object sender, EventArgs e)
        {
            string s = "";

            using (StreamReader streamReader = new StreamReader(fileName)) {
                s = streamReader.ReadToEnd();
            }

            string cleanString = s.Trim();
            string[] sArray = cleanString.Split('~');
            bool found = false;

            using (StreamWriter outputFile = new StreamWriter(fileName)) {
                for (int j = 0; j < (sArray.Length); j++) {
                    if (sArray[j] != comboBox1.Text && found == false) {
                        outputFile.Write(sArray[j] + "~");
                    }
                    //Nothing is writen
                    else if (found == false) {
                        found = true;
                    }
                    else if (sArray[j].Length > 1) {
                        outputFile.Write(sArray[j] + "~");
                    }
                }
            }
            comboBox1.Text = "";
            Fill_Comb_Box();
        }

        bool editingOrEntering = true;
        private void comboBox1_Click(object sender, EventArgs e)
        {
            //Sololy for user convinice
            if (editingOrEntering) {
                label2.Text = "Edit here";
                editingOrEntering = false;
            }
            else {
                label2.Text = "Write here";
                editingOrEntering = true;
            }
        }
    }
}