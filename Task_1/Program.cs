// Задача 66:
// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

void Main()
{
    int M = ReadInt("Введите начальное значение M: ");
    int N = ReadInt("Введите конечное значение N: ");
    if (M < N)
    {
       System.Console.WriteLine (Sum (M, N));
    }
    else System.Console.WriteLine (Sum (N, M));
}

Main();

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int M, int N)
{
    if (M == N) return M;
    return M + Sum (M + 1, N);
}