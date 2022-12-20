// Напишите программу, которая выводит третью цифру заданного числа или собщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int storage = a;
while (storage >= 1000)
{
    storage = storage / 10;
}
if (storage >= 100 && storage <= 999)
{
    int digit1 = storage % 10;
    Console.WriteLine($"Ваше число: {digit1}");
}
else
{
    Console.WriteLine("Третьей цифры нет!!!");
}