final-work-I

# Контрольная работа по итогам 1 четверти

## Условие задачи

Написать программу, которая из меющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  
<br />

---

## Алгоритм решения задачи

0. Составляем блок-схему:  
   <br />
   ![Блок-схема](FinalWork_I.png 'Блок-схема')
1. Принимаем от пользователя массив строк, разделенных пробелом и сохраняем эти данные в строку:

   ```c#
   Console.WriteLine("Введите элементы массива поочередно, разделяя между собой запятой");
   string userArray = Console.ReadLine() ?? "";
   ```

1. Создаем метод для поиска элементов, длина которых меньше либо равна длине, заданной в условиях задачи (3):

   ```c#
   string[] SearchStringInArray(string user, int num)
   ```

   2.1. Создаем новый массив, элементами которого будут строки, полученные из исходной строки по заданному разделителю (запятая):

   ```c#
   string[] finArray = user.Split(",");
   ```

   2.2 При помощи цикла проверяем длину каждого элемента из нового массива и в случае, если длина > 3 или элемент является пробелом, заменяем элемент пустой строкой:

   ```c#
   for (int i = 0; i < finArray.Length; i++)
   {
     if (finArray[i].Length > num || finArray[i] == " ")
       finArray[i] = string.Empty;
   }
   ```

   2.3 Фильруем массив, отбрасывая пустые элементы:

   ```c#
   finArray = finArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
   ```

   2.4 Возвращаем полученный массив:

   ```c#
   return finArray;
   ```

1. Создаем массив, используя вышеописанный метод. Аргументами метода являются строка от пользователя и заданная в условиях задачи длина строки:

   ```c#
   string[] finalArray = SearchStringInArray(userArray, 3);
   ```

1. Выводим итоговый массив в консоль:

   ```c#
   Console.WriteLine($"Массив из строк, длина которых меньше либо равна 3: [ {string.Join(", ", finalArray)} ]");
   ```
