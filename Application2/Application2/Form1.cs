using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Application2
{
    public partial class Form1 : Form
    {
        // Having the intial set for 2 buttons to be checked
        // the listview be a small view
        // The delete and edit button are disabled by default
        public Form1()
        {
            InitializeComponent();
            radioButton4.Checked = true;
            radioButton1.Checked = true;
            listView1.View = View.SmallIcon;
            button2.Enabled = false;
            button3.Enabled = false;

            
        }

        // boolean method that takes a string to make sure it is only digits in the string
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        // regular expression used to make sure the string is only alphabetical 
        Regex r = new Regex("^[a-zA-Z]+$");

        // Method used to make sure the string for the email is a valid email format.
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // creating a new Contacts object
        public Contacts contact
        {
            get
            {
                Contacts c = new Contacts();
                c.FirstName = txtBoxFname.Text;
                c.LastName = txtBoxLname.Text;
                c.PhoneNumber = txtBoxNumber.Text;
                c.Email = txtBoxEmail.Text;
                    if (radioButton1.Checked)
                    {
                        c.ImageIndex = radioButton1.ImageIndex;
                    } else if (radioButton2.Checked)
                    {
                        c.ImageIndex = radioButton2.ImageIndex;
                    } else if (radioButton3.Checked)
                    {
                        c.ImageIndex = radioButton3.ImageIndex;
                    }
                return c;
            }
            set
            {
                txtBoxFname.Text = value.FirstName;
                txtBoxLname.Text = value.LastName;
                txtBoxNumber.Text = value.PhoneNumber;
                txtBoxEmail.Text = value.Email;
            }
        }
        // exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // adds the contact to the listview
        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            //checks to make sure all the fields are correct before adding it to the list view.
            if (IsDigitsOnly(txtBoxNumber.Text) && r.IsMatch(txtBoxFname.Text) && r.IsMatch(txtBoxLname.Text) && IsValidEmail(txtBoxEmail.Text))
            {
                lvi.Text = contact.ToString();
                lvi.ImageIndex = contact.ImageIndex;

                lvi.Tag = contact;
                listView1.Items.Add(lvi);

                txtBoxNumber.BackColor = Color.White;
                txtBoxFname.BackColor = Color.White;
                txtBoxLname.BackColor = Color.White;
                txtBoxEmail.BackColor = Color.White;

                txtBoxFname.Text = "";
                txtBoxLname.Text = "";
                txtBoxNumber.Text = "";
                txtBoxEmail.Text = "";
            }
            else if (!r.IsMatch(txtBoxFname.Text))
            {
                txtBoxFname.BackColor = Color.Pink;
            }
            else if (!r.IsMatch(txtBoxLname.Text))
            {
                txtBoxLname.BackColor = Color.Pink;
            }
            else if (!IsDigitsOnly(txtBoxNumber.Text))
            {
                txtBoxNumber.BackColor = Color.Pink;
            }
            else if (!IsValidEmail(txtBoxEmail.Text))
            {
                txtBoxEmail.BackColor = Color.Pink;
            }
            // feedback is turning the box pink if it is wrong
        }
        // switch to a small view or small view here.
        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.View = View.LargeIcon;
        }
        // loops through the items in the list view and if it is selected, removes it
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }

            button2.Enabled = false;
        }
        // makes the buttons usable for the user if they select an item
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            //textBox1.Text = ((Contacts)listView1.Items[0]).Firstname;
            //textBox2.Text = contact.LastName;
            //textBox3.Text = contact.PhoneNumber;
            //textBox4.Text = contact.Email;
            
        }
        // to update we loop through the items in the list
        // if it is selected, we then make that information on that item what we have inside our text boxes.
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    if (IsDigitsOnly(txtBoxNumber.Text) && r.IsMatch(txtBoxFname.Text) && r.IsMatch(txtBoxLname.Text) && IsValidEmail(txtBoxEmail.Text))
                    {
                        if (listView1.Items[i].Selected)
                        {
                            listView1.Items[i].Text = contact.ToString();
                            listView1.Items[i].ImageIndex = contact.ImageIndex;
                        }

                        txtBoxNumber.BackColor = Color.White;
                        txtBoxFname.BackColor = Color.White;
                        txtBoxLname.BackColor = Color.White;
                        txtBoxEmail.BackColor = Color.White;

                        txtBoxFname.Text = "";
                        txtBoxLname.Text = "";
                        txtBoxNumber.Text = "";
                        txtBoxEmail.Text = "";
                    }
                    else if (!r.IsMatch(txtBoxFname.Text))
                    {
                        txtBoxFname.BackColor = Color.Pink;
                    }
                    else if (!r.IsMatch(txtBoxLname.Text))
                    {
                        txtBoxLname.BackColor = Color.Pink;
                    }
                    else if (!IsDigitsOnly(txtBoxNumber.Text))
                    {
                        txtBoxNumber.BackColor = Color.Pink;
                    }
                    else if (!IsValidEmail(txtBoxEmail.Text))
                    {
                        txtBoxEmail.BackColor = Color.Pink;
                    }

                }
            }
            // same checks as before to make sure that we are able to not use these buttons after.
            button3.Enabled = false;
            button2.Enabled = false;
        }
    }
}
