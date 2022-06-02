// Найти расстояние между точками в пространстве 2D/3D

/*Console.Write("Введите значение x для первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение y для первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение x для второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение y для второй точки: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Расстояние между двумя точками в пространстве 2D = ");
double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
Console.WriteLine(result);
*/

Console.WriteLine();

Console.Write("Введите значение x для первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение y для первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение z для первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение x для второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение y для второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение z для второй точки: ");
int z2 = int.Parse(Console.ReadLine());

Console.Write("Расстояние между двумя точками в пространстве 3D = ");
double result2 = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
Console.WriteLine(result2);