using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOperationUIApp
{
    public partial class Form1 : Form
    {
        string selectPath = @"F:\Info.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string customer = customerInfoTextBox.Text;

            FileStream aFileStream = new FileStream(selectPath, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(customer);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(selectPath, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            nameListBox.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                string aCustomer = aStreamReader.ReadLine();
                nameListBox.Items.Add(aCustomer);
            }
            aStreamReader.Close();
            aFileStream.Close();
        }
    }
}
