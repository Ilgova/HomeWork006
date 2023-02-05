// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите M чисел через пробел: ");
int[] myArray = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
int result = 0;
ShowArray(myArray);
 void ShowArray(int[] myArray)
 {
    Console.Write("Введенные М чисел с клавиатуры : ");
    for (int i = 0; i < myArray.Length; i++)
    Console.Write($"{myArray[i]}, ");
 }

 

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        result++;
    }
}
 
Console.Write($"-> {result} чисел больше 0");
//Console.Write(result);