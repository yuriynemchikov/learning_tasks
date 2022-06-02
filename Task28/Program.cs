// Подсчитать сумму цифр в числе

int number = new Random().Next(1,100000);
Console.WriteLine($"Number is {number}");

int sum = 0;
int A = number;

while(number>0)
{
    A = number % 10;
    sum += A;
    number /= 10;
}

Console.WriteLine(sum);