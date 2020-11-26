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
    public partial class TerminalResultado : Form
    {
        private string Titulo;

        public TerminalResultado()
        {
            InitializeComponent();
        }

        public void setTitulo(string titulo) { Titulo = ResultadoTitulo.Text; }
        public string getTitulo() { return Titulo; }

        public string titulo
        {
            get { return ResultadoTitulo.Text; }
            set { ResultadoTitulo.Text = value; }
        }
        public string autEst
        {
            get { return lblAutEstud.Text; }
            set { lblAutEstud.Text = value; }
        }
        public string resultAut
        {
            get { return ResultadoAutor.Text; }
            set { ResultadoAutor.Text = value; }
        }
        public string lblISxB
        {
            get { return lblISxN.Text; }
            set { lblISxN.Text = value; }
        }
        public string resultIS
        {
            get { return ResultadoIS.Text; }
            set { ResultadoIS.Text = value; }
        }
        public string preco
        {
            get { return txtPreco.Text; }
            set { txtPreco.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terminal form = new Terminal();
            form.Show();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TerminalResultado_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
