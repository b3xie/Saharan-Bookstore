using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaSaharan
{
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;

            TextoISBN.Text = valor + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;

            TextoISBN.Text = valor + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;

            TextoISBN.Text = valor + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;

            TextoISBN.Text = valor + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;

            TextoISBN.Text = valor + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;

            TextoISBN.Text = valor + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;

            TextoISBN.Text = valor + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;

            TextoISBN.Text = valor + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;

            TextoISBN.Text = valor + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            String valor = TextoISBN.Text;
            
            if(valor == "") 
            {
            
            } else
            {
                TextoISBN.Text = valor + 0;
            }
            
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                String teste = TextoISBN.Text;
                String teste1 = teste.Substring(0, teste.Length - 1);
                TextoISBN.Text = teste1;
            }
            catch (Exception) 
            {
            

            } 
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            String testando = TextoISBN.Text;
            if (testando.Length == 13)
            {
                TerminalResultado form = new TerminalResultado();
                form.Show();

            }
            else 
            {
                MessageBox.Show("Seu ISBN está errado!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
