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

        public string TituloLivro {get { return txtTituloLivro.Text; } set { txtTituloLivro.Text = value; } }
        public string TituloFilme { get { return txtTituloFilme.Text; } set { txtTituloFilme.Text = value; } }
        public string TituloJogo { get { return txtTituloJogo.Text; } set { txtTituloJogo.Text = value; } }

        public string ISBN { get { return txtISBN.Text; } set { txtISBN.Text = value; } }
        public string ISANjogo { get { return txtISANjogo.Text; } set { txtISANjogo.Text = value; } }
        public string ISANfilme { get { return txtISANfilme.Text; } set { txtISANfilme.Text = value; } }

        public string CodBarsLivro { get { return txtCodBarLivro.Text; } set { txtCodBarLivro.Text = value; } }
        public string CodBarsJogo { get { return txtCodBarJogo.Text; } set { txtCodBarJogo.Text = value; } }
        public string CodBarsFilme { get { return txtCodBarFilme.Text; } set { txtCodBarFilme.Text = value; } }

        public string AutorLivro { get { return txtAutorLivro.Text; } set { txtAutorLivro.Text = value; } }
        public string EstudFilme { get { return txtEstudioFilme.Text; } set { txtEstudioFilme.Text = value; } }
        public string EstudJogo { get { return txtEstudioJogo.Text; } set { txtEstudioJogo.Text = value; } }
        public string Publicadora { get { return txtPublicadora.Text; } set { txtPublicadora.Text = value; } }

        public string GeneroLivro { get { return cbGeneroLivro.SelectedItem.ToString(); } set { cbGeneroLivro.SelectedItem = value; } }
        public string GeneroJogo { get { return cbGeneroJogo.SelectedItem.ToString(); } set { cbGeneroJogo.SelectedItem = value; } }
        public string GeneroFilme { get { return cbGeneroFilme.SelectedItem.ToString(); } set { cbGeneroFilme.SelectedItem = value; } }

        public string Data { get { return dateTimePicker1.Value.ToString(); } set { dateTimePicker1.Value = new DateTime(); } }


        public void hideUpdate()
        {

            button1.Visible = true;
        }
        public void hideAdd()
        {
            button1.Visible = false;

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
                if (cbTipo.SelectedItem.ToString() == "Livro")
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
                if(cbTipo.SelectedItem.ToString() == "jogo")
                {
                    String CodBarsjogo = txtCodBarJogo.Text, ISAN = txtISANjogo.Text, EstudioJogo = txtEstudioJogo.Text, GeneroJogo = cbGeneroJogo.SelectedItem.ToString(),
                            DataLote = dateTimePicker1.Value.ToShortDateString(), TituloJogo = txtTituloJogo.Text, Publicadora = txtPublicadora.Text;
                    int Qtde = Convert.ToInt32(txtQtde.Text);
                    double Preco = double.Parse(txtPreco.Text);

                    SqlCommand cmd = new SqlCommand("usp_Susus", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@codbar", CodBarsjogo);
                    cmd.Parameters.AddWithValue("@data", DataLote);
                    cmd.Parameters.AddWithValue("@qtde", Qtde);
                    cmd.Parameters.AddWithValue("@preco", Preco);
                    cmd.Parameters.Add("@retValue", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    int retval = (int)cmd.Parameters["@retValue"].Value;

                    dt = conne.executarSQL("SELECT idGenero FROM tblGenero WHERE Genero = '" + GeneroJogo + "'");
                    String genJogo = dt.Rows[0]["idGenero"].ToString();

                    cmd = new SqlCommand("INSERT INTO tblJogos VALUES ('" + ISAN + "'," + retval.ToString() + ",'" + TituloJogo + "','" + EstudioJogo + "'," + Publicadora + "," + genJogo + ")", conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) { MessageBox.Show("Registro Inserido"); } else { MessageBox.Show("Erro ao inserir registro"); }
                }
                if (cbTipo.SelectedItem.ToString() == "Filme")
                {
                    String CodBarsFilmeo = txtCodBarFilme.Text, ISAN = txtISANfilme.Text, EstudFilme = txtEstudioFilme.Text, GeneroFilme = cbGeneroFilme.SelectedItem.ToString(),
                            DataLote = dateTimePicker1.Value.ToShortDateString(), TituloFilme = txtTituloFilme.Text;
                    int Qtde = Convert.ToInt32(txtQtde.Text);
                    double Preco = double.Parse(txtPreco.Text);
                    //zap
                    SqlCommand cmd = new SqlCommand("usp_Susus", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@codbar", CodBarsFilmeo);
                    cmd.Parameters.AddWithValue("@data", DataLote);
                    cmd.Parameters.AddWithValue("@qtde", Qtde);
                    cmd.Parameters.AddWithValue("@preco", Preco);
                    cmd.Parameters.Add("@retValue", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    int retval = (int)cmd.Parameters["@retValue"].Value;

                    dt = conne.executarSQL("SELECT idGenero FROM tblGenero WHERE Genero = '" + GeneroFilme + "'");
                    String genFilme = dt.Rows[0]["idGenero"].ToString();

                    cmd = new SqlCommand("INSERT INTO tblFilmes VALUES ('" + ISAN + "'," + retval.ToString() + ",'" + TituloFilme + "','" + EstudFilme + "'," + genFilme + ")", conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) { MessageBox.Show("Registro Inserido"); } else { MessageBox.Show("Erro ao inserir registro"); }

                
                }
                if(cbTipo.SelectedItem == "Filme")
                {
                    MessageBox.Show("ee");
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

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
