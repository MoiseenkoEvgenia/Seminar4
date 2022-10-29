// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите количество элементов массива:\t");
int count = int.Parse(Console.ReadLine());
int[] array = new int[count];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива: ");
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
     Console.Write($"{array[i]}, ");
}
Console.Write("\b\b");
Console.Write("]");
Console.Read();