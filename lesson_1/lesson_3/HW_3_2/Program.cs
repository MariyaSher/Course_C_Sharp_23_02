﻿// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в 3D пространстве
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double dis(double x1,double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

}
Console.WriteLine(dis(7,-5,0,1,-1,9));
