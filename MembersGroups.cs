using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamEvent
{
    public partial class MembersGroups : Form
    {
        public MembersGroups()
        {
            InitializeComponent();
           
        }

        public int validateEmail(string email)
        {

            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (email.Length > 0)
            {
                if (!rEMail.IsMatch(email))
                {
                    return 0;
                }
            }
            return 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int status = validateEmail(textBox4.Text);
            if (status == 0)
            {
                MessageBox.Show("Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (status == 1)
            {
                if (listBoxMembers.Items.Contains(textBox4.Text))
                {
                    textBox4.Clear();
                    MessageBox.Show("This email already exists!");
                }
                else
                {
                    listBox.Items.Add(textBox4.Text);
                    String line = textBox4.Text;
                    string name = line.Substring(0, line.IndexOf('@')).Replace(".", " ");
                    listBoxMembers.Items.Add(name);
                    textBox4.Clear();

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string curItem = listBox.SelectedItem.ToString();
            string name = curItem.Substring(0, curItem.IndexOf('@')).Replace(".", " ");

          
            int index = listBoxMembers.FindString(name);
           
            if (index == -1)
                MessageBox.Show("Item is not available");
            else
                listBox.Items.Remove(curItem);
                listBoxMembers.Items.RemoveAt(index);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listBoxGroups.Items.Contains(textBox3.Text))
            {
                textBox3.Clear();
                MessageBox.Show("This group already exists!");
            }
            else
            {
                listBoxGroups.Items.Add(textBox3.Text);
                String line = textBox3.Text;
                string name = line.Substring(0, line.IndexOf('@')).Replace("dl_", " ");
                listBox2.Items.Add(name);
                textBox3.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string curItem = listBoxGroups.SelectedItem.ToString();
            string name = curItem.Substring(0, curItem.IndexOf('@')).Replace("dl_", " ");


            int index = listBox2.FindString(name);

            if (index == -1)
            {
                MessageBox.Show("Item is not available");
            }
            else
            {
                listBoxGroups.Items.Remove(curItem);
                listBox2.Items.RemoveAt(index);
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
           
                const string sPath = "saveMembers.txt";
            const string sPath1 = "saveGroups.txt";


            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                foreach (var item in listBox.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.ToString();
                SaveFile.Close();
          


            System.IO.StreamWriter SaveFile1 = new System.IO.StreamWriter(sPath1);
            foreach (var item in listBoxGroups.Items)
            {
                SaveFile1.WriteLine(item.ToString());
            }
            SaveFile1.ToString();
            SaveFile1.Close();

            
          
            }
     
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;

            DialogResult dr = openFile.ShowDialog();

            if (dr == DialogResult.OK)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@openFile.FileName);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    
                    listBox.Items.Add(line);
                   
                    string name = line.Substring(0, line.IndexOf('@')).Replace(".", " ");
                    listBoxMembers.Items.Add(name);
                }
                file.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;

            DialogResult dr = openFile.ShowDialog();

            if (dr == DialogResult.OK)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@openFile.FileName);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    listBoxGroups.Items.Add(line);

                    string name = line.Substring(0, line.IndexOf('@')).Replace("dl_", " ");
                    listBox2.Items.Add(name);
                }
                file.Close();
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

    }
}
