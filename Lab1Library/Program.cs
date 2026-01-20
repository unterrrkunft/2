using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Денисюк Анастасія");
        Console.WriteLine("Група: 41КН");
        Console.WriteLine();

        Console.Write("Введіть довжину основи паралелограма: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть висоту паралелограма: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double area = a * h;

        Console.WriteLine();
        Console.WriteLine($"Площа паралелограма = {area}");

        Console.ReadLine();
    }
}