using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, media;

            Console.WriteLine("Digite a Primeira Nota: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a Segunda Nota: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a Terceira Nota: ");
            nota3 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if (media > 7)
            {
                Console.WriteLine("\nAluno Aprovado");
            }

            else
            {
                Console.WriteLine("\nAluno Reprovado");
            }

            Console.ReadKey();
        }
    }
}
