using System;

namespace ProjetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora("03/06/2024");
            calc.Somar(4, 3);
            var res = calc.historico();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }

    }

}
