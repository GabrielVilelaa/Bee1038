using System;
using System.Globalization;

namespace bee1038
{
    class Program
    {

        static void Main(string[] args)
        {
            int quantidade, codigo;
            double codigo_1 = 4.00;
            double codigo_2 = 4.50;
            double codigo_3 = 5.00;
            double codigo_4 = 2.00;
            double codigo_5 = 1.00;


            Console.WriteLine("CODIGO    ESPECIFICACAO   PREÇO");
            Console.WriteLine(" 1       Cachorro Quente   4.00");
            Console.WriteLine(" 2       X SALADA          4.50");
            Console.WriteLine(" 3       X BACON           5.00");
            Console.WriteLine(" 4       Torrada Simples   2.00");
            Console.WriteLine(" 5       Refrigerante      1.00");

            Console.WriteLine("Digite o codigo do produto e a quantidade");

            string [] cod = (Console.ReadLine().Split(' '));

             codigo = int.Parse(cod[0]);
             quantidade = int.Parse(cod[1]);

            

            if (codigo == 1 )
            {
                double soma = codigo_1 * quantidade;
                Console.WriteLine("Total: R$ " + soma.ToString("F2",CultureInfo.InvariantCulture));
                Console.Read();
            }

            else if (codigo == 2) 
            {
                double soma = codigo_2 * quantidade;
                Console.WriteLine("Total: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.Read();
            }

            else if (codigo == 3)
            {
                double soma = codigo_3 * quantidade;
                Console.WriteLine("Total: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.Read();
            }

            else if (codigo == 4)
            {
                double soma = codigo_4 * quantidade;
                Console.WriteLine("Total: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.Read();
            }

            else  
            {
                double soma = codigo_5 * quantidade;
                Console.WriteLine("Total: R$ " + soma);
                Console.Read();
            }
        }
    }
}
