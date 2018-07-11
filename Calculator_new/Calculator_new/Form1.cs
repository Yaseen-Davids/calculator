using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_new
{
    public partial class Calculator : Form

    {
        double FirstNumber;
        string Operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = buttonClicked.Text;
                textBox2.Text += buttonClicked.Text;
            }

            else
            {
                textBox1.Text = textBox1.Text + buttonClicked.Text;
                textBox2.Text = textBox2.Text + buttonClicked.Text;
            }
        }

        private void clear_btn(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
        }

        private void operation_val(object sender, EventArgs e)
        {

            Button mathBtn = (Button)sender;
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            textBox2.Text = textBox2.Text + mathBtn.Text;
            Operation = mathBtn.Text;
        }

        private void dot_btn(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text += ".";
                textBox2.Text += ".";
            }
        }

        private void equal_val(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if(Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                Result = (FirstNumber / SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }
}
