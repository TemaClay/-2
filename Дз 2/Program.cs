using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number / 10 % 10);
    }
}