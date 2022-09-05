/*
Console.Write("write a 3 digit = ");
string n =  Console.ReadLine();
int x = Int32.Parse(n);
char [] destination = { 'n', 'r', 'g' };
int y = 100;
int z = x/y;
if (z >= 1 && z < 10)
{
    n.CopyTo ( 1, destination, 1, 1 );
    Console.WriteLine(destination[1]);
}
else 
{
    Console.WriteLine("not a 3 digit");  
}
*/

Console.Write("write at least 3 digit = ");
string n =  Console.ReadLine();
int x = Int32.Parse(n);
char [] destination = { 'n', 'r', 'g' };
int y = 100;
int z = x/y;
if (z >= 1)
{
    n.CopyTo ( 2, destination, 2, 1 );
    Console.WriteLine(destination[2]);
}
else 
{
    Console.WriteLine("less than 3 digit");  
}
