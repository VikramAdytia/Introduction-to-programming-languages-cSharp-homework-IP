

void func(int m ,int n) 
{
    if (m>=0 && n >=0)
    {
    if(m!=n)
    {
        if(m<n)
        {
        System.Console.Write(m+",");
        func(m+1,n);
        }
        else
        {
        System.Console.Write(m+",");
        func(m-1,n);
        }
        }
    else
    {
        System.Console.Write(m);
    }
    }
    else
    {
        System.Console.WriteLine("Отрицательные и нецелые числа к натуральным не относят.");
    }
}
System.Console.WriteLine("m= 1 , n= 5 ");
func(1, 5);
System.Console.WriteLine("\n"+"m= 8 , n= 4 ");
func(8, 4);
System.Console.WriteLine("\n"+"m= -1 , n= 1");
func(-1,1);

int funcSum(int m,int n)
{
    if (m>=0 && n >=0)
    {
        if (n != m)
        {
            if (n>m)
            {
                int sum = n + funcSum(n-1,m);
                return sum;
            }
            else
            {
                int sum = n + funcSum(n+1,m);
                return sum;
            }
        }
        else
        {
            return n;
        }
    }
    else
    {
        System.Console.WriteLine("Отрицательные и нецелые числа к натуральным не относят.");
        return 0;
    }
}

System.Console.WriteLine("m= 1 , n= 15");
Console.WriteLine(funcSum(1,15));
System.Console.WriteLine("m= 8 , n= 4 ");
Console.WriteLine(funcSum(8,4));
System.Console.WriteLine("m= -4 , n= -8 ");
Console.WriteLine(funcSum(-4,-8));

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}

System.Console.WriteLine("значения м от 4 и больше вызывает от 65533 раз при стеке ~20000");
System.Console.WriteLine("m= 2 , n= 8");
System.Console.WriteLine(Ack(2,8));
System.Console.WriteLine("m= 3 , n= 5");
System.Console.WriteLine(Ack(3,5));

