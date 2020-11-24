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
    public partial class ConsultaCadastro : Form
    {
        SQLconexao con;
        DataTable dt;
        ConexaoBD conne;

        public ConsultaCadastro()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SQLconexao();
            conne = new ConexaoBD();
            dt = new DataTable();

            String nome = txtNome.Text;
            String cpf = txtCPF.Text;

            dt = conne.executarSQL("SELECT * FROM tblCliente WHERE Nome LIKE '%" + nome + "%' OR CPF = '" + cpf + "'");

            try
            {

                if (dt.Rows.Count > 0)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    dt = conne.executarSQL("SELECT * FROM tblFuncionario WHERE Nome LIKE '%" + nome + "%' OR CPF = '" + cpf + "'");
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Esta pessoa não existe!");
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            String nome = txtNome.Text;
            String cpf = txtCPF.Text;
            dt = conne.executarSQL("SELECT * FROM tblCliente WHERE Nome LIKE '%" + nome + "%' OR CPF = '" + cpf + "'");


            ClienteDAO teste = new ClienteDAO();

            if (dt.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string value1 = row.Cells[0].Value.ToString();
                    teste.excluir(value1);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string value1 = row.Cells[0].Value.ToString();
                    teste.excluirFunc(value1);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
