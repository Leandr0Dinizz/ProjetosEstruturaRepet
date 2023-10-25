using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Model
    {
        public double[] notas;//Declaração de um Vetor
        public int[] vetor;
        public int i;
        private double soma;
        public int[] vet3;
        public double[] vet4;
        public Model()
        {
            notas = new double[10];
            vetor = new int[5];//INSTANCIAR == EXISTIR
            vet3  =  new int[10];
            vet4 = new double[20];
            i = 0;
            ConsultarSoma = 0;
        }//Fim do construtor

        public double ConsultarSoma
        {
            get { return soma; }
            set { soma = value; }
        }//Fim do get set

        //Guardar 10 notas de alunos diferentes
        public double MediaNotas()
        {
            for (i = 0; i < 10; i++)
            {
                do {
                    Console.WriteLine(i + 1 + "ª Nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    if ((notas[i] < 0) || (notas[i] > 10))
                    {

                        Console.WriteLine("Digite uma nota entre 0 e 10");

                    }//fim validação
                }while ((notas[i] < 0) || (notas[i] > 10));
                ConsultarSoma += notas[i];
            }//Fim do for
            return ConsultarSoma / i;
        }//Fim do método

        //Ler um vetor de 5 posições e mostrar em ordem inversa
        public void PreencherVetor()
        {

            for (i=0; i <5; i++) 
            {

                Console.WriteLine(i+1 + "º Posição: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());//Preenchendo o vetor
            }//fim do for

        }//Fim do método

        public void MostrarVetor()
        {
            Console.WriteLine("Entrei na mostrar");
            for(i=4; i >=0; i--)
            {

                Console.WriteLine(i+1 + "ª Posição: " + vetor[i]);
                

            }//fim do for

        }//Fim do mostrar

        //Exercicio 3 - 2 Ler um vetor de 10 elementos e mostre apenas os números pares.

        public void PreencherVet3()
        {
            
            for (i = 0; i < 10; i++) 
            {
                Console.WriteLine(i+1 + "ªPosição: ");
                vet3[i] = Convert.ToInt32(Console.ReadLine());
                

            }//Fim do FOR
        }//fim do método

        public void MostrarVet3()
        {
            for (i=0; i < 10; i++)            
            if ((vet3[i] % 2) == 0)
            {
                Console.WriteLine(vet3[i] + " é PAR ");
            }
        }//Fim mostrar vet

        public void MediaValores()
        {

            for (i=0; i < 20; i++)
            {

                do
                {

                    Console.WriteLine(i + 1 + "ª Posição: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    if ((vet4[i] < 0) || (vet4[i] > 20))
                    {

                        Console.WriteLine("Digite uma valor entre 0 e 20");
                    }

                } while ((vet4[i] > 0 || vet4[i] < 20));
            }//Fim do for


        }//Fim do método

















        public bool Validar(double num)
        {

            if (num < 0)
            {
                return false;
            }
            else
            {
                return true;
            }                  
        }//Fim do validar



    }//Fim da classe
}//Fim do Projeto


    

