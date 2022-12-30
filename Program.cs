using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            try
            {
                System.Console.WriteLine("Escolha entre as opções: ");
                System.Console.WriteLine("1: Soma");
                System.Console.WriteLine("2: Subtração");
                System.Console.WriteLine("3: Divisão");
                System.Console.WriteLine("4: Multiplicação");
                System.Console.WriteLine("0: Exit");

                System.Console.Write("> ");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    case 1:
                        Conta('+');
                        break;
                    case 2:
                        Conta('-');
                        break;

                    case 3:
                        Conta('/');
                        break;

                    case 4:
                        Conta('*');
                        break;
                    default:
                        Console.Clear();
                        System.Console.WriteLine("Opção digitada invalida, tente novamente!");
                        System.Console.WriteLine("");
                        Main();
                        break;
                }
            }
            catch
            {
                Console.Clear();
                System.Console.WriteLine("Você não digitou um número, tente de novo");
                System.Console.WriteLine("");
                Main();
            }
        }
        static void Conta(char operador)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor");
            Console.Write("> ");

            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            Console.Write("> ");

            double v2 = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("");
            if (operador == '+')
            {
                System.Console.WriteLine("Soma: " + (v1 + v2));
            }
            else if (operador == '-')
            {
                System.Console.WriteLine("Subtração: " + (v1 - v2));
            }
            else if (operador == '/')
            {
                System.Console.WriteLine("Divisão: " + (v1 / v2));
            }
            else if (operador == '*')
            {
                System.Console.WriteLine("Multiplicação: " + (v1 * v2));
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Presione qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}