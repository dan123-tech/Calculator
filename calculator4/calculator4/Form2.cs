using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int i =int.Parse(textBox1.Text);    
            if(comboBox1.SelectedItem=="Rupees" && comboBox2.SelectedItem == "Dolar")
            {
                label6.Text =System.Convert.ToString(i* 0.014);
                    
            }
            if (comboBox1.SelectedItem == "Rupees" && comboBox2.SelectedItem == "Euro")
            {
                label6.Text = System.Convert.ToString(i *0.013);
            }
            if (comboBox1.SelectedItem == "Rupees" && comboBox2.SelectedItem == "Lei")
            {
                label6.Text = System.Convert.ToString(i * 0.060);
            }
            if (comboBox1.SelectedItem == "Dolar" && comboBox2.SelectedItem == "Rupees")
            {
                label6.Text = System.Convert.ToString(i * 69.64);
            }
            if (comboBox1.SelectedItem == "Dolar" && comboBox2.SelectedItem == "Euro")
            {
                label6.Text = System.Convert.ToString(i * 69.64);
            }
            if (comboBox1.SelectedItem == "Dolar" && comboBox2.SelectedItem == "Lei")
            {
                label6.Text = System.Convert.ToString(i * 4.17);
            }
            if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "Rupees")
            {
                label6.Text = System.Convert.ToString(i * 78.81);
            }
            if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "Dolar")
            {
                label6.Text = System.Convert.ToString(i * 1.13);
            }
            if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "Lei")
            {
                label6.Text = System.Convert.ToString(i * 4.72);
            }
            if (comboBox1.SelectedItem == "Lei" && comboBox2.SelectedItem == "Rupees")
            {
                label6.Text = System.Convert.ToString(i * 16.68);
            }
            if (comboBox1.SelectedItem == "Lei" && comboBox2.SelectedItem == "Dolar")
            {
                label6.Text = System.Convert.ToString(i * 0.24);
            }
            if (comboBox1.SelectedItem == "Lei" && comboBox2.SelectedItem == "Euro")
            {
                label6.Text = System.Convert.ToString(i * 0.21);
            }
            if(comboBox1.SelectedItem=="Lei Md" && comboBox2.SelectedItem == "Lei")
            {
                label6.Text = System.Convert.ToString(i * 0.23);
            }
            if (comboBox1.SelectedItem == "Lei Md" && comboBox2.SelectedItem == "Euro")
            {
                label6.Text = System.Convert.ToString(i * 0.048);
            }
            if (comboBox1.SelectedItem == "Lei Md" && comboBox2.SelectedItem == "Rupees")
            {
                label6.Text = System.Convert.ToString(i * 3.83);

            }
            if (comboBox1.SelectedItem == "Lei Md" && comboBox2.SelectedItem == "Dolar")
            {
                label6.Text = System.Convert.ToString(i* 0.055);

            }
            if(comboBox1.SelectedItem=="Lei" && comboBox2.SelectedItem=="Lei Md")
            {
                label6.Text = System.Convert.ToString(i * 4.37);
            }
            if (comboBox1.SelectedItem == "Rupees" && comboBox2.SelectedItem == "Lei Md")
            {
                label6.Text = System.Convert.ToString(i * 0.26);
            }
            if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "Lei Md")
            {
                label6.Text = System.Convert.ToString(i * 20.71);
            }
            if (comboBox1.SelectedItem == "Dolar" && comboBox2.SelectedItem == "Lei Md")
            {
                label6.Text = System.Convert.ToString(i * 18.18);
            }
            if(comboBox1.SelectedItem=="Lira" && comboBox2.SelectedItem == "Lei")
            {
                label6.Text = System.Convert.ToString(i * 0.71);
            }
            if (comboBox1.SelectedItem == "Lira" && comboBox2.SelectedItem == "Lei Md")
            {
                label6.Text = System.Convert.ToString(i * 3.12);
            }
            if (comboBox1.SelectedItem == "Lira" && comboBox2.SelectedItem == "Euro")
            {
                label6.Text = System.Convert.ToString(i * 0.15);
            }
            if (comboBox1.SelectedItem == "Lira" && comboBox2.SelectedItem == "Dolar")
            {
                label6.Text = System.Convert.ToString(i * 0.17);

            }
            if (comboBox1.SelectedItem == "Lira" && comboBox2.SelectedItem == "Rupees")
            {
                label6.Text = System.Convert.ToString(i * 11.95);

            }
            if (comboBox1.SelectedItem == "Lei" && comboBox2.SelectedItem == "Lira")
            {
                label6.Text = System.Convert.ToString(i * 1.40);
            }
            if (comboBox1.SelectedItem == "Lei Md" && comboBox2.SelectedItem == "Lira")
            {
                label6.Text = System.Convert.ToString(i * 0.32);
            }
            if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "Lira")
            {
                label6.Text = System.Convert.ToString(i * 6.63);
            }
            if (comboBox1.SelectedItem == "Rupees" && comboBox2.SelectedItem == "Lira")
            {
                label6.Text = System.Convert.ToString(i * 6.63);
            }
            if (comboBox1.SelectedItem == "Dolar" && comboBox2.SelectedItem == "Lira")
            {
                label6.Text = System.Convert.ToString(i * 0.084);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        
    }
}
