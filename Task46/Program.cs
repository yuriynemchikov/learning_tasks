// 46. Написать программу масштабирования фигуры
Console.Clear();

string figureSize = "(1,2) (2,3) (3,4) (4,1)"
                    .Replace("(","")
                    .Replace(")","")
                    ;
Console.WriteLine(figureSize);

Console.WriteLine("Please enter the index to change the figure");
int Index = int.Parse(Console.ReadLine());

var data = figureSize.Split(" ")
            .Select(item => item.Split(','))
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
            .Select(point => (point.x * Index, point.y * Index))
            .ToArray();

for(int i = 0; i<data.Length; i++)
{
    Console.WriteLine(data[i]);
}
