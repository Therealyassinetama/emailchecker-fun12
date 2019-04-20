using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_MAIL_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> domains = new List<string>(new string[] { "nl", "com", "edu" });

        public void check_email(string email)
        {
            bool at = false;
            bool point = false;
            bool point_after_at = false;
            bool domain = false;

            int index_point = 0;
            int index_at = 0;

            string substring = "";

            if(email.Contains("@"))
            {
                at = true;
                substring = email.Substring((email.IndexOf(".") + 1));
            }
            if(email.IndexOf(".") > email.IndexOf("@"))
            {
                point = true;
                point_after_at = true;
            }
            if (domains.Contains(substring))
            {
                domain = true;
            }

            if(at == true && point == true && point_after_at == true && domain == true)
            {
                MessageBox.Show("Eamil is vaild. Hackerman is in");
            }
            else
            {
                MessageBox.Show("try again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                check_email(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Vul iets in");
            }
        }
    }
}
