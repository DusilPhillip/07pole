using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
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
            int B = Convert.ToInt32(textBox2.Text);
            int[] pole = new int[n];
            Random rnd = new Random();

            for ( int i = 0; i < pole.Length; i++)
            {
                pole[i] = rnd.Next(0,20);
            }
            Array.Sort(pole);
            foreach (int i in pole)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int B = Convert.ToInt32(textBox2.Text);
            Random rnd = new Random();

            int[] polemensi = new int[n];
            for (int i = 0; i < polemensi.Length; i++)
            {
                polemensi[i] = rnd.Next(0, 20);
            }
            Array.Sort(polemensi);
            int pocetmensi = 0;
            for (int i = 0; i < polemensi.Length; i++)
            {
                if (polemensi[i] <= B)
                {
                    pocetmensi++;
                }
            }
            polemensi = polemensi.Take(pocetmensi).ToArray();
            foreach (int i in polemensi)
            {
                listBox2.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int B = Convert.ToInt32(textBox2.Text);
            Random rnd = new Random();

            int[] polevetsi = new int[n];
            for (int i = 0; i < polevetsi.Length; i++)
            {
                polevetsi[i] = rnd.Next(0, 20);
            }
            Array.Sort(polevetsi);
            Array.Reverse(polevetsi);
            int pocetvetsi = 0;
            for (int i = 0; i < polevetsi.Length; i++)
            {
                if (polevetsi[i] > B)
                {
                    pocetvetsi++;
                }
            }
            polevetsi = polevetsi.Take(pocetvetsi).ToArray();
            foreach( int i in polevetsi)
            {
                listBox3.Items.Add(i.ToString());
            }
        }
    }
}
