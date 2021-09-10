using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading; 
using System.Globalization; 

namespace TeamEvent
{
    public partial class EditEvent : Form
    {
       
        public EditEvent()
        {
           
            InitializeComponent();
            label8.Hide();
            textBox1.Hide();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

    

        //add to calendar button
        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Outlook.Application outlookApplication = new Microsoft.Office.Interop.Outlook.Application(); ;
            Microsoft.Office.Interop.Outlook.AppointmentItem newAppointment = (Microsoft.Office.Interop.Outlook.AppointmentItem)outlookApplication.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem);
            String subject, locationMeet, startTime, bodyMeet;

           newAppointment.MeetingStatus = Microsoft.Office.Interop.Outlook.OlMeetingStatus.olMeeting;

           

            subject = comboBox1.Text;
            newAppointment.Subject = subject;

            locationMeet = comboBox3.Text;
            newAppointment.Location = locationMeet;

            bodyMeet = comboBox2.Text + "\nFood and Drinks : " + comboBox5.Text + " " + textBox1.Text;
            newAppointment.Body = bodyMeet;

            startTime = dateTimePicker12.Text;
            string startHour = dateTimePicker2.Text;
        
            newAppointment.Start = DateTime.Parse(startTime);
            newAppointment.Start = DateTime.Parse(startHour);
            newAppointment.AllDayEvent = false;


            foreach (string participant in checkedListBox2.CheckedItems)
            {
                    newAppointment.Recipients.Add(participant);
            }
            foreach (string participant1 in checkedListBox1.CheckedItems)
            {
                newAppointment.Recipients.Add(participant1);
            }
                newAppointment.Save();
            newAppointment.Display(true);

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;

            string subjectInput, bodyInput;
            MailMessage message = new MailMessage();
         
            bodyInput = comboBox2.Text;
            subjectInput = comboBox1.Text;

            message.Body = "Event : " + bodyInput + "\nDate : " + DateTime.Parse(startTime) + "\nFood and Drinks : " + comboBox5.Text + " " + textBox1.Text + "Location : " + locationMeet;

            message.Subject = subjectInput;
            message.IsBodyHtml = true;

            foreach (string Email in checkedListBox2.CheckedItems)
            {

                message.To.Add(new MailAddress(Email));
               
            }

            foreach (string Email1 in checkedListBox1.CheckedItems)
            {
                message.To.Add(new MailAddress(Email1));
            }


           


            System.IO.StreamReader file = new System.IO.StreamReader("saveEmail.txt");
            string line;
            string from = "";
            while ((line = file.ReadLine()) != null)
            { 
                from = line;
                message.From = new MailAddress(from);
            }
            file.Close();


          
            string p = Global.passwordGlobal;


            SmtpClient smtp2 = new SmtpClient("smtp.gmail.com");
            smtp2.EnableSsl = true;
            smtp2.Port = 587;
            smtp2.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp2.Credentials = new NetworkCredential(from, p);



            try
            {
                smtp2.Send(message);
                //DialogResult code = MessageBox.Show("Email Sent Successfully", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);


               // if (code == DialogResult.OK)
               // {

                   // checkedListBox1.Items.Clear();
                   // checkedListBox2.Items.Clear();
                   // comboBox3.Items.Clear();
                   // comboBox5.Items.Clear();
                    //textBox1.Clear();


               // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                System.IO.StreamReader file = new System.IO.StreamReader("save.txt");
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        comboBox2.Items.Add(line);

                    }
                    file.Close();

                checkedListBox1.Items.Clear();
                System.IO.StreamReader file1 = new System.IO.StreamReader("saveMembers.txt");
                string line1;
                while ((line1 = file1.ReadLine()) != null)
                {
                    checkedListBox1.Items.Add(line1);
                }
                file1.Close();
                

                checkedListBox2.Items.Clear();
                System.IO.StreamReader file2 = new System.IO.StreamReader("saveGroups.txt");
                string line2;
                while ((line2 = file2.ReadLine()) != null)
                {
                    checkedListBox2.Items.Add(line2);
                }
                file2.Close();

                comboBox3.Items.Clear();
                System.IO.StreamReader file3 = new System.IO.StreamReader("newLocation.txt");
                string line3;
                while ((line3 = file3.ReadLine()) != null)
                {
                    comboBox3.Items.Add(line3);
                }
                file3.Close();
                return;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                System.IO.StreamReader file = new System.IO.StreamReader("save1.txt");
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    comboBox2.Items.Add(line);
                }
                file.Close();
                checkedListBox1.Items.Clear();
                System.IO.StreamReader file1 = new System.IO.StreamReader("saveMembers.txt");
                string line1;
                while ((line1 = file1.ReadLine()) != null)
                {
                    checkedListBox1.Items.Add(line1);
                }
                file1.Close();

                checkedListBox2.Items.Clear();
                System.IO.StreamReader file2 = new System.IO.StreamReader("saveGroups.txt");
                string line2;
                while ((line2 = file2.ReadLine()) != null)
                {
                    checkedListBox2.Items.Add(line2);
                }
                file2.Close();
                

                comboBox3.Items.Clear();
                System.IO.StreamReader file3 = new System.IO.StreamReader("newLocation.txt");
                string line3;
                while ((line3 = file3.ReadLine()) != null)
                {
                    comboBox3.Items.Add(line3);
                }
                file3.Close();
                return;
            }
            




        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
               
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox5.Text == "N/A(order at location)")
            {
                //label1.Show();
                label8.Hide();
               textBox1.Hide();
            }
            else if (comboBox5.Text == "Shopping list")
            {
                label8.Show();
               textBox1.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

