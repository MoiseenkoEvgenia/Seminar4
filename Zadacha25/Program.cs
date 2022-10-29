// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ChislovStepeni(int a, int b)
{
    int rezult = 1;
    for (int i = 1; i <= b; i++)
    {
        rezult = rezult * a;
    }
    return rezult;
}

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

int chislovStepeni = ChislovStepeni(a, b);
Console.WriteLine($"Ответ: {chislovStepeni}");