using System;
namespace REC_89
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            var n1=Convert.ToSingle(Console.ReadLine().Replace('.', ','));
            Console.WriteLine("Введите второе число");
            var n2 = Convert.ToSingle(Console.ReadLine().Replace('.', ','));
            Console.WriteLine("Введите третье число");
            var n3 = Convert.ToSingle(Console.ReadLine().Replace('.', ','));
            var maxn = Math.Max(Math.Max(n1, n2), n3);
            Console.WriteLine($"Максимальное число:  {maxn}");
            Console.ReadLine();

        }
    }
}
