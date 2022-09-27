double[,] GetSortedRowDescend2DArray()
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


    for (int i = 0; i < n ; i++ )
    {
        for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < randomized2DArray.GetLength(1) - 1; k++)
                {
                    if (randomized2DArray[i, k] < randomized2DArray[i, k + 1])
                    {
                    double temp = randomized2DArray[i, k + 1];
                    randomized2DArray[i, k + 1] = randomized2DArray[i, k];
                    randomized2DArray[i, k] = temp;
                    }
                }
            
            }

    }

    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(" " + randomized2DArray[i, j]);
        }
        Console.WriteLine();
    }
    return randomized2DArray ;
}

GetSortedRowDescend2DArray();