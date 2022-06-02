// Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число: ");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
Console.Write("Введите второе число: ");
string b = Console.ReadLine();
int numberB = Convert.ToInt32(b);

if (numberB > numberA)
{
    Console.Write("Большее число: ");
    Console.WriteLine(numberB);
    Console.Write("Меньшее число: ");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("Большее число: ");
    Console.WriteLine(numberA);
    Console.Write("Меньшее число: ");
    Console.WriteLine(numberB);
}