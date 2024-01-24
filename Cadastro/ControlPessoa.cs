using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class ControlPessoa
    {
        private int opcao = 0;
        DAO conectar;
        public ControlPessoa() 
        {
            ConsultarOpcao = 0;  
            conectar = new DAO(); //Conectando com o banco de dados
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value;  }
        }//fim do getSet

        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n" +
                              "1. Cadastrar\n" +
                              "2. Consultar\n" +
                              "3. Atualizar\n" +
                              "4. Excluir\n" +
                              "5. Sair");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do Menu

        public void operacao()
        {
            do
            {
                Menu();//Mostrar as opções para o usuário
                switch (ConsultarOpcao)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        //Consultar
                        break;
                    case 3:
                        //Atualizar
                        break;
                    case 4:
                        //Excluir
                        break;
                    case 5:
                        //Agradecer
                        Console.WriteLine("Obrigado!");
                        break;
                    default:
                        Console.WriteLine("Informe um código de acordo com o menu");
                        break;
                }//Fim do escolha caso
            } while (ConsultarOpcao != 5);
        }//fim do método

        public void Cadastrar()
        {
            Console.WriteLine("Informe o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o telefone da pessoa: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Informe o nome da cidade da pessoa: ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Informe o endereço da pessoa: ");
            string endereco = Console.ReadLine();
            //Dados que vou inserir no BD
            conectar.inserir(nome, telefone, cidade, endereco);

        }//Fim do método cadastrar

    }//Fim da classe
}//Fim do Projeto
