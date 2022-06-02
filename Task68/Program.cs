// Показать натуральные числа от M до N, N и M заданы

int m = 10;
int n = 20;

void ShowNumbersMtoN(int number1, int number2)
{
    Console.Write(number1 + " ");
    if(number1 == number2)
    return;
    else 
    {
        if(number1 < number2)
        {
            ShowNumbersMtoN(number1 + 1, number2);
        }
        else
        {
            ShowNumbersMtoN(number1 - 1, number2);
        }
    }   

}

ShowNumbersMtoN(m, n);
