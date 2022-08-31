Console.Write("num1 = ");
int x =  int.Parse(Console.ReadLine());
Console.Write("num2 = ");
int y =  int.Parse(Console.ReadLine());
Console.Write("num3 = ");
int z =  int.Parse(Console.ReadLine());

int xy = x > y ? x : y ;

if (xy > z) {
    Console.WriteLine(xy);
}

else                      {
    Console.WriteLine(z);
}
