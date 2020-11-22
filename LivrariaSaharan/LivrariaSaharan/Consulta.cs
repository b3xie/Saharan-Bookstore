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
    public partial class Consulta : Form
    {
        SQLconexao con;
        DataTable dt;
        ConexaoBD conne;

        public Consulta()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtPesq_Click(object sender, EventArgs e)
        {
            con = new SQLconexao();
            conne = new ConexaoBD();
            dt = new DataTable();

            String nome = txtNome.Text;
            String cod = txtCod.Text;

            dt = conne.executarSQL("SELECT * FROM tblLivros WHERE Titulo LIKE '%" + nome + "%' OR ISBN = '" + cod + "'");

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
                    dt = conne.executarSQL("SELECT * FROM tblJogos WHERE Titulo LIKE '%" + nome + "%' OR ISAN = '" + cod + "'");
                    if (dt.Rows.Count > 0)
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;
                        dataGridView1.DataSource = bs;
                    }
                    else
                    {
                        dt = conne.executarSQL("SELECT * FROM tblMusicas WHERE Titulo LIKE '%" + nome + "%' OR ISAN = '" + cod + "'");
                        if (dt.Rows.Count > 0)
                        {
                            BindingSource bs = new BindingSource();
                            bs.DataSource = dt;
                            dataGridView1.DataSource = bs;
                        }
                        else
                        {
                            dt = conne.executarSQL("SELECT * FROM tblFilmes WHERE Titulo LIKE '%" + nome + "%' OR ISAN = '" + cod + "'");
                            if (dt.Rows.Count > 0)
                            {
                                BindingSource bs = new BindingSource();
                                bs.DataSource = dt;
                                dataGridView1.DataSource = bs;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não temos este produto");
            }
        }
    }
}
