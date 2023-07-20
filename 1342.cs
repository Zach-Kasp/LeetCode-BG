Random rnd = new Random();

int iNumberMin = 1;


//Convert.ToInt32(10e6);
int iNumberMax = 100;

int iNumber = rnd.Next(iNumberMin, iNumberMax);

int iCounter = 0;

Console.WriteLine(iNumber);

while (iNumber != 0)
{
    iCounter++;
    if (iNumber % 2 == 0)
    {
        iNumber = iNumber / 2;
    }
    else
    {
        iNumber = iNumber - 1;
    }
    Console.WriteLine(iNumber);
}

Console.WriteLine("\nNumber of Steps required: {0:D}",iCounter);