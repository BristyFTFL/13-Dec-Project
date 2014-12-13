using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryUIApp
{
    public partial class DictionaryUI : Form
    {
        public DictionaryUI()
        {
            InitializeComponent();
        }

       

        private Dictionary<string, string> citizenInfo = new Dictionary<string, string>();

        

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool hasThisid = citizenInfo.ContainsKey(idForSearchTextBox.Text);
            if (hasThisid)
            {
                string detailsInfo = citizenInfo[idForSearchTextBox.Text];
                MessageBox.Show(detailsInfo);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (citizenInfo.ContainsKey(idToAddTextBox.Text) == true)
            {
                MessageBox.Show("ID already taken");
            }
            else
            {
                citizenInfo.Add(idToAddTextBox.Text, detailsTextBox.Text);
                MessageBox.Show("Information has been added");
            }
            idToAddTextBox.Clear();
            detailsTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string allInfo="";
            foreach (KeyValuePair<string,string> pair in citizenInfo )
            {
                allInfo += pair.Key + " " + pair.Value + "\n";
            }
            MessageBox.Show(allInfo);
        }
    }
}
