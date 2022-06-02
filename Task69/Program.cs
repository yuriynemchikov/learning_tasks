// Найти сумму элементов от M до N, N и M заданы

int m = 10;
int n = 11;
int sum = 0;

int SumNumbersMtoN(int number1, int number2)
{
    if(number1 == number2)
    return number1;
    else 
    {
       sum = SumNumbersMtoN(number1+1, number2);
       sum += number1;
       return sum;
    }   
}

Console.WriteLine(SumNumbersMtoN(m, n));

