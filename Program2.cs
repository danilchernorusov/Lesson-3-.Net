using System;

public class Program
{
    public static void Main()
    {
        string number;
        int sumOfDigits = 0;
        do
        {
            Console.Write("Введiть число в дiапазонi вiд 1 до 1000000000: ");
            number = Console.ReadLine();
        } while (Convert.ToInt32(number) < 1 | Convert.ToInt32(number) > 1000000000);


        for (int i = 0; i < number.Length; i++) 
        {
            sumOfDigits += Convert.ToInt32(number[i].ToString());
        }

        Console.WriteLine(sumOfDigits);
    }
}