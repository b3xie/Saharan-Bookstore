﻿using System;
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
            dt = new DataTable();

            String nome = txtNome.Text;
            String cod = txtCod.Text;

            dt = con.executarSQL("SELECT * FROM tblLivros WHERE  Titulo = '" + nome + "' OR ISBN = '" + cod + "'");

            if (dt.Rows.Count > 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
            }
            else
            {
                dt = con.executarSQL("SELECT * FROM tblJogos WHERE  = Titulo '" + nome + "' OR ISAN = '" + cod + "'");
                if (dt.Rows.Count > 0)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dt;
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    dt = con.executarSQL("SELECT * FROM tblMusicas WHERE  = Titulo '" + nome + "' OR ISAN = '" + cod + "'");
                    if (dt.Rows.Count > 0)
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;
                        dataGridView1.DataSource = bs;
                    }
                    else
                    {
                        dt = con.executarSQL("SELECT * FROM tblFilmes WHERE  = Titulo '" + nome + "' OR ISAN = '" + cod + "'");
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
    }
}