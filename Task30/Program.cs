// Показать кубы чисел, заканчивающихся на четную цифру

int number = new Random().Next(1,100);
Console.WriteLine(number);

for(int i = 1; i <= number; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine($"Куб числа {i} равен {Math.Pow(i, 3)}");
    }
}
