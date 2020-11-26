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
using System.Threading;

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

                dt = new DataTable();

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
                        // zap
                        String CodBarsLivro = txtCodBarLivro.Text, ISBN = txtISBN.Text, AutorLivro = txtAutorLivro.Text, GeneroLivro = cbGeneroLivro.SelectedItem.ToString(),
                        DataLote = dateTimePicker1.Value.ToShortDateString(), TituloLivro = txtTituloLivro.Text;
                        int Qtde = Convert.ToInt32(txtQtde.Text);
                        double Preco = double.Parse(txtPreco.Text);
                        //zap
                    SqlCommand cmd = new SqlCommand("usp_Susus", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codbar", CodBarsLivro);
                        cmd.Parameters.AddWithValue("@data", DataLote);
                        cmd.Parameters.AddWithValue("@qtde", Qtde);
                        cmd.Parameters.AddWithValue("@preco", Preco);
                        cmd.Parameters.Add("@retValue", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        int retval = (int)cmd.Parameters["@retValue"].Value;

                        dt = conne.executarSQL("SELECT idGenero FROM tblGenero WHERE Genero = '" + GeneroLivro + "'");
                        String genLivro = dt.Rows[0]["idGenero"].ToString();

                        cmd = new SqlCommand("INSERT INTO tblLivros VALUES ('" + ISBN + "'," + retval.ToString() + ",'" + TituloLivro + "','" + AutorLivro + "'," + genLivro + ")",conn);
                        int i = cmd.ExecuteNonQuery();
                        if (i> 0) { MessageBox.Show("Registro Inserido"); } else { MessageBox.Show("Erro ao inserir registro"); }
                    }
                }
                else { MessageBox.Show("Selecione um tipo de produto"); }
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

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
