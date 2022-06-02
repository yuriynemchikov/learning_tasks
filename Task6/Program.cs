// Выяснить является ли число чётным

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);

if(a %2== 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}