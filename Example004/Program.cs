// Найти расстояние между точками в пространстве 2D/3D.
Console.WriteLine("Введите координат х для первой точки");
int NumberXA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат y для первой точки");
int NumberYA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат х для второй точки");
int NumberXB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координат y для второй точки");
int NumberYB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((NumberXA - NumberXB) * (NumberXA - NumberXB) + (NumberYA - NumberYB) * (NumberYA - NumberYB));
Console.WriteLine("Результат равен " + result);
