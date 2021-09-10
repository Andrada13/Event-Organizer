
namespace TeamEvent
{
    partial class Email
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.fromEmail = new System.Windows.Forms.TextBox();
            this.subjectEmail = new System.Windows.Forms.TextBox();
            this.bodyEmail = new System.Windows.Forms.TextBox();
            this.listBoxEMail = new System.Windows.Forms.ListBox();
            this.sendEmail = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Send Emails";
            // 
            // fromEmail
            // 
            this.fromEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.fromEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.fromEmail.Location = new System.Drawing.Point(56, 162);
            this.fromEmail.Multiline = true;
            this.fromEmail.Name = "fromEmail";
            this.fromEmail.Size = new System.Drawing.Size(245, 29);
            this.fromEmail.TabIndex = 1;
            this.fromEmail.Text = "From :";
            this.fromEmail.Enter += new System.EventHandler(this.fromEmail_Enter);
            this.fromEmail.Leave += new System.EventHandler(this.fromEmail_Leave);
            // 
            // subjectEmail
            // 
            this.subjectEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.subjectEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.subjectEmail.Location = new System.Drawing.Point(56, 432);
            this.subjectEmail.Multiline = true;
            this.subjectEmail.Name = "subjectEmail";
            this.subjectEmail.Size = new System.Drawing.Size(245, 32);
            this.subjectEmail.TabIndex = 1;
            this.subjectEmail.Text = "Subject :";
            this.subjectEmail.Enter += new System.EventHandler(this.subjectEmail_Enter);
            this.subjectEmail.Leave += new System.EventHandler(this.subjectEmail_Leave);
            // 
            // bodyEmail
            // 
            this.bodyEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.bodyEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bodyEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.bodyEmail.Location = new System.Drawing.Point(56, 483);
            this.bodyEmail.Multiline = true;
            this.bodyEmail.Name = "bodyEmail";
            this.bodyEmail.Size = new System.Drawing.Size(245, 85);
            this.bodyEmail.TabIndex = 1;
            this.bodyEmail.Text = "Body :";
            this.bodyEmail.Enter += new System.EventHandler(this.bodyEmail_Enter);
            this.bodyEmail.Leave += new System.EventHandler(this.bodyEmail_Leave);
            // 
            // listBoxEMail
            // 
            this.listBoxEMail.FormattingEnabled = true;
            this.listBoxEMail.Location = new System.Drawing.Point(56, 251);
            this.listBoxEMail.Name = "listBoxEMail";
            this.listBoxEMail.Size = new System.Drawing.Size(113, 82);
            this.listBoxEMail.TabIndex = 2;
            this.listBoxEMail.Enter += new System.EventHandler(this.listBoxEMail_Enter);
            this.listBoxEMail.Leave += new System.EventHandler(this.listBoxEMail_Leave);
            // 
            // sendEmail
            // 
            this.sendEmail.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmail.Location = new System.Drawing.Point(125, 585);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(91, 32);
            this.sendEmail.TabIndex = 3;
            this.sendEmail.Text = "Send Email";
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click_1);
            // 
            // textFile
            // 
            this.textFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFile.Location = new System.Drawing.Point(194, 310);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(107, 23);
            this.textFile.TabIndex = 4;
            this.textFile.Text = "Add Emails File";
            this.textFile.UseVisualStyleBackColor = true;
            this.textFile.Click += new System.EventHandler(this.textFile_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(56, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Email";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(153, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Remove Email";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addEmail
            // 
            this.addEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.addEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addEmail.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.addEmail.Location = new System.Drawing.Point(56, 354);
            this.addEmail.Multiline = true;
            this.addEmail.Name = "addEmail";
            this.addEmail.Size = new System.Drawing.Size(245, 23);
            this.addEmail.TabIndex = 7;
            this.addEmail.Text = "Add Email";
            this.addEmail.Enter += new System.EventHandler(this.addEmail_Enter);
            this.addEmail.Leave += new System.EventHandler(this.addEmail_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email list :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(308, -1);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(46, 21);
            this.exitbtn.TabIndex = 9;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(279, 625);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Email
            // 
            this.ClientSize = new System.Drawing.Size(353, 648);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.listBoxEMail);
            this.Controls.Add(this.bodyEmail);
            this.Controls.Add(this.subjectEmail);
            this.Controls.Add(this.fromEmail);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.ListBox listBoxEMails;
        private System.Windows.Forms.Button buttonTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromEmail;
        private System.Windows.Forms.TextBox subjectEmail;
        private System.Windows.Forms.TextBox bodyEmail;
        private System.Windows.Forms.ListBox listBoxEMail;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.Button textFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox addEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button button4;
    }
}