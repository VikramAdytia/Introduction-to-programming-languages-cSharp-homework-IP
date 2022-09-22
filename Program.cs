
double[,] Get2DimentionalRandomizedDoubleArrayFromInputIntMIntN()
{
    System.Console.WriteLine("Input rows number : ");
    int n = Convert.ToInt32 (Console.ReadLine());
    System.Console.WriteLine("Input columns number : ");
    int m = Convert.ToInt32(Console.ReadLine());

    double[,] twoDimentionalRandomizedDoubleArray = new double[n, m];

    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            twoDimentionalRandomizedDoubleArray[i, j] = random.NextDouble() * 100;
            Console.Write("{0,6:F2}", twoDimentionalRandomizedDoubleArray[i, j]);
        }
        Console.WriteLine();
    }

    return twoDimentionalRandomizedDoubleArray ;

}

void ReturnElementOrNoneFrom2DimentionalDoubleArrayByInputIntMIntN(double[,] twoDimentionalArray )
{
    System.Console.WriteLine("!!!отсчёт позиции начинается с ноля!!!");
    System.Console.WriteLine("Input row of element  : ");
    int n = Convert.ToInt32 (Console.ReadLine());
    System.Console.WriteLine("Input column of element : ");
    int m = Convert.ToInt32(Console.ReadLine());

    try
    {
        double result = twoDimentionalArray[n,m];
        System.Console.WriteLine(result);
    }
    catch
    {
        System.Console.WriteLine("такого числа в массиве нет");
    }
}

double[,] Get2DimentionalRandomizedIntArrayFromInputIntMIntN()
{
    System.Console.WriteLine("Input rows number : ");
    int n = Convert.ToInt32 (Console.ReadLine());
    System.Console.WriteLine("Input columns number : ");
    int m = Convert.ToInt32(Console.ReadLine());

    double[,] twoDimentionalRandomizedintArray = new double[n, m];

    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            twoDimentionalRandomizedintArray[i, j] = random.Next(100);
            // числа целые,как по тз,но тип данных нет,для того чтобы дальше не делать перевод в дабл ,для правильных расчётов 
            Console.Write(" " + twoDimentionalRandomizedintArray[i, j]);
        }
        Console.WriteLine();
    }
    for (int j = 0; j < m; j++)
    {
        double sum = 0;
        for (int i = 0; i < n ; i++ )
            {
            //System.Console.WriteLine( $"start sum  {sum} ");    
            sum = sum + twoDimentionalRandomizedintArray[i, j];
            //System.Console.WriteLine($"mid sum {sum}");
            }
        //System.Console.WriteLine($"fin sum {sum}");
        //System.Console.WriteLine(m);
        System.Console.WriteLine(sum/m);
    }
    return twoDimentionalRandomizedintArray ;
}

double[,] twoDimentionalRandomizedDoubleArray = Get2DimentionalRandomizedDoubleArrayFromInputIntMIntN();

ReturnElementOrNoneFrom2DimentionalDoubleArrayByInputIntMIntN(twoDimentionalRandomizedDoubleArray);

Get2DimentionalRandomizedIntArrayFromInputIntMIntN();
