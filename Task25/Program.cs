// Найти сумму чисел от 1 до А

int A = new Random().Next(1,10);
Console.WriteLine($"Вывод суммы чисел от 1 до {A}");

int summ = 0;

for(int i = 1; i<= A; i++)
{
    summ = summ + i;
}
Console.WriteLine($"Сумма чисел от 1 до {A} равна {summ}");
