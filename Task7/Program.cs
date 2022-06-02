// Показать числа от -N до N

int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int numberA = -numberB;

while (numberA <= numberB)
{    
    Console.WriteLine(numberA);
    numberA = numberA + 1;
}


