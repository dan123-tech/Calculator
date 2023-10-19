using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace calculator4
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        String firstNum, secondnum;
        float iChelsius, iKevin, iFahrenheit;
         double kilometer, meter, feet, inches, centimeter;
        double kilo,gram,liter,mili;
        char ioperation,ioperation1;
        Form2 f2;
        Form3 f3;   
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender , EventArgs e)
        {
            if ((result.Text == "0")|| (operation_pressed ))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            if(b.Text==".")
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operetor_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation2.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation2.Text = value + " " + operation;

            }
            firstNum = equation2.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            secondnum = result.Text;
            equation2.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text) ).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text) ).ToString();
                    break;
                case "mod" :
                    result.Text = (value % Double.Parse(result.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(result.Text);
                    double q;
                    q = (value);
                    result.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
                default:
                    break;

            }//end switch
            value = Double.Parse(result.Text);
            operation = "";
              lstHistory .Items.Add(firstNum+" "+secondnum+ "=" + result.Text+ "\n");
                }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation2.Text = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(result.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result.Text += Clipboard.GetText();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            result.ResetText();
                result.Text = result.Text.Remove(result.Text.Length - 1);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
if (result.Text.Contains("-"))
                result.Text = result.Text.Remove(0, 1);
            else
                result.Text = "-" + result.Text;
        }
        
        private void button22_Click(object sender, EventArgs e)
        {
            double root = Math.Sqrt (Convert.ToDouble(result.Text));
            result.Text = Convert.ToString(root);
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 250;
            result.Width = 227;
            lstHistory.Visible = false;
            button23.Visible = false;

        }

        private void stiintificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 400;
            result.Width = 320;
            lstHistory.Visible = false;  
            button23.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 250;
            result.Width = 227;
        }

       
        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            result.Text = "3.141592653589976323";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            double ilog = Double.Parse(result.Text);
            equation2.Text = System.Convert.ToString("log" + "(" + (result.Text) + ")");
            ilog = Math.Log10(ilog);
            result.Text = System.Convert.ToString(ilog);
            

        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            if (button31.Text == "Rad")
            {
                double sinh = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("sinh" + "(" + (result.Text) + ")");
                sinh = Math.Sinh(sinh);
                result.Text = System.Convert.ToString(sinh);
            }
            else
            if(button31.Text == "Deg")
            {
                double sinh = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("sinh" + "(" + (result.Text) + ")");
                sinh = Math.Sinh((sinh*3.14159265359) / 180);
                result.Text = System.Convert.ToString(sinh);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button31.Text == "Rad")
            {
                double sin = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("sin" + "(" + (result.Text) + ")");
                sin = Math.Sin(sin);
                result.Text = System.Convert.ToString(sin);
            }
            else
            if (button31.Text == "Deg")
            {
                double sin = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("sin" + "(" + (result.Text) + ")");
                sin = Math.Sin((sin*3.14159265359) / 180);
                result.Text = System.Convert.ToString(sin);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button31.Text == "Rad")
            {
                double cos = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("cos" + "(" + (result.Text) + ")");
                cos = Math.Cos(cos);
                result.Text = System.Convert.ToString(cos);
            }
            else
            if (button31.Text == "Deg")
            {
                double cos = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("cos" + "(" + (result.Text) + ")");
                cos = Math.Cos((cos * 3.14159265359) / 180);
                result.Text = System.Convert.ToString(cos);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button31.Text == "Rad")
            {
                double cosh = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("cosh" + "(" + (result.Text) + ")");
                cosh = Math.Cosh(cosh);
                result.Text = System.Convert.ToString(cosh);
            }
            else
            if (button31.Text == "Deg")
            {
                double cosh = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("cosh" + "(" + (result.Text) + ")");
                cosh = Math.Cosh((cosh* 3.14159265359) / 180);
                result.Text = System.Convert.ToString(cosh);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button31.Text == "Rad")
            {
                double tanh = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("tanh" + "(" + (result.Text) + ")");
                tanh = Math.Tanh(tanh);
                result.Text = System.Convert.ToString(tanh);
            }
            else
            if (button31.Text == "Deg")
            {
                double tanh = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("tanh" + "(" + (result.Text) + ")");
                tanh = Math.Tanh((tanh * 3.14159265359) / 180);
                result.Text = System.Convert.ToString(tanh);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button31.Text == "Rad")
            {
                double tan = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("tan" + "(" + (result.Text) + ")");
                tan = Math.Tan(tan);
                result.Text = System.Convert.ToString(tan);
            }
            else
            if (button31.Text == "Deg")
            {
                double tan = Double.Parse(result.Text);
                equation2.Text = System.Convert.ToString("tan" + "(" + (result.Text) + ")");
                tan = Math.Tan((tan * 3.14159265359) / 180);
                result.Text = System.Convert.ToString(tan);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 8);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 16);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double a;

            a = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text)* Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 /Convert.ToDouble(result.Text));
                result.Text = System.Convert.ToString(a);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(result.Text);
            equation2.Text = System.Convert.ToString("log" + "(" + (result.Text) + ")");
            ilog = Math.Log(ilog);
            result.Text = System.Convert.ToString(ilog);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(result.Text)/ Convert.ToDouble(100);
            result.Text = System.Convert.ToString(a);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'C';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'F';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'K';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtMultiply.Text);
            for(int i = 1; i < 13; i++)
            {
                lstmultiply.Items.Add(i+"x"+a+"="+a*i);
            }
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 800;
            result.Width = 320;
            txtMultiply.Focus();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox2.Location = new Point(367, 39);
            groupBox3.Visible = false;
            lstHistory.Visible = false;
            button23.Visible = false;

        }

        private void btnResetM_Click(object sender, EventArgs e)
        {
            lstmultiply.Items.Clear();
            txtMultiply.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void unitConvertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 850;
            result.Width = 320;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox3.Location = new Point(450, 39);
            lstHistory.Visible = false;
            button23.Visible = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            ioperation1 = 'B';
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ioperation1 = 'C';
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ioperation1 = 'D';
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            ioperation1 = 'E';
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            label6.Text = "";
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 400;
            result.Width = 223;
            lstHistory.Visible = true;
            button23.Visible = true;
            button31.Visible = false;

        }

       

        private void button23_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }

        private void unitCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            
            if (button31.Text == "Rad")
            {
                button31.Text = "Deg";
            }
            else
            {
                button31.Text = "Rad";
            }
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox2.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ioperation1 = 'G';
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox2.Visible = true;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            ioperation1 = 'A';
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ioperation1 = 'L';
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ioperation1 = 'M';
        }

        private void button29_Click(object sender, EventArgs e)
        {
            switch (ioperation1)
            {
                case 'K':
                    kilo = Double.Parse(textBox2.Text);
                    label6.Text = ((1000 * kilo).ToString());
                    break;
                case 'G':
                    gram = Double.Parse(textBox2.Text);
                    label6.Text = ((gram /1000).ToString());
                    break;
                case 'L':
                    liter = Double.Parse(textBox2.Text);
                    label6.Text = ((1000 * liter).ToString());
                    break;
                case 'M':
                    mili = Double.Parse(textBox2.Text);
                    label6.Text = ((mili /1000 ).ToString());
                    break;
                case 'A':
                    kilometer = Double.Parse(textBox2.Text);
                    label6.Text = (( kilometer* 1000).ToString());
                    break;
                case 'B':
                    meter = Double.Parse(textBox2.Text);
                    label6.Text = ((meter / 1000).ToString());
                    break;
                case 'C':
                    inches = Double.Parse(textBox2.Text);
                    label6.Text = ((inches * 3).ToString());
                    break;
                case 'D':
                    feet = Double.Parse(textBox2.Text);
                    label6.Text = ((feet *12).ToString());
                    break;
                case 'E':
                    centimeter = Double.Parse(textBox2.Text);
                    label6.Text = ((centimeter / 100).ToString());
                    break;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ioperation1 = 'K';
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 750;
            result.Width = 320;
            textBox1.Focus();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            lstHistory.Visible = false;
            button23.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (ioperation)
            {
                case 'C':
                    iChelsius = float.Parse(textBox1.Text);
                    label3.Text = ((((iChelsius * 9) / 5) + 32).ToString());
                    break;
                case 'F':
                    iFahrenheit= float.Parse(textBox1.Text);
                    label3.Text = ((((iFahrenheit-32) * 5) / 32).ToString());
                    break;
                case 'K':
                    iKevin= float.Parse(textBox1.Text);
                    label3.Text =(((((iKevin * 9) / 5) + 32)+273.15).ToString());
                    break;

            }
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
                switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case "ENTER":
                    div.PerformClick();
                    break;
                case ".":
                    dec.PerformClick();
                    break;
                default:
                    break;
            }

            
        }
    }
}
