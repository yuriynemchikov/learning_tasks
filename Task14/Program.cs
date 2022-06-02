// Найти третью цифру числа или сообщить, что её нет

int N = new Random().Next(1, 99999999);
Console.WriteLine(N);

if (N > 99)
{
    while (N>1000)
    {
       N = N / 10;
    }
    
    Console.WriteLine($"Третья цифра числа - {N%10}");
     
}
else
{
    Console.WriteLine("Число двузначное");
}

