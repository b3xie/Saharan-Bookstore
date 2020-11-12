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
    public partial class Login : Form
    {
        SQLconexao con;
        DataTable dt;

        public Login()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con = new SQLconexao();
            dt = new DataTable();

            String usu = textBox1.Text;
            String senha = textBox2.Text;

            dt = con.executarSQL("SELECT CPF,senhaLogin FROM tblFuncionario WHERE CPF = '" + usu + "' AND senhaLogin = '" + senha + "'");
            try
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login aceito");//o que vai acontecer se o login existir
                }
                else
                {
                    MessageBox.Show("Login negado");//o que vai acontecer se não existir
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nós nos desculpamos, parece que temos problemas com o Banco de Dados");
            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
