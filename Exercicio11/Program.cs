/* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.

1 - Cachorro Quente: R$ 4,00
2 - X-Salada: R$ 4,50
3 - X-Bacon: R$ 5,00
4 - Torrada Simples: R$ 2,00
5 - Refrigerante: R$ 1,50

 */

using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int code, amount;
            double total;
            string[] value;

            Console.Write("Digite o código e quantidade: ");
            value = Console.ReadLine().Split(' ');
            code = int.Parse(value[0]);
            amount = int.Parse(value[1]);

            switch (code)
            {
                case 1:
                    total = amount * 4.0;
                    break;
                case 2:
                    total = amount * 4.50;
                    break;
                case 3:
                    total = amount * 5.00;
                    break;
                case 4:
                    total = amount * 2.00;
                    break;
                case 5:
                    total = amount * 1.50;
                    break;
                default:
                    total = 0;
                    Console.WriteLine("Valores incorretos digitados.");
                    break;
            }

            Console.WriteLine($"Total R$ {total.ToString("F2")}");

        }
    }
}