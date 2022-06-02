// Показать натуральные числа от 1 до N, N задано

int userNumber = 10;

string ShowNumbers(int Number)
{
    if(Number == 1)
    return "" + Number;
    else 
    {
        return ShowNumbers(Number - 1) + " " + Number;
    }   
}

Console.WriteLine(ShowNumbers(userNumber));