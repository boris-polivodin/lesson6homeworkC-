/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
class Program {
  public static void Main(string[] args) {
    int quantity = Prompt("Какое количество чисел хотите ввести? ");
    int count = 0;
    for (int counter = 1; counter <= quantity; counter++) {
      if (Prompt($"Введите {counter}-e число: ") > 0) count++;
    }
    Console.WriteLine($"Количество положительных чисел: {count}");
  }

  static int Prompt(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine() ?? "null";
    int number;
    bool isNumber = int.TryParse(readInput, out number);
    return number;
  }
}
