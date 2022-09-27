void GetMinimalSumOfRowFromArray()
{
    System.Console.WriteLine("Input rows number : ");
    int n = Convert.ToInt32 (Console.ReadLine());
    System.Console.WriteLine("Input columns number : ");
    int m = Convert.ToInt32(Console.ReadLine());

    double[,] randomized2DArray = new double[n, m];

    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
         randomized2DArray[i, j] = random.Next(100);
            Console.Write(" " + randomized2DArray[i, j]);
        }
        Console.WriteLine();
    }

    double min = 0;
    int minIndex = 0;
    for (int i = 0; i < n ; i++ )
    {
        double sum = 0;
        for (int j = 0; j < m; j++)

            {
            sum = sum + randomized2DArray[i, j];
            }
        if (i == 0)
        {
            min = sum;
        }
        if (min > sum)
        {
            minIndex = i;
            min = sum;
        }
    }
    System.Console.WriteLine($"min sum = {min} in row {minIndex}");

}

GetMinimalSumOfRowFromArray();