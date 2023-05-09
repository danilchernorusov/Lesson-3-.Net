using System;

public class Program
{
    public static void Main()
    {
        int maxNumber, minNumber;
        Console.Write("Введiть максимальне значеня дiапазону: ");
        maxNumber = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.Write("Введiть мiнемальне значеня дiапазону: ");
            minNumber = Convert.ToInt32(Console.ReadLine());
        } while (minNumber >= maxNumber);


        for (int i = maxNumber; i >= minNumber; i--)
        {
            Console.WriteLine(i);
        }
    }
}