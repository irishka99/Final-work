// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// //  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// //  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// //  лучше обойтись исключительно массивами.

// // Примеры:
// // [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// // [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// // [“Russia”, “Denmark”, “Kazan”] → []

// string[] stringArray = { "Hello", "Dog", "69", ":)" };
// int size = stringArray.Length;
// int resultSize = 0;

// int FindResultSize(string[] Array)
// {
//     int result = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if (Array[i].Length <= 3)
//         {
//             result++;
//         }
//     }
//     return result;
// }

// string[] FillResultArray()
// {
//     string[] resultStringArray = new string[resultSize];
//     int j = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if (stringArray[i].Length <= 3)
//         {
//             resultStringArray[j] = stringArray[i];
//             j++;
//         }
//     }
//     return resultStringArray;
// }

// void PrintResultArray(string[] array)
// {
//     for (int j = 0; j < resultSize; j++)
//     {
//         Console.WriteLine($"{array[j]}");
//     }
// }

// resultSize = FindResultSize(stringArray);
// PrintResultArray(FillResultArray());



