// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Enter first number: ");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int second = int.Parse(Console.ReadLine());

if(Math.Sqrt(first) == second)
{
    Console.WriteLine($"Число {first} является квадратом числа {second}");
}    
else    
{
if(Math.Sqrt(second) == first)
{
    Console.WriteLine($"Число {second} является квадратом числа {first}");
}
else
    {   
        Console.WriteLine("Заданные числа не являются квадратами другого");
    }
}    