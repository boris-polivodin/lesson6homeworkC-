/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
class Program {
  public static void Main(string[] args) {
    double firstAngularCoefficient = Prompt("Введите коэффициент K первой прямой: ");
    double firstFreeCoefficient = Prompt("Введите коэффициент B первой прямой: ");
    double secondAngularCoefficient = Prompt("Введите коэффициент K второй прямой: ");
    double secondFreeCoefficient = Prompt("Введите коэффициент B второй прямой: ");

    if (firstAngularCoefficient == secondAngularCoefficient) {
      Console.WriteLine("Прямые не пересекаются.");
    }
    else {
      FindIntersection(firstAngularCoefficient, firstFreeCoefficient, secondAngularCoefficient, secondFreeCoefficient);
    }
  }
  static double Prompt(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine();
    double number;
    bool isNumber = double.TryParse(readInput, out number);
    return number;
  }

  static void FindIntersection(double k1, double b1, double k2, double b2) {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями y = {k1} * x + {b1}, y = {k2} * x + {b2}"); 
    Console.WriteLine($"имеет координаты ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
  }
}
