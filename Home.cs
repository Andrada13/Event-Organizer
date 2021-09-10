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
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
            
        }

     

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MembersGroups membersGroups = new MembersGroups();
            membersGroups.ShowDialog(this);

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            
           location.ShowDialog(this);
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
             PlanningForms planning = new PlanningForms();
            planning.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditEvent edit = new EditEvent();
            edit.ShowDialog(this);

           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Closing the application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

       
    }
}
