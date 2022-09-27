
    int[,] spiralMatrix = new int[4, 4];

    int temp = 1;
    int i = 0;
    int j = 0;

while (temp <= 4 * 4)
{
    spiralMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < 4 - 1)
        j++;
    else if (i < j && i + j >= 4 - 1)
        i++;
    else if (i >= j && i + j > 4 - 1)
        j--;
    else
        i--;
}

void WriteArray (int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
        if (spiralMatrix[i,j] / 10 <= 0)
        Console.Write($" {spiralMatrix[i,j]} ");

        else Console.Write($"{spiralMatrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

WriteArray(spiralMatrix);
