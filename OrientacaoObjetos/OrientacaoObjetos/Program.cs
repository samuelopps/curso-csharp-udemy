using System;
using System.Globalization;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre o número da conta:");
            string account = Console.ReadLine();

            Console.WriteLine("Entre o titular da conta:");
            string name = Console.ReadLine();

            ContaBancaria bc = new ContaBancaria(account, name);

            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char check = char.Parse(Console.ReadLine());

            if (check == 's')
            {
                Console.WriteLine("Entre o valor de depósito inicial:");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                bc = new ContaBancaria(account, name, deposit);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(bc);

            Console.WriteLine("Entre um valor para depósito:");
            bc.addValue(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(bc);


            Console.WriteLine("Entre um valor para saque:");
            bc.subtractValue(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(bc);



            Console.ReadLine();
        }
    }
}