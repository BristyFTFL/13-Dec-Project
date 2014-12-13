using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookUIHashtableApp
{
    public partial class BookInfoUI : Form
    {
        public BookInfoUI()
        {
            InitializeComponent();
        }

        private Hashtable bookInfo = new Hashtable();

        private void addButton_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(isbnToAddTextBox.Text) == true)
            {
                MessageBox.Show("Already added ISBN");
            }
            else
            {
                bookInfo.Add(isbnToAddTextBox.Text, detailsToAddTextBox.Text);
                MessageBox.Show("Information has been added");
            }
            isbnToAddTextBox.Clear();
            detailsToAddTextBox.Clear();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(isbnToSearchTextBox.Text))
            {
                string bookDetails = (string) bookInfo[isbnToSearchTextBox.Text];
                detailsToSearchTextBox.Text = bookDetails;
               
            }
            else
            {
                MessageBox.Show("There is no Book with your given ISBN");
            }
            

        }
    }
}
