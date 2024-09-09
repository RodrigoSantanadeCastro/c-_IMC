using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("Aplicativo de Índice de Massa Corporal");
            Console.WriteLine("================================");
            int i = 1;
            while (i == 1)
            {

                Console.WriteLine("Digite o seu nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual é sua altura ?");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual é o seu peso ?");
                double peso = double.Parse(Console.ReadLine());
                double result = peso/(altura * altura);

                if (result < 16) 
                    {
                    Console.WriteLine("{0} seu IMC indica, magreza grave, indice de : {1}",nome, result);
                    }
                if (result >= 16 & result <= 16.9)
                    {
                    Console.WriteLine("{0} seu IMC indica, magreza moderada, indice de : {1}",nome, result);
                }
                if (result >= 17 & result <= 18.5)
                {
                    Console.WriteLine(" {0} seu IMC indica, magreza leve, indice de : {1}",nome, result);
                }
                if (result >= 18.5 & result <= 24.9)
                {
                    Console.WriteLine("{0} seu IMC indica, Peso ideal, indice de : {1}",nome, result);
                }
                if (result >= 25 & result <= 29.9)
                {
                    Console.WriteLine("{0} seu IMC indica, Sobrepeso, indice de : {1}",nome, result);
                }
                if (result >= 30 & result <= 34.9)
                {
                    Console.WriteLine("{0} seu IMC indica, Obesidade grau I, indice de : {1}",nome, result);
                }
                if (result >= 35 & result <= 39.9)
                {
                    Console.WriteLine("{0} seu IMC indica, Obesidade grau II ou severa, indice de : {1}",nome, result);
                }
                if (result >= 40)
                {
                    Console.WriteLine("{0} seu IMC indica, Obesidade grau III ou mórbida, indice de :{1}",nome, result);
                }
                Console.WriteLine("Deseja executar o programa novamente ?");
                Console.WriteLine("1- para sim");
                Console.WriteLine("0- Não ");
                i  = int.Parse(Console.ReadLine());

                
            }

            
        }
    }
}
