// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        string number = Console.ReadLine();

        int sum = 0;
        foreach (char digit in number)
        {
            sum += int.Parse(digit.ToString());
        }

        Console.WriteLine("Сумма цифр в числе: " + sum);
    }
}