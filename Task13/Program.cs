// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine($"Число {num1} кратно числу {num2}");
}
else
{
    Console.Write($"Остаток от деления - {num1%num2}");
}
