// See https://aka.ms/new-console-template for more information
Console.WriteLine(RecursiveFactorial(5));
Console.ReadLine();

int RecursiveFactorial(int num)
{
    if(num == 0)
    {
        return 1;
    }

    return num * RecursiveFactorial(num - 1);
}
