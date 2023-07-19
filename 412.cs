Random rnd = new Random();

int iNumberMin = 1;

int iNumberMax = Convert.ToInt32(10e4);

int iNumber = rnd.Next(iNumberMin, iNumberMax);

for (int i = 1; i < iNumber + 1; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}