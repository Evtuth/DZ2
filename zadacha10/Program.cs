// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите любое трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 && a <= 999)
{
    int digit1 = a % 100;
    int digit2 = digit1 % 10;
    int digit3 = (digit1 - digit2) / 10;
    Console.WriteLine($"Ваше число: {digit3}");
}
else
{
    Console.WriteLine("Неверное число!!!");
}
