// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool TrueFalse(bool x, bool y)
{
    return (!(x || y) == (!x && !y));
}

bool [] x = {true, false};
bool [] y = {true, false};

bool result = true;
for (int i = 0; i < x.Length; i++)
{
    for (int j = 0; j < y.Length; j++)
    {
        Console.WriteLine($"Для выражения {x[i]} и {y[j]} = {TrueFalse(x[i], y[j])}");
        if (!TrueFalse(x[i], y[j]))
        {
            Console.WriteLine("Утверждение ложно");
            result = false;
        }

    }
}
if (result)
{
    Console.WriteLine("Удалось доказать");
}
else
{
    Console.WriteLine("Не удалось доказать");
}
