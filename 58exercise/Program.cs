int[,] GetProductOfTwoMatrix()
{
    System.Console.WriteLine("Input rows number : ");
    int n = Convert.ToInt32 (Console.ReadLine());
    System.Console.WriteLine("Input columns number and rows : ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Input columns number : " );
    int p =  Convert.ToInt32(Console.ReadLine());

    int[,] twoDimentionalRandomizedintArray = new int[n, m];

    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            twoDimentionalRandomizedintArray[i, j] = random.Next(10);
            Console.Write(" " + twoDimentionalRandomizedintArray[i, j]);
        }
        Console.WriteLine();
    }

        Console.WriteLine();

    int[,] twoDimentionalRandomizedintArray2 = new int[m, p];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < p; j++)
        {
            twoDimentionalRandomizedintArray2[i, j] = random.Next(10);
            Console.Write(" " + twoDimentionalRandomizedintArray2[i, j]);
        }
        Console.WriteLine();
    }

        Console.WriteLine();

    int[,] resultMatrix = new int[m,p];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < p; j++)
        {
        int sum = 0;
            for (int k = 0; k < m; k++)
            {
                sum += twoDimentionalRandomizedintArray[i,k] * twoDimentionalRandomizedintArray2[k,j];
            }
        resultMatrix[i,j] = sum;
        }
    }
    
    Console.WriteLine();

    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write(" " + resultMatrix[i, j]);
            }
            Console.WriteLine();
        }


    return resultMatrix;

}


GetProductOfTwoMatrix();
