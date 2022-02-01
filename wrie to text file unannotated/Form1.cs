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


namespace wrie_to_text_file_unannotated
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string fileName = "WriteFile.txt";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Fill_Comb_Box()
        {
            comboBox1.Items.Clear();

            using (StreamReader streamReader = new StreamReader(fileName)) {
                string s = streamReader.ReadToEnd();
                string[] sArray = s.Split('~');

                for (int j = 0; j < (sArray.Length - 1); j++) {
                    comboBox1.Items.Add(sArray[j]);
                }
            }
        }

        private void Write_Text_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true)) {
                outputFile.WriteLine(textBox1.Text + "~");
            }
            Fill_Comb_Box();
        }

        private void Edit_Text_Click(object sender, EventArgs e)
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
                    } else if (found == false)
                    {
                        outputFile.Write(textBox1.Text + "~");
                        found = true;
                    } else if (sArray[j].Length > 1) {
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

        private void comboBox1_Click(object sender, EventArgs e) {
            if (editingOrEntering)
            {
                label2.Text = "Edit here";
                editingOrEntering = false;
            }
            else
            {
                label2.Text = "Write here";
                editingOrEntering = true;
            }
        }
    }
}
