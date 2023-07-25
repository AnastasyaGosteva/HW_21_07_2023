void CheckCoordinate (double coordinateX, double coordinateY1, double coordinateY2)
{
     Console.WriteLine($"Прямые пересекутся в точке с координатами ({coordinateX}, {coordinateY1}).");
}
double GetInput(String text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double k1 = GetInput("Введите k1: ");
double b1 = GetInput("Введите b1: ");
double k2 = GetInput("Введите k2: ");
double b2 = GetInput("Введите b2: ");
double x = (b2 - b1)/(k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

CheckCoordinate (x, y1, y2);
