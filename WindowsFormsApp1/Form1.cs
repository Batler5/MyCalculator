using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        
        Util util =new Util();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (textBox1.Text.Length<9)
            {      
                if (textBox1.Text == "0") 
                {
                    textBox1.Text = null;
                }       
            textBox1.Text = textBox1.Text + B.Text;
            }
            if (util.Deistvie == "")
            {
                util.Num1 = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                util.Num2 = Convert.ToDouble(textBox1.Text);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (util.Znak == true)
            {
                util.Znak = false;
                label1.Text = "-";
                if (util.Deistvie=="" && util.Num1!=0) { util.Num1 *= (-1); }
                else if (util.Deistvie !="" && util.Num1!=0) { }
                else { util.Num2 *= (-1); }
            }
            else
            {
                util.Znak = true;
                label1.Text = "";
                if (util.Deistvie == "") { util.Num1 *= (-1); }
                else { util.Num2 *= (-1); }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            util.Znak = true;
            label1.Text = "";
            textBox1.Text = null;
            util.Num1 = 0;
            util.Num2 = 0;
            util.Num3 = 0;
            util.Deistvie = "";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            util.Znak = true;
            Button B = (Button)sender;
            if (util.Deistvie == "") { util.Deistvie = B.Text; }
            textBox1.Text = null;
            if (util.Num2 != 0) { util.Operation(); }
            util.Deistvie = B.Text;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (util.Num1 != 0 && Convert.ToString(util.Num1) != textBox1.Text)
            { util.Num2 = Convert.ToDouble(textBox1.Text); }
            util.Operation();
            if (Convert.ToString(util.Num1).Length <= 9)
            {
                if (util.Num1 == 298312265)
                {
                    textBox1.Text = "Not: 0";
                    util.Num1 = 0;
                }
                else
                if (util.Num1 >= 0)
                {
                    textBox1.Text = Convert.ToString(util.Num1);
                }
                else
                {
                    label1.Text = "-";
                    textBox1.Text = Convert.ToString(util.Num1 * (-1));
                }
            }
            else { textBox1.Text = "Lenght > 9"; util.Num1 = 0; }
        }
    }
}
