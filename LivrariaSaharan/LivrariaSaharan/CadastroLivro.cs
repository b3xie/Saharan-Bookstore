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
    public partial class CadastroLivro : Form
    {
        ConexaoBD conne;
        SqlConnection conn = ConexaoBD.obterConexao();
        DataTable dt;

        public CadastroLivro()
        {
            InitializeComponent();

            

        }

        public void hideUpdate()
        {
            btnUpdate.Visible = false;
            button1.Visible = true;
        }
        public void hideAdd()
        {
            button1.Visible = false;
            btnUpdate.Visible = true;
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e) //btnAdd
        {
            String CodBarsLivro = txtCodBarLivro.Text, ISBN = txtISBN.Text, AutorLivro = txtAutorLivro.Text, GeneroLivro = cbGeneroLivro.Text,
                DataLote = dateTimePicker1.Value.ToShortDateString(), Preco = txtPreco.Text, TituloLivro = txtTituloLivro.Text, Qtde = txtQtde.Text;

            conne = new ConexaoBD();
            if (cbTipo.SelectedItem == "Livro")
            {
                if (txtCodBarLivro.Text == "" && txtISBN.Text == "" && txtAutorLivro.Text == "" && cbGeneroLivro.Text == "" && txtPreco.Text == "" && txtQtde.Text == ""
                    && txtTituloLivro.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                else
                {
                    SqlCommand insertEstoq = new SqlCommand("INSERT INTO tblEstoque VALUES ('" + CodBarsLivro + "','" + DataLote + "','" + Qtde + "','" + Preco + "')", conn);

                    SqlCommand prod = new SqlCommand("SELECT idEstoque FROM tblEstoque WHERE CodigoBarras = '" + CodBarsLivro + "'", conn);
                    using (SqlDataReader read = prod.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            String idLivro = read[0].ToString();
                            SqlCommand insertProd = new SqlCommand("INSERT INTO tblLivros VALUES ('" + ISBN + "'," + idLivro + ",'" + TituloLivro + "','" + AutorLivro + "','" + GeneroLivro + "')", conn);
                            insertEstoq.ExecuteScalar();
                            insertProd.ExecuteScalar();
                            
                        }
                    }
                    MessageBox.Show("Registro Inserido");

                }
            }
            else { MessageBox.Show("Selecione um tipo de producto"); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CadastroLivro_Load(object sender, EventArgs e)
        {
            cbTipo.SelectedItem = "Livro";
            pnLivro.Visible = true;
            pnJogo.Visible = false;
            pnMusica.Visible = false;
            pnFilme.Visible = false;

            conne = new ConexaoBD();
            dt = new DataTable();

            dt = conne.executarSQL("SELECT Genero FROM tblGenero");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbGeneroFilme.Items.Add(dt.Rows[i]["Genero"]);
                cbGeneroJogo.Items.Add(dt.Rows[i]["Genero"]);
                cbGeneroLivro.Items.Add(dt.Rows[i]["Genero"]);
            }

            dt = conne.executarSQL("SELECT Genero FROM tblGeneroMusic");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbGeneroMusica.Items.Add(dt.Rows[i]["Genero"]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedItem.ToString() == "Livro")
            {
                pnLivro.Visible = true;
                pnJogo.Visible = false;
                pnMusica.Visible = false;
                pnFilme.Visible = false;
            }if (cbTipo.SelectedItem.ToString() == "Jogo")
            {
                pnLivro.Visible = false;
                pnJogo.Visible = true;
                pnMusica.Visible = false;
                pnFilme.Visible = false;
            }
            if (cbTipo.SelectedItem.ToString() == "Filme")
            {
                pnLivro.Visible = false;
                pnJogo.Visible = false;
                pnMusica.Visible = false;
                pnFilme.Visible = true;
            }
            if (cbTipo.SelectedItem.ToString() == "Música")
            {
                pnLivro.Visible = false;
                pnJogo.Visible = false;
                pnMusica.Visible = true;
                pnFilme.Visible = false;
            }
        }
    }
}
