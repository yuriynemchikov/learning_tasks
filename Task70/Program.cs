// Найти сумму цифр числа

int number = new Random().Next(10,1000);
Console.WriteLine($"numer is {number}");

int SumOfDigits(int num)
{
    if(num < 10)
    return num;
    else
    {
        return SumOfDigits(num/10) + num % 10;
    }
}
Console.Write("Sum of digits of the number is ");
Console.WriteLine(SumOfDigits(number));