// Написать программу возведения числа А в целую стень B

int a = new Random().Next(1, 9);
Console.Write($"Возвести число {a} ");
int b = new Random().Next(-9, 9);
Console.WriteLine($"в степень {b}");

double DegreeOfnumber(int num, int degree)
{
    if (degree < 0)
    {
        return DegreeOfnumber(num, degree + 1) / num;
    }

    if (degree == 0)
        return 1;
    else
    {
        return DegreeOfnumber(num, degree - 1) * num;
    }
}
Console.Write($"Число {a} в степени {b} равно ");
Console.WriteLine(DegreeOfnumber(a, b));