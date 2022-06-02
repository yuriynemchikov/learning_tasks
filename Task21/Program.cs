// Программа проверяет пятизначное число на палиндромон.

Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string num = a.ToString();
int[] number = new int[5];

if(a.ToString().Length!=5)
{
    Console.WriteLine("введите 5-значное число");
    return;
}

for(int i=0; i<5; i++)
{
    number[i] = int.Parse(num[i].ToString());
}

int j = 0;
while (j<2)
{
    if(number[j] != number[4-j])
    {
        Console.WriteLine("Число не является палиндромом");
        return;
    }
    j++;
}
Console.WriteLine("Число является палиндромом");
