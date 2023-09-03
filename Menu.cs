using System.Runtime.InteropServices;

namespace Calculator
{
    public static class Menu
    {
        public static void Show()
        {
            try
            {
                while (true)
                {
                    Draw.DrawMenu();
                    Options();
                }
            }
            catch (DivideByZeroException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.WriteLine("\nAperte a tecla \"Enter\" para retornar ao Menu ...");
                ConsoleKeyInfo info = Console.ReadKey();

                while (info.Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Aperte a tecla \"Enter\" para retornar ao Menu ...");
                    info = Console.ReadKey();
                }

                Show();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Tome cuidado com o que digita!!\n");
                Console.WriteLine("Aperte a tecla \"Enter\" para retornar ao Menu ...");
                ConsoleKeyInfo info = Console.ReadKey();

                while (info.Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Aperte a tecla \"Enter\" para retornar ao Menu ...");
                    info = Console.ReadKey();
                }

                Show();
            }
        }

        private static void Options()
        {
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("\tCalculator");
            Console.WriteLine();
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("1 - Sum");
            Console.SetCursorPosition(1, 4);
            Console.WriteLine("2 - Subtraction");
            Console.SetCursorPosition(1, 5);
            Console.WriteLine("3 - Division");
            Console.SetCursorPosition(1, 6);
            Console.WriteLine("4 - Multiplication");
            Console.SetCursorPosition(1, 7);
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            Console.SetCursorPosition(1, 9);
            Console.Write("Digite a opção que deseja: ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    Calculator.Sum();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Calculator.Subtraction();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Calculator.Division();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Calculator.Multiplication();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Saindo ...");
                    Console.WriteLine();
                    Console.WriteLine("Volte sempre!!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }

    }
}
