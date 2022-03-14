using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
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
            double[] pole = new double [n];

            for( int i = 0; i < n; i++)
            {

                pole[i] = rnd.NextDouble() * (1000 + 1000) - 1000;
                listBox1.Items.Add(pole[i].ToString("F2"));

            }
            double prumer = pole.Average();
            MessageBox.Show("prumer prvku" + prumer);
            double max = -3000;
            foreach( double i in pole)
            {
                if(i <= prumer)
                {
                    if (max < i) max = i;

                }

            }
            MessageBox.Show(" maximum z čísel <= prumeru je: " + max);
        }
    }
}
