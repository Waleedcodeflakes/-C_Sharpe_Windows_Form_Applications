// See https://aka.ms/new-console-template for more information

//operators

//Arithmetic operators: + - * / %
int num, num2, total;
num = 10; num2 = 20;
total = num + num2;
Console.WriteLine(total);


//relational operators:  > < <= >= != "="
if(num > num2)
{
    Console.WriteLine("Num is greater");
} else
{
    Console.WriteLine("Num2 is greater");

}

//Uniary operator: +=, -=
//num +=5;

//Logical operators: || && 
if (!(num == num2 && num != 0))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");

}

