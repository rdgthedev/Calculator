using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace Calculator
{
    public static class Draw
    {
        public static void DrawMenu()
        {
            TopLines();
            LeftAndRightSide();
            BottomLines();
        }

        private static void TopLines()
        {
            Console.Write("+");
            for (int i = 0; i <= 28; i++)
                Console.Write("-");
            Console.Write("+");
            Console.WriteLine();
        }

        private static void LeftAndRightSide()
        {
            for (int i = 0; i <= 8; i++)
                Console.WriteLine("|\t\t\t      |");
        }

        private static void BottomLines()
        {
            Console.Write("+");
            for (int i = 0; i <= 28; i++)
                Console.Write("-");
            Console.Write("+");
        }
    }
}