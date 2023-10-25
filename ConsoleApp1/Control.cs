using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Control
    {

        Model modelo;
        private int opcao;

        public Control()
        {


            this.modelo = new Model();//Criando uma chave
            ConsultarOpcao = -1;


        }//fim do construtor


        public int ConsultarOpcao
        {

            get { return this.opcao; }
            set { this.opcao = value; }

        }//fim do método


        public void Menu()
        {


            Console.WriteLine("Escolha uma das opções abaixo:  \n\n" +
                             "0. Sair\n" +
                             "1. Média de notas 10 alunos\n"         +      
                             "2. Vetor inverso\n"                    +
                             "3. Números páres\n"                    +
                             "4. Média Valores\n"                    +
                             "5. Vetor inverso\n"                    +
                             "6. Vetor inverso\n"                    +
                             "7. Vetor inverso\n"                    +
                             "8. Vetor inverso\n"                    + 
                             "9. Vetor inverso\n");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do menu

        public void Operacao()
        {

            do
            {

                Menu();//mostrar menu
                switch (ConsultarOpcao)
                {

                    case 0:
                        Console.WriteLine("Obrigado!");
                    break;

                    case 1:
                        Console.WriteLine(this.modelo.MediaNotas());
                    break;
                    case 2:
                        this.modelo.PreencherVetor();
                        this.modelo.MostrarVetor();
                        break;
                    case 3:
                        this.modelo.PreencherVet3();
                        this.modelo.MostrarVet3();
                    break;
                    case 4:
                        this.modelo.MediaValores();
                        this.modelo.
                     break;


                    default:










                        Console.WriteLine("Erro , escolha uma opção válida");
                     break;                
                    


                }//Fim do switch
            }while (ConsultarOpcao != 0);
        }//fim metodo operação




    }//fim classe
}//fim projeto
