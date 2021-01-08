using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenação
{
    public partial class Form1 : Form
    {
        int navegador = 0;
        int[] vetor = new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (navegador == 5) return;
            vetor[navegador] = Convert.ToInt32(textBox1.Text);
            richTextBox1.Text += textBox1.Text + " - ";
            textBox1.Text = "";
            navegador++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int aux;
            for(int i = 0; i< navegador; i++)
            {
                for(int j = i + 1; j < navegador; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[i];
                        vetor[i] = aux;
                    }
                }
            }
            for(int i = 0; i < navegador; i++)
            {
                richTextBox1.Text += vetor[i] + " -- ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navegador = 0;
            richTextBox1.Text = "";
            textBox1.Text = "";

        }
    }
}
