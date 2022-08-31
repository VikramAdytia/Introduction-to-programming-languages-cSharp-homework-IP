/*
Console.Write("num1 = ");
int x =  int.Parse(Console.ReadLine());
Console.Write("num2 = ");
int y =  int.Parse(Console.ReadLine());

if (x > y) 
{
    Console.WriteLine($"max = {x}");
}
else                      
{
    Console.WriteLine($"max = {y}");
}
*/

Console.Write("num1 = ");
int x =  int.Parse(Console.ReadLine());
Console.Write("num2 = ");
int y =  int.Parse(Console.ReadLine());
Console.Write("num3 = ");
int z =  int.Parse(Console.ReadLine());

/*
public static void AsIf<T>(this object value, Action<T> action) where T : class
{
    T kostyl = value as T;
    if (x > y) {
        //int xy = x;
        action(kostyl);
    }
}
//error CS0136: Локальная переменная или параметр
// с именем "xy" нельзя объявить в данной области
//Why Isn't It Possible? Why Not?
//не даёт использовать ни присвоеный внутри оператор
//ни присвоить обьявленный раньше
//error CS0103: Имя "xy" не существует
// в текущем контексте.
// писать екстеншн это похоже на костыль и пока для меня сложно.
else                      {
    int xy = y;
}
*/
int xy = x > y ? x : y ;

if (xy > z) 
{
    Console.WriteLine(xy);
}

else                      
{
    Console.WriteLine(z);
}


/*
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
var list = numbers.ToList();
int nRange = list.GetRange(0, n);
Console.WriteLine(nRange);
*/

