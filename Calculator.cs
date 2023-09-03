using System.Globalization;

namespace Calculator
{
    public static class Calculator
    {
        public static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;
            Console.WriteLine($"O resultado da some é: {result}");
        }

        public static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;
            Console.WriteLine($"O resultado da some é: {result}");
        }


        public static void Division()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            if (v2 == 0)
                throw new DivideByZeroException("Nao é possível dividir um numero por zero!!");

            float result = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {result}");
        }

        public static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;
            Console.WriteLine($"O resultado da some é: {result}");
        }

    }
}