// See https://aka.ms/new-console-template for more information

//Functions
Console.WriteLine(factorial(5));
Console.WriteLine(fact(7));

Console.ReadKey();
static int factorial(int num)
{
    int fact = 1;
    while (num > 1)
    {

        fact = fact * num--;
    }
    return fact;
}


//Recursion: (uses stack) =>
//terminating, ending criteria, Ftn calls by it self;
static int fact(int num)
{
    if (num <= 1) return 1;
    else
    {
        return num * fact(num - 1);
    }
}


