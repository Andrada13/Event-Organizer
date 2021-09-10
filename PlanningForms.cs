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
    public partial class PlanningForms : Form
    {
        public PlanningForms()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Remove(listBoxEvents.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxBdays.Items.Remove(listBoxBdays.SelectedItem);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (listBoxEvents.Items.Contains(textBoxName.Text))
            {
                textBoxName.Clear();
                MessageBox.Show("This name already exists!");
            }
            else
            {
                listBoxEvents.Items.Add(textBoxName.Text);
                textBoxName.Clear();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
            if (listBoxBdays.Items.Contains(textBoxDesc.Text))
            {
                textBoxDesc.Clear();
                MessageBox.Show("This b-day already exists!");
            }
            else
            {
                listBoxBdays.Items.Add(textBoxDesc.Text);
                textBoxDesc.Clear();
            }



        }

     

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            const string sPath = "save.txt";
            const string sPath1 = "save1.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBoxEvents.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.ToString();
            SaveFile.Close();
            System.IO.StreamWriter SaveFile1 = new System.IO.StreamWriter(sPath1);
            foreach (var item in listBoxBdays.Items)
            {
                SaveFile1.WriteLine(item.ToString());
            }

            SaveFile1.ToString();
            SaveFile1.Close();
          
        }

        private void PlanningForms_Load(object sender, EventArgs e)
        {

        }
    }
}
