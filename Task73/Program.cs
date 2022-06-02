// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int a = new Random().Next(-9,9);
Console.WriteLine(a);
int b = new Random().Next(-9,9);
Console.WriteLine(b);
int n = 6;

// 2,3,5,8,13,21

int SumOfNumbers(int number1, int number2, int amount)
{
    if (amount == 2)
        return number2;
    if (amount == 1)
        return number1;
    else
    {
        return SumOfNumbers(number1,number2,amount - 1) + SumOfNumbers(number1,number2,amount - 2);
    }
}

for (int i = 1; i <= n; i++)
{
Console.Write(SumOfNumbers(a,b,i) + " ");
}