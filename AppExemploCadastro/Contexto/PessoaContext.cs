using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppExemploCadastro.Models;

namespace AppExemploCadastro.Contexto
{
    public class PessoaContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        public PessoaContext()
        {
            dados_conexao = "server=localhost;port=3306;database=bd_registro;user=root;password=root;Persist Security Info=False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public void InserirPessoa(Pessoa pessoa)
        {
            try
            {
                conexao.Open();

                string sql = "INSERT INTO PESSOA (Nome, Cpf, RegistroGeral, Email) VALUES (@Nome, @Cpf, @RegistroGeral, @Email)";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                comando.Parameters.AddWithValue("@RegistroGeral", pessoa.RegistroGeral);
                comando.Parameters.AddWithValue("@Email", pessoa.Email);

                int linhasAfestadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir pessoa: " + ex.Message);

            }
            finally
            {
                conexao.Close(); // Fecha as portas do banco, mesmo que ocorra erro
            }
        }


        public void AtualizarPessoa(Pessoa pessoa)
        {
            // Comando SQL para atualizar os dados da pessoa

            try
            {
                conexao.Open(); // Abrir conexão com o banco

                string sql = "UPDATE PESSOA SET Nome = @Nome, Cpf = @Cpf, RegistroGeral = @RegistroGeral, Email = @Email WHERE Id = @Id";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                comando.Parameters.AddWithValue("@RegistroGeral", pessoa.RegistroGeral);
                comando.Parameters.AddWithValue("@Email", pessoa.Email);
                comando.Parameters.AddWithValue("@Id", pessoa.Id); // Identifica qual registro será atualizado

                int linhasAfetadas = comando.ExecuteNonQuery(); // Executa o comando e retorna quantas linhas foram alteradas

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Pessoa atualizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar pessoa: " + ex.Message);
            }
            finally
            {
                conexao.Close(); // Fecha a conexão com o banco
            }
        }


        public void DeletarPessoa(Pessoa pessoa)
        {
            try
            {
                conexao.Open();

                string sql = "delete from pessoa where id = @id";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", pessoa.Id);

                int linhasAfetadas = comando.ExecuteNonQuery();


                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Pessoa deletada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi deletado. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar pessoa: " + ex.Message);

            }
            finally
            {
                conexao.Close();
            }
        }
        
        
        public List<Pessoa> ListarPessoas()
        {
            List<Pessoa> listaPessoaParaExportar = new List<Pessoa>();// para retornar (return) o resutaldo e ser utilizado na aplicação 
            string sql = "SELECT * FROM PESSOA"; //consulta SQL para trazer todas as pessoas
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);//objeto "comando" responsável por ir até o banco e realizar ações

                conexao.Open();//abrir a porta do banco para realizar a consulta

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Id = Convert.ToInt32(dados["Id"]);
                    pessoa.Nome = dados["Nome"].ToString();
                    pessoa.Cpf = dados["Cpf"].ToString();
                    pessoa.RegistroGeral = dados["RegistroGeral"].ToString();
                    pessoa.Email = dados["Email"].ToString();
                    listaPessoaParaExportar.Add(pessoa);
                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
            return listaPessoaParaExportar; 

        }
    }
}








