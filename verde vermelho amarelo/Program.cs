using System;

namespace verde_vermelho_amarelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um código que pergunte “Qual é a cor (VERDE/AMARELO/VERMELHO)?”. Se for escolhida a cor VERDE, imprima “Siga em frente”; se for escolhida a opção AMARELO, imprima “Atenção”; e, se for escolhido VERMELHO, imprima “Pare”. 

            string cor = "";

            Console.Write("Qual a cor do sinal? (verde, amarelo, vermelho): ");
            cor = Console.ReadLine();

            switch (cor)
            {
            case "verde":
                Console.Write("Siga em frente");
                    break;

            case "amarelo":
                Console.Write("Pare!");
                    break;

            case "vermelho":
                Console.Write("Atenção!");
                    break;

            default: 
                Console.WriteLine("Escolha somente entre as cores 'verde, vermelho e amarelo'.");
                    break;
            }
        }
    }
}
