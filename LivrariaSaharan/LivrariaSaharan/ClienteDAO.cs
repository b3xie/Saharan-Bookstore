using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LivrariaSaharan
{
    class ClienteDAO
    {
       

        private DataSet bdDataSet; //MySQL

        // vamos obter a conexão com o banco de dados
        SqlConnection conn = ConexaoBD.obterConexao();

        public void criar(Cliente cliente)
        {
            bdDataSet = new DataSet();
            String cli = cliente.nome, tel = cliente.fone, mail = cliente.email,cpf = cliente.cpf, uf = cliente.uf,
                cidade = cliente.cidade, bairro = cliente.bairro, cep = cliente.cep, endereco = cliente.endereco, complemento = cliente.complemento; 
            //Verifica se a conexão está aberta
            if (conn.State == ConnectionState.Open)
            {
                //Se estiver aberta insere os dados na BD
               SqlCommand commS = new SqlCommand("INSERT INTO cliente VALUES" +
                   "('" + cli + "','" + tel + "','" + mail + "','" + cpf + "','" + uf + "','" + cidade + "','" + bairro + "','" + cep + "','" + endereco + "','" + complemento + "')", conn);
                commS.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Registro inserido");
            }

        }

        public void listar(int id)
        {
            Cliente cliente = new Cliente();
            cliente.id = id;
            SqlCommand cmd = new SqlCommand("SELECT * FROM cliente WHERE ID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            //conn.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cliente.id=int.Parse(reader[0].ToString());
                    cliente.nome=reader[1].ToString();
                    cliente.fone=reader[2].ToString();
                    cliente.email=reader[3].ToString();
                    cliente.cpf = reader[4].ToString();
                    cliente.uf = reader[5].ToString();
                    cliente.cidade = reader[6].ToString();
                    cliente.bairro = reader[7].ToString();
                    cliente.cep = reader[8].ToString();
                    cliente.endereco = reader[9].ToString();
                    cliente.complemento = reader[10].ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com o Id informado!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }

        public void excluir(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tblCliente WHERE idCliente=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void excluirFunc(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tblFuncionario WHERE idFuncionario=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.CommandType = CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void atualizar(Cliente cliente)
        {

            SqlCommand cmd = new SqlCommand("UPDATE CLIENTE SET nome=@Nome, fone=@Fone, email=@Email where ID=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", cliente.id);
            cmd.Parameters.AddWithValue("@Nome", cliente.nome);
            cmd.Parameters.AddWithValue("@Fone", cliente.fone);
            cmd.Parameters.AddWithValue("@Email", cliente.email);
            cmd.Parameters.AddWithValue("@Cpf", cliente.email);
            cmd.Parameters.AddWithValue("@Uf", cliente.uf);
            cmd.Parameters.AddWithValue("@Cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@Bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@Cep", cliente.cep);
            cmd.Parameters.AddWithValue("@Endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@Complemento", cliente.complemento);
            cmd.CommandType = CommandType.Text;
           // conn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
