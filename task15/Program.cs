// Напишите программу, которая:
// принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

void DayNumber (int number) {
  if (number == 6 || number == 7) {
  Console.WriteLine("Этот день выходной");
  }
  else if (number < 1 || number > 7) {
    Console.WriteLine("Такого дня недели не существует");
  }
  else Console.WriteLine("Это будний день");
}

DayNumber(number);
