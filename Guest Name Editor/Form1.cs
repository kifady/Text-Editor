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
using System.Windows;

namespace Guest_Name_Editor
    {
    public partial class Form1 : Form
        {
        string filePath, originalText;
        string[] textArray;
        List<string> newText = new List<string>();
        bool clear = false;
        string beforeT, afterT;

        public Form1()
            {
            InitializeComponent();
            }


        private void label1_Click(object sender, EventArgs e)
            {
            }

        private void button1_Click(object sender, EventArgs e)
            {
            string[] originalTextArray;
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a text file (.txt)";
            openFileDialog.Filter = "Text Files|*.txt";
            DialogResult result = openFileDialog.ShowDialog();
            if (result==DialogResult.OK)
                {
                newTextBox.Clear();
                originalTextBox.Clear();
                clear = false;
                pathTextBox.Text = openFileDialog.FileName;
                filePath = openFileDialog.FileName;
                StreamReader reader = new StreamReader(filePath, System.Text.Encoding.Unicode);
                originalTextBox.Text = reader.ReadToEnd();
                textArray = TextReader();
                originalTextArray = newText.ToArray();
                }
            }
        
        private void Clear(string[] array)
            {
            for(int i=0;i<array.Length;i++)
                {
                array[i]=null;
                }
            }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
            {
            }

        private string[] TextReader()
            {
            List<string> newText = new List<string>();
            StreamReader reader = new StreamReader(filePath, System.Text.Encoding.Unicode);
            using (reader)
                {
                string currentLine;
                while ((currentLine = reader.ReadLine()) != null)
                    {
                    if (currentLine != "")
                        {
                        newText.Add(currentLine);
                        }
                    }
                }
                reader.Close();
            return newText.ToArray();
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void convertButton_Click(object sender, EventArgs e)
            {
            List<string> newText = new List<string>();
            if (!clear)
                {
                textArray = TextReader();
                string tempString="";
                for (int i = 0; i < textArray.Length; i++)
                    {
                    if (beforeT == "")
                        {
                        textArray[i] = textArray[i] + " " + afterT;
                        }
                    else if (afterT == "")
                        {
                        textArray[i] = beforeT + " " + textArray[i];
                        }
                    else if (beforeT == "" && afterT == "")
                        {
                        textArray[i] = textArray[i];
                        }
                    else
                        {
                        textArray[i] = beforeT + " " + textArray[i] + " " + afterT;
                        }
                    tempString = tempString + Environment.NewLine + textArray[i];
                    }
                tempString = tempString.Replace("  ", " ");
                newTextBox.Text = tempString;
                }
            else newTextBox.Text = "Please select a new file - you cleared the old one.";
            }

        private void clearButton_Click(object sender, EventArgs e)
            {
            Clear();
            }

        private void Clear()
            {
            clear = true;
            originalTextBox.Clear();
            newTextBox.Clear();
            beforeT = ""; beforeText.Text = "";
            afterT = ""; afterText.Text = "";
            pathTextBox.Clear();
            for(int i = 0; i < textArray.Length; i++)
                {
                textArray[i] = null;
                }
            }

        private void saveButton_Click(object sender, EventArgs e)
            {
            saveFileDialog.Title = "Save as a text file (.txt)";
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.ShowDialog();
            string savePath = saveFileDialog.FileName;
          //  string temp = "";
            StreamWriter writer = new StreamWriter(savePath);
            if (File.Exists(savePath))
                {
                using (writer)
                    {
                    for (int i = 0; i < textArray.Length; i++)
                        {
                        writer.WriteLine(textArray[i]);
                        // temp = temp + textArray[i] + Environment.NewLine;
                        }
                    
                   // File.WriteAllText(savePath, temp, System.Text.Encoding.Unicode);
                    }
                }
           // File.WriteAllLines(savePath, textArray, System.Text.Encoding.Unicode);
            }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
            {

            }

        private void beforeText_TextChanged(object sender, EventArgs e)
            {

            }

        private void setButton_Click(object sender, EventArgs e)
            {
            beforeT = beforeText.Text;
            afterT = afterText.Text;
            }

        private void afterText_TextChanged(object sender, EventArgs e)
            {
            

            }

        private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }







/*    StreamReader reader = new StreamReader(filePath, System.Text.Encoding.Unicode);
using (reader)
  {
  string currentLine;
  while ((currentLine = reader.ReadLine()) != null)
      {
      newText.Add(currentLine);
      }
  }
reader.Close();
newTextArray = newText.ToArray();*/
/* 
       List<string>  originalList = new List<string>();
       using (reader)
           {
           string currentLine;
           while ((currentLine = reader.ReadLine()) != null)
               {
               originalList.Add(currentLine);
               }
           }
       reader.Close();*/
