// 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// А (3,6); В (2,1)-> 5,09
// А (7, -5); В (1,-1)-> 7,21

// AB = √(xb - xa)2 + (yb - ya)2
double dis(double x1,double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

}
Console.WriteLine(dis(3, 6, 2, 1));