// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int N = new Random().Next(10, 99);
Console.WriteLine(N);
int first = N%10;
int second = N/10;

if (first > second)
{
    Console.Write("Наибольшая цифра - ");
    Console.Write(first);
}
else
{
    Console.Write("Наибольшая цифра - ");
    Console.Write(second);
}