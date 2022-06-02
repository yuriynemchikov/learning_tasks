// Найти максимальное из трех чисел

Console.Write("Введите первое число: ");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
Console.Write("Введите второе число: ");
string b = Console.ReadLine();
int numberB = Convert.ToInt32(b);
Console.Write("Введите третье число: ");
string c = Console.ReadLine();
int numberC = Convert.ToInt32(c);
int max = numberA;

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.Write("Максимальное число: ");
Console.Write(max);

