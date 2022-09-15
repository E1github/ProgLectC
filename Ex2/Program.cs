int numbA = new Random().Next(1,110);
int numbB = new Random().Next(1,11);
Console.Write(numbA/numbB+" ");
Console.WriteLine();


string username = "JohnDow";

while (username!="john") 
{
Console.Write("Login: ");
username = Console.ReadLine();

if (username!="john")
    {
        Console.WriteLine("Hello, bastard "+username+"!");
    }
    else Console.WriteLine("Hello, lovely John! ");

};