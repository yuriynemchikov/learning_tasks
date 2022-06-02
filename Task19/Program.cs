// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Enter X number:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Y number:");
double y = double.Parse(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("quarter number is 1");
}
    else
    {
        if (x<0 && y>0)
        {
            Console.WriteLine("quarter number is 2");
        }

            else
            {
                if (x<0 && y<0)
            {
                Console.WriteLine("quarter number is 3");
            }
                else
                {
                    if (x>0 && y<0)
                    {
                    Console.WriteLine("quarter number is 4");
                    }
                }
            }           
    }  

