using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
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
            int[] pole = new int[n];

            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(1, 11);
                listBox1.Items.Add(pole[i].ToString());
            }
            Array.Sort(pole);
            int max = pole.Max();
            int min = pole.Min();
            int prvnimax = Array.LastIndexOf(pole, max);
            int poslednimin = Array.LastIndexOf(pole, min);
            int dmin = pole[poslednimin + 1];
            int dmax = pole[prvnimax - 1];

            MessageBox.Show(" druhý max je:" + dmax + "druhy min je" + dmin);

            if (radioButton2.Checked)
            {

                Array.Reverse(pole);


            }
            
            foreach (int i in pole)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
