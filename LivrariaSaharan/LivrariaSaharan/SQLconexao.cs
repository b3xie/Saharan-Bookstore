using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LivrariaSaharan
{
    class SQLconexao
    {
        SqlConnection conexao = new SqlConnection();

        private SqlConnection conectar()
        {
            try
            {
                if (Environment.MachineName == "マギMAGI-SYSTEM-01") {
                    String strConexao = @"Data Source=" + Environment.MachineName + ";Initial Catalog=Livraria;Persist Security Info=True;User ID=sa;Password=12345";
                    conexao.ConnectionString = strConexao;
                    conexao.Open();
                    return conexao;
                }else
                {
                    String strConexao = @"Data Source=" + Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=Livraria;Persist Security Info=True;User ID=sa;Password=12345";
                    conexao.ConnectionString = strConexao;
                    conexao.Open();
                    return conexao;
                }
            }
            catch (Exception)
            {
                desconectar();
                return null;
            }
        }

        public void desconectar()
        {
            try
            {
                if ((conexao.State == ConnectionState.Open))
                {
                    conexao.Close();
                    conexao.Dispose();
                    conexao = null;
                }
            }
            catch (Exception) { }
        }

        public DataTable executarSQL(String comando_sql)
        {
            try
            {
                conectar();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
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
                desconectar();
            }
        }

        public bool manutencaoDB(String comando_sql) //incluir, alterar, excluir
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = comando_sql;
                comando.Connection = conexao;
                comando.ExecuteScalar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                desconectar();
            }
        }
    } 
}
