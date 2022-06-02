// Написать программу вычисления произведения чисел от 1 до N

int A = new Random().Next(1,10);
Console.WriteLine($"Number is {A}");

int result = 1;

for (int i=1; i <= A; i++)
{
    result *= i;
}

Console.WriteLine(result);
