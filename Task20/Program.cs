// Задать номер четверти, показать диапазоны для возможных координат

String[] quarters = {"first is x>0 & y>0","second is x<0 & y>0","third is x<0 & y<0","forth is x>0 & y<0"};

Console.WriteLine("Enter quarter number: ");
int Quarter = int.Parse(Console.ReadLine());

Console.Clear();

if(Quarter>0 && Quarter<=4)
{
    Console.WriteLine(quarters[Quarter - 1]);
}
else
{
    Console.WriteLine("There are only 4 quarters, enter valid number");
}




