﻿/*
Console.Write("num1 = ");
int x =  int.Parse(Console.ReadLine());
Console.Write("num2 = ");
int y =  int.Parse(Console.ReadLine());

x = x * x;

if (x == y) 
{
    Console.WriteLine("yes");
}
else                      
{
    Console.WriteLine("no");
}
*/
/*
Console.Write("day = ");
int x = int.Parse(Console.ReadLine());
if (x == 3)
{
        Console.WriteLine("Wednesday");
}
if ( x == 5)
{
        Console.WriteLine("Friday");
}
*/

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
var list = numbers.ToList();
int nRange = list.GetRange(0, n);
Console.WriteLine(nRange);


