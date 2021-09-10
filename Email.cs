using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamEvent
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fromEmail_Enter(object sender, EventArgs e)
        {
            if (fromEmail.Text == "From :")
            {
                fromEmail.Clear();
                fromEmail.ForeColor = Color.FromArgb(0,0,0);

            }
        }

        private void fromEmail_Leave(object sender, EventArgs e)
        {

            if (fromEmail.Text == "")
            {

                fromEmail.ForeColor = Color.FromArgb(200, 200, 200);
                fromEmail.Text = "From :";

            }
        }

        private void listBoxEMail_Enter(object sender, EventArgs e)
        {
            if (listBoxEMail.Text == "listBoxEMail")
            {
                listBoxEMail.Items.Clear();
                listBoxEMail.ForeColor = Color.FromArgb(0,0,0);

            }
        }

        private void listBoxEMail_Leave(object sender, EventArgs e)
        {
            if (listBoxEMail.Text == "")
            {

                listBoxEMail.ForeColor = Color.FromArgb(200, 200, 200);
                listBoxEMail.Text = "listBoxEMail";

            }
        }

        private void subjectEmail_Enter(object sender, EventArgs e)
        {
            if (subjectEmail.Text == "Subject :")
            {
                subjectEmail.Clear();
                subjectEmail.ForeColor = Color.FromArgb(0,0,0);

            }
        }

        private void subjectEmail_Leave(object sender, EventArgs e)
        {
            if (subjectEmail.Text == "")
            {

                subjectEmail.ForeColor = Color.FromArgb(200, 200, 200);
                subjectEmail.Text = "Subject :";

            }
        }

        private void bodyEmail_Enter(object sender, EventArgs e)
        {
            if (bodyEmail.Text == "Body :")
            {
                bodyEmail.Clear();
                bodyEmail.ForeColor = Color.FromArgb(0,0,0);

            }
        }

        private void bodyEmail_Leave(object sender, EventArgs e)
        {
            if (bodyEmail.Text == "")
            {

                bodyEmail.ForeColor = Color.FromArgb(200,200,200);
                bodyEmail.Text = "Body :";

            }
        }


    

        private void textFile_Click(object sender, EventArgs e)
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
                    listBoxEMail.Items.Add(line);
                }
                file.Close();
            }
        }

        private void sendEmail_Click_1(object sender, EventArgs e)
        {
            string fromInput, toInput, subjectInput, bodyInput, password;
            MailMessage message = new MailMessage();
            fromInput = fromEmail.Text;
            password = "BarbieVampir1234";
            bodyInput = bodyEmail.Text;
            subjectInput = subjectEmail.Text;
           
            int status = validateEmail(fromEmail.Text);
            if (status == 0)
            {
                MessageBox.Show("Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (status == 1)
            {
                message.From = new MailAddress(fromInput);
                message.Body = "Message:" + bodyInput;
                message.Subject = subjectEmail.Text;
                message.IsBodyHtml = true;

                foreach (string Email in listBoxEMail.Items)
                {
                    message.To.Add(new MailAddress(Email));
                }

            }

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
          //  SmtpClient smtp = new SmtpClient("mail.server.com"); 
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromInput, password);


            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Email Sent Successfully", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                if (code == DialogResult.OK)
                {
                    fromEmail.Clear();
                    listBoxEMail.Items.Clear();
                    subjectEmail.Clear();
                    bodyEmail.Clear();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            int status = validateEmail(addEmail.Text);
            if (status == 0)
            {
                MessageBox.Show("Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (status == 1)
            {
                MessageBox.Show("Email added successfully. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxEMail.Items.Add(addEmail.Text);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxEMail.Items.Remove(listBoxEMail.SelectedItem);
        }

        private void addEmail_Enter(object sender, EventArgs e)
        {
            if (addEmail.Text == "Add Email")
            {
                addEmail.Clear();
                addEmail.ForeColor = Color.FromArgb(0,0,0);

            }
        }

        private void addEmail_Leave(object sender, EventArgs e)
        {
            if (addEmail.Text == "")
            {

                addEmail.ForeColor = Color.FromArgb(200,200,200);
                addEmail.Text = "Add Email";

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
