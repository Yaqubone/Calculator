Console.WriteLine("emeliyyati sechin");
char emeliyyat=Convert.ToChar(Console.ReadLine());
if (emeliyyat == '+')
{

    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a + b;
    Console.WriteLine(c);

}
else if (emeliyyat == '-')
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a - b;
    Console.WriteLine(c);
}
else if (emeliyyat == '*')
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a * b;
    Console.WriteLine(c);
}
else if(emeliyyat=='/')
{
    int a= Convert.ToInt32(Console.ReadLine());
    int b= Convert.ToInt32(Console.ReadLine());
    int c = a / b;
    Console.WriteLine(c);
}
else
{
    Console.WriteLine("emeliyyat ugursuzdur");
}

