using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            char[] pole = new char[textBox1.Text.Length];
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                pole[i] = textBox1.Text[i];


            }
            Array.Sort(pole);

            
            foreach (char i in pole)
            {
                listBox1.Items.Add(i.ToString());
            } 
            
            int maxdelka = 0;
            int pocet = 0;

            char final = '0';
            char prvek ='0';
            for (int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                if (pole[i] == pole[i + 1])
                {
                    pocet++;
                    prvek = pole[i];
                    
                    
                }
                else
                {
                    if (maxdelka < pocet)
                    {
                        maxdelka = pocet;
                        final = prvek;
                    }

                    pocet = 1;

                }
            }

            if (maxdelka < pocet)
            {
                maxdelka = pocet;
                final = prvek;
            }
            MessageBox.Show("prvek ktery se nejvice vyskytuje je:" + final + " a je tam " + maxdelka);
        }
    }
}
