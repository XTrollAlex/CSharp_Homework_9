// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System.Threading;

Thread T = new Thread(Main, 16777216); //16 Mb стэк работает до значений 4,1 и 3,14
T.Start();

void Main()
{
    
    int M = ReadInt("Введите значение M: ");
    int N = ReadInt("Введите значение N: ");
    System.Console.WriteLine($" {Akkerman (M, N)}");
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (M > 0 && N == 0) return Akkerman(M - 1, 1);
    else return Akkerman (M - 1, Akkerman (M, N - 1));
}