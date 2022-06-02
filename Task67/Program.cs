// Показать натуральные числа от N до 1, N задано

int userNumber = 10;

string ShowNumbers(int Number)
{
    if(Number == 1)
    return "" + Number;
    else 
    {
        return Number + " " +  ShowNumbers(Number - 1);
    }   
}

Console.WriteLine(ShowNumbers(userNumber));