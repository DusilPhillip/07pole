using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Apole;
        int[] Bpole;
        private void button1_Click(object sender, EventArgs e)
        {

            int N = Convert.ToInt32(textBox1);
            Random rnd = new Random();
             Apole = new int[N];

            foreach(int i in Apole) {

                Apole[i] = rnd.Next(3, 11);
                listBox1.Items.Add(i.ToString());

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int M = Convert.ToInt32(textBox2);
            Random rnd = new Random();
             Bpole = new int[M];

            foreach( int i in Bpole)
            {
                Bpole[i] = rnd.Next(3, 11);
                listBox2.Items.Add(i.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int[] Cpole = Apole.Concat(Bpole).ToArray();
            foreach(int i in Cpole)
            {
                
                listBox3.Items.Add(i.ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] Dpole = Apole.Union(Bpole).ToArray();
            foreach (int i in Dpole)
            {

                listBox4.Items.Add(i.ToString());

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int[] Epole = Apole.Intersect(Bpole).ToArray();
            foreach (int i in Epole)
            {

                listBox5.Items.Add(i.ToString());

            }
        }
    }
}
