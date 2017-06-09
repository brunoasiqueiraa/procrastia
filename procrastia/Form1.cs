using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procrastia
{
    public partial class Form1 : Form
    {
        int  a, b, c, d, ee, f, g;
        string a1, b1, c1, d1, ee1, f1, g1;

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {

            f = f + 1;
            
        }

        public void button4_Click(object sender, EventArgs e)
        {

            g = g + 1;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (a >= 1)
            {
                a1 = "Parabéns todas tarefas realizadas";
                label54.Text = Convert.ToString(a1);
            }
            else
                a1 = "Vamos se organizar melhor amanhã";
                    label54.Text = Convert.ToString(a1); 


            if (b >= 1)
            {
                b1 = "Parabéns todas tarefas realizadas";
                label49.Text = Convert.ToString(b1);

            }
            else
                b1 = "Vamos se organizar melhor amanhã";
            label49.Text = Convert.ToString(b1);


            if (c >= 1)
            {
                c1 = "Parabéns todas tarefas realizadas";
                label50.Text = Convert.ToString(c1);

            }
            else
                c1 = "Vamos se organizar melhor amanhã";
            label50.Text = Convert.ToString(c1);



            if (d >= 1)
            {
                d1 = "Parabéns todas tarefas realizadas";
                label51.Text = Convert.ToString(d1);
            }
            else
               d1 = "Vamos se organizar melhor amanhã";
            label51.Text = Convert.ToString(d1);


            if (ee >= 1)
            {
                ee1 = "Parabéns todas tarefas realizadas";
                label52.Text = Convert.ToString(ee1);
            }
            else
                ee1 = "Vamos se organizar melhor amanhã";
            label52.Text = Convert.ToString(ee1);

            if (f >= 1)
            {
                f1 = "Parabéns todas tarefas realizadas";
                label53.Text = Convert.ToString(f1);

            }
            else
               f1 = "Vamos se organizar melhor amanhã";
            label53.Text = Convert.ToString(f1);


            if (g >= 1)
            {
                g1 = "Parabéns todas tarefas realizadas";
                label55.Text = Convert.ToString(g1);
            }
            else
               g1 = "Vamos se organizar melhor amanhã";
            label55.Text = Convert.ToString(g1);

        }

        public void button3_Click(object sender, EventArgs e)
        {
            ee = ee + 1;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            d = d + 1;
        }

        public void button6_Click(object sender, EventArgs e)
        {
            c = c + 1;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            b = b + 1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            a = a + 1;
        }
    }
}
