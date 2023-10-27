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
        public int[] vet15;
        public double[] vet16;
        public double[] maior7;
        public Model()
        {
            notas = new double[10];
            vetor = new int[5];//INSTANCIAR == EXISTIR
            vet3  =  new int[10];
            vet4 = new double[20];
            vet15 = new int[15];
            vet16 = new double[25];
            maior7 = new double[25];
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

        //Exercicio 2 - 2 Ler um vetor de 10 elementos e mostre apenas os números pares.

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



       // EX3- MEDIA VALORES   
        public double MediaValores()
        {
            for (i = 0; i < 20; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Posição: ");
                    vet4[i] = Convert.ToDouble(Console.ReadLine());
                    if ((vet4[i] < 0) || (vet4[i] > 20))
                    {

                        Console.WriteLine("Digite um número válido");

                    }//fim validação
                } while ((vet4[i] < 0) || (vet4[i] > 20));
                ConsultarSoma += vet4[i];
            }//Fim do for
            return ConsultarSoma / i;
        }//Fim do método

        public void PreencherValores()
        {
            for (i=0; i < 20; i++)
            {


            }//fim for
         
        }//Fim do método

     //EX 4 - NUMEROS PARES      
        public void PreencherVet15()
        {

            for (i = 0; i < 15; i++)
            {

                Console.WriteLine(i + 1 + " ªPosição ");
                vet15[i] = Convert.ToInt32(Console.ReadLine());
               
            }//Fim do for
        }//Fim do método preencher15

        public void MostrarVet15()
        {

            for (i = 0; i < 15; i++)
            if ((vet15[i] % 2) ==0)
            {
                    
                    Console.WriteLine(" O valor : " + vet15[i] + " é par");

            }//fim do for

        }//fim do método

        //EX 5 25 ELEMENTOS MOSTRE MAIOR VALOR E POSIÇAO
        public void PreencherElementos()
        {

            for (i=0; i<25 ; i++)
            {

                Console.WriteLine(i+1 + " ºelemento ");
                vet16[i] = Convert.ToInt32(Console.ReadLine());           
            }//fim do for

        }// fim public

        public void MaiorElemento()
        {

            for (i=0; i<25; i++)
            {

                Console.WriteLine(i+1 + "Valor");
                vet16[i] = Convert.ToDouble(Console.ReadLine());
                maior7 =
                for (i=0; i<25; i++)
                {

                    Console.WriteLine(i+1 +" Valor ");
                    vet16[i] = Convert.ToDouble(Console.ReadLine());


                }



            }



        }
        


                 
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


    

