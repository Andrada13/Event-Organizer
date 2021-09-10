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

    
public partial class Login : Form
    {
        public Login()
        {
           
            InitializeComponent();
            // MessageBox.Show(textBoxEmail.Text);
          


        }


      

        private void button1_Click(object sender, EventArgs e)
        {
           

            int status = validateEmail(textBoxEmail.Text);
            if (status == 0)
            {
                MessageBox.Show("Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (status == 1) {
                const string sPath = "saveEmail.txt";
               
                Global.passwordGlobal = textBoxPass.Text;

                string emails = textBoxEmail.Text;
                


                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
          
                SaveFile.WriteLine(emails.ToString());


                SaveFile.ToString();
                SaveFile.Close();

              

                save();


                  //textBoxEmail.Clear();
              

                this.Hide();
                Home form = new Home();
                form.ShowDialog(this);



            }




       
    

        }

        

        void save()
        {
            if (checkBox1.Checked == true)
            {

                Properties.Settings.Default.email = textBoxEmail.Text;
                Properties.Settings.Default.Save();


            }
            else
                if (checkBox1.Checked == false)
            {
                Properties.Settings.Default.email = "";
                Properties.Settings.Default.Save();
                // textBoxEmail.Clear();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public int validateEmail(string email1)
        {
           
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (email1.Length > 0)
            {
                if (!rEMail.IsMatch(email1))
                {
                    
                    return 0;
                }
            }
           
            return 1;

           
        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
          //  textBoxEmail.Focus();
            if (Properties.Settings.Default.email != string.Empty)
            {
                textBoxEmail.Text = Properties.Settings.Default.email;
                

            }
           
        }
    }
}
