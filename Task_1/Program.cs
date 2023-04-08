// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Введите число a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите число b: ");
    int b = int.Parse(Console.ReadLine());
    int result = 1;
    for (int i = 0; i < b; i++) {
        result *= a;
    }
    Console.WriteLine("Результат: " + result);
  }
}
