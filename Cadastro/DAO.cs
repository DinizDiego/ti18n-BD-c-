using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Cadastro
{
    class DAO
    {
        public MySqlConnection conexao;//COnectar ao banco de dados 
        public string dados;
        public string sql;
        public string resultado;
        public DAO()
        {

            conexao = new MySqlConnection("server=localhost;DataBase=ti18nPessoa;Uid=root;Password=");
            try
            {
                conexao.Open();//Abri a conexão com o DB
                Console.WriteLine("Conectado com sucesso!");
            }
            catch (Exception erro) 
            {
                Console.WriteLine("Algo deu errado! Verifique a conexão!\n\n" + erro);
                conexao.Close();//Fechar a conexão com o DB
            }//FIm do try catch
        }//Fim do método

        //Método inserir

        public void inserir(string nome, string telefone, string cidade, string endereco)
        {
            try
            {
            
                dados = "('','" + nome + "','" + telefone + "','" + cidade + "','" + endereco + "')";
                sql = "insert into Pessoa(codigo, nome, telefone, cidade, endereco) values" + dados;

                MySqlCommand conn = new MySqlCommand(sql, conexao);//Prepara a execução no banco de dados
                resultado = "" + conn.ExecuteNonQuery();//Ctrl + Enter -> executando o comando no banco de dados
                Console.WriteLine(resultado + "Linha afetada");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro!!! Algo deu errado\n\n\n" + erro);
            }//Fim do try catch
        }//Fim do método


    }//Fim da classe
}//Fim do projeto
