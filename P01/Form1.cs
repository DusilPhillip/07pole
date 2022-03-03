using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            double [] pole = new double[n];

            double pocetmax = 0;
            double pocetmin = 0;
            double soucet = 0;

            double min = 1000;
            double max = 1;
            int pozicemin = 0;
            int pozicemax = 0;

            for (int i = 0; i < n; i++)
            {

                pole[i] = rnd.NextDouble() * (1000 - 1) + 1;
                listBox1.Items.Add(pole[i].ToString());

                if (pole[i] < min)
                {
                    min = pole[i];
                    pozicemin = i;
                }
                if ( pole[i] == min)
                {

                    pocetmin++;
                }
                if (pole[i] > max)
                {
                    max = pole[i];
                    pozicemax = i;
                }   
                if ( pole[i] == max)
                {
                    pocetmax++;
                }
                soucet += pole[i];
            }

            MessageBox.Show("minimum v poli je:" + min + "maximum v poli je:" + max);


            pole[pozicemax] = min;
            pole[pozicemin] = max;
          
            foreach(double i in pole)
            {

                listBox2.Items.Add(i.ToString("F2"));

            }

            double bezmn = soucet - min - max;
            double pocetmn = n - 2;
            double prumer = bezmn / pocetmn;

            MessageBox.Show(" Aritmeticky prumer bez min a max je:" + prumer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            double[] pole = new double[n];


            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.NextDouble() * (1000 - 1) + 1;
                listBox1.Items.Add(pole[i].ToString());
            }
            double max = pole.Max();
            double min = pole.Min();
            int pozicemax = Array.IndexOf(pole, max);
            int pozicemin = Array.IndexOf(pole, min);

            MessageBox.Show(" Max v poli:" + max + " min v poli:" + min);

            pole[pozicemax] = min;
            pole[pozicemin] = max;

            foreach (double i in pole)
            {

                listBox2.Items.Add(i.ToString("F2"));

            }

            double pocet = pole.Length - 2;
            double soucet = pole.Sum() - max - min;

            double prumer = soucet / pocet;

            MessageBox.Show(" a_prumer " + prumer);
        }
        }

 }
    

