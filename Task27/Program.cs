// Определить количество цифр в числе

int number = new Random().Next(1,100000);
Console.WriteLine($"Number is {number}");

int count = 0;

while(number>10)
{
    number = number / 10;
    count++;
}

Console.WriteLine(count+1);

