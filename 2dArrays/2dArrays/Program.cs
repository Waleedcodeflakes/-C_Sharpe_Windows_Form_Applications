// See https://aka.ms/new-console-template for more information

//Two dimentional arrays

//Jagged Array: Arrays that has no fix size....
string[][] fruit = new string[5][]; //2nd array is left empty
fruit[0] = new string[3] {"dfdg","eeg","wetew"};
fruit[1] = new string[5] { "dfdg", "eeg", "wetew","egrg","ergf" };
fruit[2] = new string[3] { "dfdg", "eeg", "wetew" };  //All arrays has different size
fruit[3] = new string[6] { "dfdg", "eeg", "wetew","wsber","uedfh","uwdjss" };
fruit[4] = new string[2] { "dfdg", "eeg" };
int count = 0;

for(int i = 0; i < fruit.Length; i++)
{
        
    for (int j = 0; j < fruit[i].Length; j++)
    {
        Console.Write(" " + fruit[i][j]);
    }
    Console.WriteLine();
}

for (int i = 0; i < fruit.Length; i++)
{
    {
        Console.Write("The string " + (i+1) + " has " + fruit[i].Length + " items.");
    }
    Console.WriteLine();
}

for (int i = 0; i < fruit.Length; i++)
{
    for(int j = 0;j < fruit.Length; j++)
    {
        if (fruit[i].Length > fruit[j].Length)
        {
            Console.WriteLine(fruit[i][j]);
            
        }
    }
    Console.WriteLine();
}


/* 
  for(int k = 0; k < fruit[i][j].Length; k++)
        {
            if (fruit[i][j].Length > fruit[j][k].Length)
            {
        Console.Write(" "+ fruit[i][j]);
                
            } else
            {
                Console.Write(" " + fruit[j][k]);
            }
 
 */



//Simple 2d array
/*string[][] fruits= new string[3][3];

fruits[0] =new string[3] { "weee","trt","eeg"};
fruits[1] = new string[3] { "weee","trt","eeg"};//All arrays has same size
fruits[2] = new string[3] { "weee","trt","eeg"};  */