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
    public partial class Location : Form
    {
   
        public Location()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
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
                    listBoxLocation.Items.Add(line);
                }
                file.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String description, address;
            description = textDescription.Text;
            address = textAddress.Text;
            String concatenation = description + " " + "-" + " " + address;
            


             if (listBoxLocation.Items.Contains(concatenation))
            {
                textDescription.Clear();
                textAddress.Clear();
                MessageBox.Show("This location already exists!");
            }
            else
            {
                listBoxLocation.Items.Add(concatenation);
                textDescription.Clear();
                textAddress.Clear();
                
            }



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxLocation.Items.Remove(listBoxLocation.SelectedItem);
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
           
            this.Hide();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBoxLocation.SelectedItem.ToString();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index = listBoxLocation.SelectedIndex;
            listBoxLocation.Items.RemoveAt(index);

            listBoxLocation.Items.Insert(index, textBox1.Text);
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            const string sPath = "newLocation.txt";
           

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBoxLocation.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.ToString();
            SaveFile.Close();

         
        }
    }
}
