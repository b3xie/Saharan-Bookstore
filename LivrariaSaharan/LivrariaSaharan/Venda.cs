using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaSaharan
{
    public partial class Venda : Form
    {
        ConexaoBD conne;
        DataTable dt;
        SqlConnection conn = ConexaoBD.obterConexao();
        public Venda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conne = new ConexaoBD();
            dt = new DataTable();

            

            string nome = vendaNome.Text;
            string email = vendaEmail.Text;
            string cpf = vendaCPF.Text;
            string uf = cbUF.SelectedItem.ToString();
            string endereco = vendaEndereco.Text;
            string cidade = vendaCidade.Text;
            string complemento = vendaComplemento.Text;
            string cep = vendaCEP.Text;
            string telefone = vendaTelefone.Text;

            dt = conne.executarSQL($"SELECT CPF FROM tblCliente WHERE CPF = {cpf}");

            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Este registro ja existe");
            }
            else
            {
                try
                {
                    conne.manutencaoDB
                    ("INSERT INTO tblCliente VALUES " +
                    "('" + nome + "','" + telefone + "','" + email + "','" + cpf + "','" + uf + "','" + cidade + "','" + cep + "','" + endereco + "','" + complemento + "')");

                    MessageBox.Show("Registro incluído com sucesso!");
                }
                catch (Exception) { MessageBox.Show("Erro"); }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChecarCadastro_Click(object sender, EventArgs e)
        {
            conne = new ConexaoBD();
            dt = new DataTable();
            dt = conne.executarSQL($"SELECT * FROM tblCliente WHERE CPF = {vendaCPF.Text}");


            if (dt == null)
            {
                MessageBox.Show("Preencha o CPF!");
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    vendaNome.Text = dt.Rows[0]["Nome"].ToString();
                    vendaEmail.Text = dt.Rows[0]["email"].ToString();
                    vendaCPF.Text = dt.Rows[0]["CPF"].ToString();
                    cbUF.SelectedItem = dt.Rows[0]["UF"].ToString();
                    vendaEndereco.Text = dt.Rows[0]["Endereco"].ToString();
                    vendaCidade.Text = dt.Rows[0]["Cidade"].ToString();
                    vendaComplemento.Text = dt.Rows[0]["Complemento"].ToString();
                    vendaCEP.Text = dt.Rows[0]["CEP"].ToString();
                    vendaTelefone.Text = dt.Rows[0]["Telefone"].ToString();
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                }

            }
            
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            conne = new ConexaoBD();
            dt = new DataTable();
            String testando = txtCodBars.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEstoque WHERE CodigoBarras='" + testando + "'", conn);
            TerminalResultado form = new TerminalResultado();

            double preco = 0;

            dt = conne.executarSQL($"SELECT A.Titulo,B.Preco FROM tblLivros AS A INNER JOIN tblEstoque AS B ON B.idEstoque = A.idEstoque WHERE CodigoBarras = '{testando}'");

            if (testando.Length == 12)
            {

                if (dt.Rows.Count > 0)
                {
                    string[] row = new string[] { dt.Rows[0]["Titulo"].ToString(), dt.Rows[0]["Preco"].ToString() };
                    dataGridView1.Rows.Add(row);
                    preco = double.Parse(dt.Rows[0]["Preco"].ToString()) + preco;
                }
                else
                {
                    dt = conne.executarSQL($"SELECT A.Titulo,B.Preco FROM tblJogos AS A INNER JOIN tblEstoque AS B ON B.idEstoque = A.idEstoque WHERE CodigoBarras = '{testando}'");
                    if (dt.Rows.Count > 0)
                    {
                        string[] row = new string[] { dt.Rows[0]["Titulo"].ToString(), dt.Rows[0]["Preco"].ToString() };
                        dataGridView1.Rows.Add(row);
                        preco = double.Parse(dt.Rows[0]["Preco"].ToString()) + preco;
                    }
                    else
                    {
                        dt = conne.executarSQL($"SELECT A.Titulo,B.Preco FROM tblMusicas AS A INNER JOIN tblEstoque AS B ON B.idEstoque = A.idEstoque WHERE CodigoBarras = '{testando}'");
                        if (dt.Rows.Count > 0)
                        {
                            string[] row = new string[] { dt.Rows[0]["Titulo"].ToString(), dt.Rows[0]["Preco"].ToString() };
                            dataGridView1.Rows.Add(row);
                            preco = double.Parse(dt.Rows[0]["Preco"].ToString()) + preco;
                        }
                        else
                        {
                            dt = conne.executarSQL($"SELECT A.Titulo,B.Preco FROM tblFilmes AS A INNER JOIN tblEstoque AS B ON B.idEstoque = A.idEstoque WHERE CodigoBarras = '{testando}'");
                            if (dt.Rows.Count > 0)
                            {
                                string[] row = new string[] { dt.Rows[0]["Titulo"].ToString(), dt.Rows[0]["Preco"].ToString() };
                                dataGridView1.Rows.Add(row);
                                preco = double.Parse(dt.Rows[0]["Preco"].ToString()) + preco;
                            }
                            else
                            {
                                MessageBox.Show("Não temos este produto");
                            }
                        }
                    }
                }




            }
            else
            {
                MessageBox.Show("Nenhum produto encontrado");
            }
            txtPreco.Text = preco.ToString();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Produto";
            dataGridView1.Columns[1].Name = "Preço";
        }
    }
}
