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

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta form = new Consulta();
            form.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroLivro form = new CadastroLivro();
            form.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta form = new Consulta();
            form.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Venda form = new Venda();
            form.Show();
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            Terminal term = new Terminal();
            term.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaC_Click(object sender, EventArgs e)
        {
            ConsultaCadastro form = new ConsultaCadastro();
            form.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario form = new CadastroFuncionario();
            form.Show();
        }

        private void principalLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sobre form = new Sobre();
            form.Show();
        }
    }
}
