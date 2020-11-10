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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Terminal term = new Terminal();
            term.Show();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            using (Login EdnaldoPereira = new Login())
            {
                EdnaldoPereira.ShowDialog();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venda form = new Venda();
            form.Show();
        }
    }
}
