using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Number_spiral
{
    public partial class Form1 : Form
    {
        List<int> PrimeNumbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SolidBrush brush = new SolidBrush(Color.White);
            Graphics graphics = this.CreateGraphics();
            Point DrawPoint = new Point(700, 500); //point to draw on
            int NumOn = 1;
            int HowManyToMake = 1;
            for (double i = 0; i < 2000; i++) //i defines what direction the spiral is going    
            {
                if (i % 4 == 0)
                {
                    for (int h = 1; h <= HowManyToMake; h++)
                    {
                        NumOn += 1;
                        DrawPoint.X += 1;
                        if(Prime(NumOn) == true)
                        {
                            graphics.FillRectangle(brush, DrawPoint.X, DrawPoint.Y, 1, 1);
                        }          
                    }
                }
                else if (i % 4 == 1)
                {
                    for (int h = 1; h <= HowManyToMake; h++)
                    {
                        NumOn += 1;
                        DrawPoint.Y += 1;
                        if (Prime(NumOn) == true)
                        {
                            graphics.FillRectangle(brush, DrawPoint.X, DrawPoint.Y, 1, 1);
                        }
                    }
                }
                else if (i % 4 == 2)
                {
                    for (int h = 1; h <= HowManyToMake; h++)
                    {
                        NumOn += 1;
                        DrawPoint.X -= 1;
                        if (Prime(NumOn) == true)
                        {
                            graphics.FillRectangle(brush, DrawPoint.X, DrawPoint.Y, 1, 1);
                        }
                    }
                }
                else if (i % 4 == 3)
                {
                    for (int h = 1; h <= HowManyToMake; h++)
                    {
                        NumOn += 1;
                        DrawPoint.Y -= 1;
                        if (Prime(NumOn) == true)
                        {
                            graphics.FillRectangle(brush, DrawPoint.X, DrawPoint.Y, 1, 1);
                        }
                    }
                } 
                if(i % 2 == 0)
                {
                    HowManyToMake++;
                }
               
            }
            label1.Text = "Numbers Made: " + NumOn.ToString();
            label2.Text = "Prime Number Count: " + PrimeNumbers.Count.ToString();
            label3.Text = "Prime Number Percent " + ((double)PrimeNumbers.Count / (double)NumOn) * 100 + "%";
        }
        private bool Prime(int num)
        {
            for(int i = 2; i < num / 2; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            PrimeNumbers.Add(num);
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PrimeNumbers.ToString());
        }
    }
}
