using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculator4.Properties;
using System.Data.SqlClient;

namespace calculator4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daniel\Documents\edata.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='"+username.Text+"'and Password'"+password.Text +"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                 void Regexp(string re, TextBox tb, PictureBox pc, Label lbl, string s)
                {
                    Regex regex = new Regex(re);
                    if (regex.IsMatch(tb.Text))
                    {
                        pc.Image = Properties.Resources.valid;
                        lbl.ForeColor = Color.Green;
                        lbl.Text = "valid" + s;
                    }
                    else
                    {
                        pc.Image = Properties.Resources.invalid;
                        lbl.ForeColor = Color.Red;
                        lbl.Text = s + "Invalid";
                    }
                    
                }
                Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", txt_email, pictureBox3, label7, "E-mail");
                Regexp(@"^([0-31]{2})\/([0-12]{2})\/([0-9]{4})$", textBox1, pictureBox4, label9, "Date ");
                Regexp(@"^(?=^.{ 8,}$)((?=.*\d)| (?=.*\W +))(? ![.\n])(?=.*[A - Z])(?=.*[a - z]).* $", password, pictureBox2, label6, "Password ");
                Regexp(@"^[a-zA-Z0-9]+$", username, pictureBox1, label5, "Username ");
            }




            
            

            if (label5.Text == "valid Username"&& label6.Text== "valid Password")
            {
                groupBox2.Visible = true;
                groupBox2.Location = new Point(23, 67);
                groupBox1.Visible = false;

            }
        }
        

        
    }
}
