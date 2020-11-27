using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaSaharan
{
    public partial class CadastroFuncionario : Form
    {
        SQLconexao con;
        DataTable dt;
        ConexaoBD conne;
        SqlConnection conn = ConexaoBD.obterConexao();
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

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

            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string cpf = txtCpf.Text;
            string endereco = txtEndereco.Text;
            string cidade = txtCidade.Text;
            string salario = txtSalario.Text;
            string senha = txtSenha.Text;
            string bairro = txtBairro.Text;
            string complemento = txtComplemento.Text;
            string cep = txtCep.Text;
            string rg = txtRg.Text;
            string sexo = txtSexo.Text;
            string telefone = txtTelefone.Text;


            dt = conne.executarSQL
                ("INSERT INTO tblFuncionario (Nome,Sexo,Telefone,email,RG,CPF,Cidade,Bairro,CEP,Endereco,Complemento,Salario,senhaLogin) VALUES " +
                "('"+nome+"','"+sexo+"','"+telefone+"','"+email+"','"+rg+"','"+cpf+"','"+cidade+"','"+bairro+"','"+cep+"','"+endereco+"','"+complemento+"',"+salario+","+senha+")");

            MessageBox.Show("Registro incluído com sucesso!");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conne = new ConexaoBD();

            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string cpfa = txtCpf.Text;
            string endereco = txtEndereco.Text;
            string cidade = txtCidade.Text;
            string salario = txtSalario.Text;
            string senha = txtSenha.Text;
            string bairro = txtBairro.Text;
            string complemento = txtComplemento.Text;
            string cep = txtCep.Text;
            string rg = txtRg.Text;
            string sexo = txtSexo.Text;
            string telefone = txtTelefone.Text;

            string cpf = txtEduardo.Text;


            conne.manutencaoDB($"UPDATE tblFuncionario SET Nome = {nome},");
        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            con = new SQLconexao();
            conne = new ConexaoBD();
            dt = new DataTable();

            string cpf = txtEduardo.Text;
            SqlCommand pedro = new SqlCommand("DELETE FROM tblFuncionario WHERE CPF = '" + cpf + "'",conn);
            int i = pedro.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Registro Excluído");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SQLconexao();
            conne = new ConexaoBD();
            dt = new DataTable();

            
            String cpf = txtEduardo.Text;

            dt = conne.executarSQL("SELECT * FROM tblFuncionario WHERE CPF = '" + cpf + "'");
            txtNome.Text = dt.Rows[0]["Nome"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtCpf.Text = dt.Rows[0]["CPF"].ToString();
            txtEndereco.Text = dt.Rows[0]["Endereco"].ToString();
            txtCidade.Text = dt.Rows[0]["Cidade"].ToString();
            txtSalario.Text = dt.Rows[0]["Salario"].ToString();
            txtSenha.Text = dt.Rows[0]["senhaLogin"].ToString();
            txtBairro.Text = dt.Rows[0]["Bairro"].ToString();
            txtComplemento.Text = dt.Rows[0]["Complemento"].ToString();
            txtCep.Text = dt.Rows[0]["CEP"].ToString();
            txtRg.Text = dt.Rows[0]["RG"].ToString();
            txtSexo.Text = dt.Rows[0]["Sexo"].ToString();
            txtTelefone.Text = dt.Rows[0]["Telefone"].ToString();

        }
    }
}
