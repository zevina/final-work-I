/* Задача:
Написать программу, которая из меющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

Console.WriteLine("Введите элементы массива поочередно, разделяя между собой пробелом");
string userArray = Console.ReadLine() ?? "";


string[] SearchStringInArray(string user, int num)
{
  string[] finArray = user.Split(" ");
  for (int i = 0; i < finArray.Length; i++)
  {
    if (finArray[i].Length > num)
      finArray[i] = string.Empty;
  }
  finArray = finArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
  return finArray;
}

Console.WriteLine("Введите длину искомых элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
string[] finalArray = SearchStringInArray(userArray, n);
Console.WriteLine($"Массив из строк, длина которых меньше либо равна {n}: [ {string.Join(", ", finalArray)} ]");