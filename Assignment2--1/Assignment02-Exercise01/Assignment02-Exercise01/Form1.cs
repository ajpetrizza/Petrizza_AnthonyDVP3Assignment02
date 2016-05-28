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

namespace Assignment02_Exercise01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxWant.Items.Add("Soda");
            listBoxNeed.Items.Add("Napkins");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is used to close the application.
            Application.Exit();
        }

        private void btnAddWant_Click(object sender, EventArgs e)
        {
            // You first want to grab the text from the box and add it to the list
            // you then set the text box to empty
            // Clear the selected indexes
            listBoxWant.Items.Add(textBoxWant.Text);
            textBoxWant.Text = "";
            listBoxWant.ClearSelected();
        }

        private void btnMoveToNeed_Click(object sender, EventArgs e)
        {
            // First do a check to see if an item is selected in first list
            // You then take the selected itema and add it to the second list
            // Clear the selected item and delete it
            if (listBoxWant.SelectedItem != null)
            {
                listBoxNeed.Items.Add(listBoxWant.SelectedItem);
                listBoxWant.Items.Remove(listBoxWant.Items[listBoxWant.SelectedIndex]);
            }
            listBoxWant.ClearSelected();
            textBoxWant.Text = "";
        }

        private void btnAddNeed_Click(object sender, EventArgs e)
        {
            // Grab the text from the second box and add it to the list
            // clear the text
            // clear the selected item
            listBoxNeed.Items.Add(textBox2.Text);
            textBox2.Text = "";
            listBoxNeed.ClearSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check the selected item is chosen on list 2
            // add the item to the first list
            // remove the item from the 2nd list and clear the selected fields
            if (listBoxNeed.SelectedItem != null)
            {
                listBoxWant.Items.Add(listBoxNeed.SelectedItem);
                listBoxNeed.Items.Remove(listBoxNeed.Items[listBoxNeed.SelectedIndex]);
            }
            listBoxNeed.ClearSelected();
            textBox2.Text = "";
        }

        private void btnDeleteWant_Click(object sender, EventArgs e)
        {
            // Check if the selected item is in listbox 1
            // remove the item form the list
            // clear the selected index
            // clear the text
            if (listBoxWant.SelectedItem != null)
            {
                listBoxWant.Items.Remove(listBoxWant.Items[listBoxWant.SelectedIndex]);
                listBoxWant.ClearSelected();
                textBox2.Text = "";
                textBoxWant.Text = "";
            } else
            // grabs the second item in the listbox2 and removs it
            // clear the selection
            // clear all the text
            {
                listBoxNeed.Items.Remove(listBoxNeed.Items[listBoxNeed.SelectedIndex]);
                listBoxNeed.ClearSelected();
                textBoxWant.Text = "";
                textBox2.Text = "";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a savefiledialog to write out to a file.
            // choose the type of file it will be
            // name the title of the save file dialog

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save a text file";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            // check to see if the dialog box is up
            {
                // make sure the the file name is not empty
                if (saveFileDialog1.FileName != null)
                {
                    // go through and write the name to the file
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                    foreach (String item in listBoxWant.Items)
                    {
                        sw.WriteLine(item + ": WANT");
                    }

                    foreach (String item2 in listBoxNeed.Items)
                    {
                        sw.WriteLine(item2 + ": NEED");
                    }
                    // Loop through each list and add them to the text file
                    // close the streamwriter.
                    sw.Close();
                }
            }
        }
    }
}
