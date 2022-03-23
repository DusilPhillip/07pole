using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

   
            int kolik = 0;
           foreach( string p in listBox1.Items)
            {
                int i = Convert.ToInt32(p);
               
                if (i != 0) {
                    kolik++;
                }
              else
                {
                    break;
                }
            }
            int[] pole = new int[kolik];
            for ( int i = 0; i < kolik;i++)
            {
                pole[i] = Convert.ToInt32(listBox1.Items[i]);
            }
            foreach( int i in pole)
            {
                listBox2.Items.Add(i.ToString());

            }
            double posledni = pole.Last();
            double prvni = pole.First();

            double podil = prvni / posledni;
            MessageBox.Show("podil first and last je:" + podil);

            for( int i = 0 ;i <kolik; i++)
            {
               
                if ( pole[i] < posledni)
                {
                    
                    MessageBox.Show("prvek " + pole[i] + "na indexu" + i);
                }
            }
        }
    }
}
