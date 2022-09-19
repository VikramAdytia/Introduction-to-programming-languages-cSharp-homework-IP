using System.Linq;

System.Console.WriteLine("1. Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
System.Console.WriteLine("2. Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
System.Console.WriteLine("3. Задача 44*: Не используя рекурсию, выведите первые N(сейчас 15) чисел Фибоначчи.");

string choise = System.Console.ReadLine();

switch (choise)
{
case ("1"):

    void GetMoreThanZeroInInput ()
    {

        Console.Write("Введите элементы(через пробел): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int count = arr.Count(x => x > 0);

        Console.WriteLine($"Кол-во элементов > 0: {count}");

    }

    GetMoreThanZeroInInput();

    break;

case("2"):

    double GetIntersecTwoLines (double b1, double k1,double b2, double k2 )
    {

        double x = (b2 - b1)/(k1 - k2);
        x = Math.Round(x, 3);

        double y = k1*(b2-b1)/(k1-k2)+b1;
        y = Math.Round(y, 3);

        System.Console.WriteLine($"y= {y}");

        return x;

    }

    double[,] GetTwoLinesFromUser()
    {

        System.Console.WriteLine("значения b1, k1, b2 и k2 задаются пользователем.");

        double[,] myArr = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.WriteLine("input");
                myArr[i, j] = double.Parse(Console.ReadLine());
            }
        }

        System.Console.WriteLine($"x = {GetIntersecTwoLines(myArr[0,0],myArr[0,1],myArr[1,0],myArr[1,1])}");

        return myArr;

    }

    GetTwoLinesFromUser();

    break;

case("3"):

    int a= 0 ;
    int b = 1; 
    int c= 1;
    string z = String.Empty;

    string  GetFibonacci (int n)
    {
        Console.WriteLine(a);
        if (n%1 == 0 && n%2 != 0 && n%3 != 0)
        {
            return z;
        }
        System.Console.WriteLine(b);
        if (n%2 == 0)
        {
            return z;
        }
        System.Console.WriteLine(c);
        a = b + c;
        b = a + c;
        c = a + b; 
        return z;
    }
    ///!!!Не используя рекурсию!!!

    void GetFibonacciN (int n)
    {
        int j = n/3;
        IEnumerable<int> strings = Enumerable.Repeat(1337, j);
        // хотел реализовать это в без циклов и желательно в одну строку
        // чтобы примерно как    repeat(что рипитить, сколько раз);
        // но не знаю как,а от попыток найти референс начал подгорать бекэнд
        foreach (int i in strings)
            GetFibonacci(3) ;
        
        GetFibonacci(n);
        //return;
    }

    GetFibonacciN(8);
    
    break;

}