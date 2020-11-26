using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LivrariaSaharan
{
    class ConexaoBD
    {

        private static string connString = @"Data Source=" + Environment.MachineName + ";Initial Catalog=Livraria;Persist Security Info=True;User ID=sa;Password=12345";


        // representa a conexão com o banco
        private static SqlConnection conn = null;

        // método que permite obter a conexão
        public static SqlConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new SqlConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (SqlException sqle)
            {
                conn = null;
                MessageBox.Show("Erro: " +sqle);
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        private SqlConnection conectar()
        {
            try
            {
                if (Environment.MachineName == "マギMAGI-SYSTEM-01")
                {
                    String strConexao = @"Data Source=" + Environment.MachineName + ";Initial Catalog=Livraria;Persist Security Info=True;User ID=sa;Password=12345";
                    conn.ConnectionString = strConexao;
                    conn.Open();
                    return conn;
                }
                else if (Environment.MachineName == "LAPTOP-E45O525M")
                {
                    String strConexao = @"Data Source=LAPTOP-E45O525M;Initial Catalog=Livraria;User ID=sa;Password=12345";
                    conn.ConnectionString = strConexao;
                    conn.Open();
                    return conn;
                }
                else
                {
                    String strConexao = @"Data Source=" + Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=Livraria;Persist Security Info=True;User ID=sa;Password=12345";
                    conn.ConnectionString = strConexao;
                    conn.Open();
                    return conn;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }



        public DataTable executarSQL(String comando_sql)
        {
            try
            {

                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conn);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {

            }
        }



    }
}
