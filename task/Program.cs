/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
  лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] newArray = { "-32", "тест", "задача", "123", "задание", "++", "семинар", "***", "-2", "abc", "task" };
GetArray(newArray);
Console.WriteLine();
SortArray(newArray);
void GetArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ", "");

    };
}
void SortArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int length = array[i].Length;

        if (length <= 3)
        {
            Console.Write($"{array[i]} ", " ");
        }


    }
}
;




