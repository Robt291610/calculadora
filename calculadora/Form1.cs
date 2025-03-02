using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {


        long num1;
        string sign;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0") 
            {
             screen.Clear();  
            }
            
            Button numbers = (Button)sender;
            screen.Text = screen.Text + numbers.Text;


            if (txtnumber1.Text != "") 
            {
                screen.Clear();

                Button Numbers = (Button)sender;
                screen.Text = screen.Text + Numbers.Text;


            }


            
        }

        public void equals_Click(object sender, EventArgs e)
        {
            long number1 = num1;
            int number2 = int.Parse(screen.Text);
            string Sign = sign;

            switch (Sign) 
            {
                case "+":
                    screen.Text = Convert.ToString(number1 + number2);
                    break;

                case "-":
                    screen.Text = Convert.ToString(number1 - number2);
                break;

                case "/":
                    screen.Text = Convert.ToString(number1 / number2);
                break;

                case "*":
                    screen.Text = Convert.ToString(number1 * number2);
                break;

            }
            
            





        }

        public void Operation(object sender, EventArgs e)
        {

            

            if (screen.Text == "0")
            {
                Button operators = (Button)sender;
                screen.Text = screen.Text;
            }

            else
            {
                Button operators = (Button)sender;

                long Number1 = int.Parse(screen.Text);
                num1 = Number1;
                
                sign = operators.Text;

                txtnumber1.Text = screen.Text + " " + operators.Text;



            }

              
       



        }

        private void buttonce_Click(object sender, EventArgs e)
        {
            screen.Clear();
            txtnumber1.Text = "";
        }
    }
}
