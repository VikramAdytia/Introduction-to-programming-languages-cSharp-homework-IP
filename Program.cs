void PrintDoubleArray (double [] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array [i]} ");
    }

    Console.WriteLine(" ");
    return;

}

double[] GetDiffAllFirstLastInArray (double [] array)
{
    double [] diffAllFirstLastInArray = new double[array.Length/2];

    for (int i = 0; i < diffAllFirstLastInArray.Length ; i++ )
    {
        int j = i+1;
        double sum = array[i] * array[^j++];
        diffAllFirstLastInArray[i] = sum;
    }

    if (array.Length%2 != 0)
    {
        Array.Resize(ref diffAllFirstLastInArray, diffAllFirstLastInArray.Length + 1);
        diffAllFirstLastInArray[^1] = array[array.Length/2];
    }

    return diffAllFirstLastInArray;

}

double[] GetRandomDoubleArray(int size, int startValue, int endValue)
{
    var array = new double[size];

    for (int i = 0 ; i < array.Length ; i++)
    {
        //array[i] = new Random().NextDouble()*1000;
        //Технически они вещественны,просто рандомный генератор выдаёт их целыми,как в описании заданиия
        array[i] = new Random().Next(startValue,endValue+1);
    }
    return array;
}
 
double GetDiffMinMaxInDoubleArray(double[] array)
{
    var result = array.Max() - array.Min();
    Console.WriteLine("GetDiffMinMaxInDoubleArray");
    return result;
}

int GetEven3DigitsInArray (double[] doubleArray)
{
    int counter = 0;
    for ( int i = 0 ; i < doubleArray.Length ; i++ )
    {
        if (doubleArray[i]%2 == 0 && doubleArray[i]/100 > 1 && doubleArray[i]/100 < 10 && doubleArray[i] >= 0 )
        // тут рудиментарная проверка на то что числа трёхзначные и положительные
        {
            counter++;
        }
    }
    Console.WriteLine("GetEven3DigitsInArray");
    return counter;
}

double GetUnevenIndexSumInArray (double[] doubleArray)
{
    double sum = 0;
    for ( int i = 0 ; i < doubleArray.Length ; i++ )
    {
        if ( i % 2 == 0 )
        {
            sum += doubleArray[i];
        }
    }
    Console.WriteLine("GetUnevenIndexSumInArray");
    return sum;
}

double[] doubleArray = GetRandomDoubleArray(5,100,999);

PrintDoubleArray(doubleArray);

Console.WriteLine(GetDiffMinMaxInDoubleArray(doubleArray));

Console.WriteLine(GetEven3DigitsInArray(doubleArray));

Console.WriteLine(GetUnevenIndexSumInArray(doubleArray));

var diffAllFirstLastInArray= GetDiffAllFirstLastInArray(doubleArray);
Console.WriteLine("diffAllFirstLastInArray");
PrintDoubleArray(diffAllFirstLastInArray);
