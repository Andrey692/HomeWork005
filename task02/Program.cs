// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Aker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Aker(m - 1, 1);
    else return Aker(m - 1, Aker(m, n - 1));
}

int m = ReadInt("введите первое число:");
int n = ReadInt("введите второе число:");
if (m >= 0 && n >= 0)
{
    System.Console.WriteLine(Aker(m, n));
}
else
{
    System.Console.WriteLine("недопустимо отрицательное число!");
}
