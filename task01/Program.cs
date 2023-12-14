// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if(M > N) return;
    System.Console.Write(M + " ");
    PrintNumbers(M + 1, N);

}

int M = ReadInt("введите меньшее число:");
int N = ReadInt("введите большее число:");
if (M < N)
{
PrintNumbers(M,N);
}
else System.Console.WriteLine("некорректные числа");


