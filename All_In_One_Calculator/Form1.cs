using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_In_One_Calculator
{
    public partial class Form1 : Form
    {
        bool isN1Valid;
        bool isN2Valid;
        MathBasic Mathbasic = new MathBasic();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double n1;
            isN1Valid = double.TryParse(textBox1.Text, out n1);
            if (isN1Valid) 
            {
                Mathbasic.setN1(n1);
            }
            if (isN1Valid && isN2Valid)
            {
                setTextBox();
            } 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double n2;
            isN2Valid = double.TryParse(textBox2.Text, out n2);
            if (isN2Valid)
            {
                Mathbasic.setN2(n2);
            }
            if (isN1Valid && isN2Valid)
            {
                setTextBox();
            } 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void setTextBox()
        {
            textBox3.Text = Mathbasic.add().ToString();
            textBox4.Text = Mathbasic.sub().ToString();
            textBox5.Text = Mathbasic.div().ToString();
            textBox6.Text = Mathbasic.mul().ToString();
        }
    }
}
