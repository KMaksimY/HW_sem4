using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers1 = {1, 2, 5, 7, 19};
        int[] numbers2 = {6, 1, 33};

        Console.WriteLine("Массив numbers1: [{0}]", string.Join(", ", numbers1));
        Console.WriteLine("Массив numbers2: [{0}]", string.Join(", ", numbers2));
    }
}
