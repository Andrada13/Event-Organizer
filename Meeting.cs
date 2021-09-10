using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office;
using Microsoft.Office.Interop.Outlook;
using System.Globalization;


namespace TeamEvent
{
    public partial class meeting : Form
    {
        public meeting()
        {
            InitializeComponent();
        }

       
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Microsoft.Office.Interop.Outlook.Application outlookApplication = new Microsoft.Office.Interop.Outlook.Application(); ;
            Microsoft.Office.Interop.Outlook.AppointmentItem newAppointment = (Microsoft.Office.Interop.Outlook.AppointmentItem)outlookApplication.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem);
            String subject, locationMeet, startTime, endTime, bodyMeet;
            //  double firstTextBoxNumber;
            // firstTextBoxNumber = double.Parse(textBox1.Text);
            string combo = comboBox1.Text;
            string combo1 = comboBox2.Text;
            // double combo1 = Convert.ToDouble(combo);
            subject = subj.Text;
            newAppointment.Subject = subject;

         
            string text = "";
            foreach (var item in listBoxLocations.Items)
            {
                text += item.ToString() + ","; 
            }
            listBoxLocations.Text = text;

            newAppointment.Location = text;

            bodyMeet = body.Text;
            newAppointment.Body = bodyMeet;

          
            startTime = dateTimePicker1.Text;
            endTime = dateTimePicker2.Text;

            //var selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            //MessageBox.Show(selected);

           

            //NumberFormatInfo formatProvider = new NumberFormatInfo();
            //formatProvider.NumberDecimalSeparator = ": ";
           // formatProvider.NumberGroupSeparator = ":";
           // formatProvider.NumberGroupSizes = new int[] { 2 };
            //Console.WriteLine("Converted Decimal value...");
           // double res = Convert.ToDouble(selected, formatProvider);
           // double res1 = Convert.ToDouble(combo1, formatProvider);
            

            // newAppointment.Start = DateTime.Now.AddHours(2);
            newAppointment.Start = Convert.ToDateTime(startTime);
            newAppointment.End = Convert.ToDateTime(endTime);



            // newAppointment.End = DateTime.Now.AddHours(3);
            newAppointment.AllDayEvent = false;
   
            foreach (string participant in listBoxNames.Items)
            {
               
                newAppointment.Recipients.Add(participant);
            }
            
            Microsoft.Office.Interop.Outlook.Recipients sentTo = newAppointment.Recipients;
            Microsoft.Office.Interop.Outlook.Recipient sentInvite = null;
            //sentInvite = sentTo.Add("Dragos Andrei");
            //sentInvite.Type = (int)Microsoft.Office.Interop.Outlook.OlMeetingRecipientType.olRequired;
           // sentInvite = sentTo.Add("Maria ");
           // sentInvite.Type = (int)Microsoft.Office.Interop.Outlook.OlMeetingRecipientType.olOptional;
            sentTo.ResolveAll();
            newAppointment.Save();
            newAppointment.Display(true);

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;

           
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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
                    listBoxLocations.Items.Add(line);
                }
                file.Close();
            }
        }

        private void addLocation_Click(object sender, EventArgs e)
        {
            listBoxLocations.Items.Add(addLocat.Text);
        }

        private void removeLocation_Click(object sender, EventArgs e)
        {
            listBoxLocations.Items.Remove(listBoxLocations.SelectedItem);
        }
        /*string AddSpacesToSentence(string text, bool preserveAcronyms)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                    if ((text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) ||
                        (preserveAcronyms && char.IsUpper(text[i - 1]) &&
                         i < text.Length - 1 && !char.IsUpper(text[i + 1])))
                        newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
            MessageBox.Show(newText.ToString());

        }
        */
       // private void button5_Click(object sender, EventArgs e)
       // {
            //AddSpacesToSentence("LiviuCosmin", true);
      //  }

        private void addPart_Click(object sender, EventArgs e)
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
                    string name= line.Substring(0, line.IndexOf('@')).Replace(".", " ");
                        listBoxNames.Items.Add(name);
                   
                }
                file.Close();
            }
        }
    }
}
