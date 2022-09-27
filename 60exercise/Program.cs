double[,,] Get3DUniqueElementsArray()
{
    System.Console.WriteLine("Input rows number : ");
    int n = Convert.ToInt32 (Console.ReadLine());
    System.Console.WriteLine("Input columns number : ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Input levels number : ");
    int b = Convert.ToInt32(Console.ReadLine());


    double[,,] uniqueElements3DArray = new double[n, m, b];

    Random random = new Random();

    int[] temp = new int[n * m * b];
    int  number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
        for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                temp[i] = new Random().Next(10, 100);
                j = 0;
                number = temp[i];
                }
                number = temp[i];
            }
        }
    }

    int count = 0; 
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0 ; k < b ; k++ )
            {
            uniqueElements3DArray[i, j, k] = temp[count];
            count++;
            System.Console.Write($"i= {i},{j},{k}");
            Console.WriteLine("{0,6:F2}", uniqueElements3DArray[i, j,k]);
            }
        }
        Console.WriteLine();
    }
    
    return uniqueElements3DArray ;
    
}

Get3DUniqueElementsArray();
