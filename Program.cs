using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    class Progam
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Olá, bem vindo!");
            Console.WriteLine("Este programa vai te informar se você tem direto a passagem com desconto ou gratuita na cidade de Camaçari-BA.");
            
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Você é estudante? digite 1 para sim e 2 para não. ");
            Console.WriteLine("Digite 1 para sim e 2 para não. ");
            int estudante = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Você é uma pessoa com deficiencia em situação de vunerabilidade econoimica?");
            Console.WriteLine("Digite 1 para sim e 2 para não.");
            int deficiente = int.Parse(Console.ReadLine()!);

            if(idade >= 65 && deficiente == 1)
            {
                Console.WriteLine("Vocé tem direito a pasagem gratuita. Por ter 65 anos ou mais e ser dficiente de baixa renda.");

            }
            else if(idade <=5 && deficiente == 1)
            {
                Console.WriteLine("Vocé tem direito a pasagem gratuita. Por ter 5 anos ou menos e ser dficiente de baixa renda.");

            }
            else if (idade >= 65)
            {
                Console.WriteLine("Você tem direito a passagem gratuita por ter 65 anos ou mais.");

            }
            else if (idade <= 5)
            {
                Console.WriteLine("Você tem direito a passagem gratuita por ter 5 anos ou menos.");

            }            
            else if (deficiente == 1)
            {
                Console.WriteLine("Você tem direito a passagem gratuita por ser deficiente em situação de vunrabilidade economica.");

            }
            else if (estudante == 1)
            {
                Console.WriteLine("Você tem direito a meia passagem por ser estudante.");

            }
            else
            {
                Console.WriteLine("Você não tem direito a passe livre ou desconto na passagem.");

            }

        }
    }
}