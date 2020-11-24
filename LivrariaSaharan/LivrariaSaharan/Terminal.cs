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
    public partial class Terminal : Form
    {
        SQLconexao con;
        DataTable dt;
        SqlDataReader dr;
        SqlConnection conn = ConexaoBD.obterConexao();
        ConexaoBD conne;

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
            
            TextoISBN.Text = valor + 0;
            
            
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
            conne = new ConexaoBD();
            con = new SQLconexao();
            dt = new DataTable();
            String testando = TextoISBN.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEstoque WHERE CodigoBarras='" + testando + "'", conn);
            TerminalResultado form = new TerminalResultado();

            dt = conne.executarSQL("SELECT CodigoBarras FROM tblEstoque WHERE CodigoBarras = '" + testando + "'");

            if (testando.Length == 12)
            {
                
                    if (dt.Rows.Count > 0)
                    {

                        dt = conne.executarSQL("SELECT * FROM tblLivros WHERE idEstoque IN (SELECT idEstoque FROM tblEstoque WHERE CodigoBarras ='" + testando + "')");
                        if (dt.Rows.Count > 0)
                        {
                            SqlCommand prod = new SqlCommand("SELECT A.Titulo,A.Autor,A.ISBN,B.Preco FROM tblLivros AS A INNER JOIN tblEstoque AS B ON A.idEstoque = B.idEstoque WHERE CodigoBarras = '" + testando + "'", conn);
                            using (SqlDataReader read = prod.ExecuteReader())
                            {
                                while (read.Read())
                                {

                                    form.titulo = read[0].ToString();
                                    form.autEst = "Autor";
                                    form.resultAut = read[1].ToString(); ;
                                    form.lblISxB = "ISBN";
                                    form.resultIS = read[2].ToString();
                                    form.preco = read[3].ToString();
                                    form.ShowDialog();
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            dt = conne.executarSQL("SELECT * FROM tblFilmes WHERE idEstoque IN (SELECT idEstoque FROM tblEstoque WHERE CodigoBarras ='" + testando + "')");
                            if (dt.Rows.Count > 0)
                            {
                                SqlCommand prod = new SqlCommand("SELECT A.Titulo,A.Estudio,A.ISAN,B.Preco FROM tblFilmes AS A INNER JOIN tblEstoque AS B ON A.idEstoque = B.idEstoque WHERE CodigoBarras = '" + testando + "'", conn);
                                using (SqlDataReader read = prod.ExecuteReader())
                                {
                                    while (read.Read())
                                    {
                                        form.titulo = read[0].ToString();
                                        form.autEst = "Estudio";
                                        form.resultAut = read[1].ToString(); ;
                                        form.lblISxB = "ISAN";
                                        form.resultIS = read[2].ToString();
                                        form.preco = read[3].ToString();
                                        form.ShowDialog();
                                        this.Close();
                                    }
                                }
                            }
                            else
                            {
                                dt = conne.executarSQL("SELECT * FROM tblJogos WHERE idEstoque IN (SELECT idEstoque FROM tblEstoque WHERE CodigoBarras ='" + testando + "')");
                                if (dt.Rows.Count > 0)
                                {
                                    SqlCommand prod = new SqlCommand("SELECT A.Titulo,A.Estudio,A.ISAN,B.Preco FROM tblJogos AS A INNER JOIN tblEstoque AS B ON A.idEstoque = B.idEstoque WHERE CodigoBarras = '"+ testando +"'", conn);
                                    using (SqlDataReader read = prod.ExecuteReader())
                                    {
                                        while (read.Read())
                                        {
                                            form.titulo = read[0].ToString();
                                            form.autEst = "Estudio";
                                            form.resultAut = read[1].ToString(); ;
                                            form.lblISxB = "ISAN";
                                            form.resultIS = read[2].ToString();
                                            form.preco = read[3].ToString();
                                            form.ShowDialog();
                                            Close();
                                        }
                                    }
                                }
                                else
                                {
                                    dt = conne.executarSQL("SELECT * FROM tblMusicas WHERE idEstoque IN (SELECT idEstoque FROM tblEstoque WHERE CodigoBarras ='" + testando + "')");
                                    if (dt.Rows.Count > 0)
                                    {
                                        SqlCommand prod = new SqlCommand("SELECT tblMusicas.*,tblAutor.Nome,tblEstoque.Preco FROM tblMusicas INNER JOIN tblAlbum ON tblAlbum.idAlbum = tblMusicas.Album INNER JOIN tblAutor ON tblAutor.idAutor = tblAlbum.Autor INNER JOIN tblEstoque ON tblEstoque.idEstoque = tblMusicas.idEstoque WHERE tblEstoque.CodigoBarras = '"+ testando +"'", conn);
                                        using (SqlDataReader read = prod.ExecuteReader())
                                        {
                                            while (read.Read())
                                            {
                                                form.titulo = read[2].ToString();
                                                form.autEst = "Autor";
                                                form.resultAut = read[4].ToString(); ;
                                                form.lblISxB = "ISMN";
                                                form.resultIS = read[0].ToString();
                                                form.preco = read[5].ToString();
                                                form.ShowDialog();
                                                this.Close();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nenhum produto encontrado");
                                    }
                                }
                            }
                        }
                    }
                    
                
                
                
            }
            else
            {
                MessageBox.Show("Nenhum produto encontrado");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
        }

        private void TextoISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
