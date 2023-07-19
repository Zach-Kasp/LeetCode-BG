Random rnd = new Random();

int iRndMin = 1;
// 1000;
int iRndMax = 10;
// Convert.ToInt32(-10e6);
int iRndBottom = -100;
// Convert.ToInt32(10e6);
int IRndTop = 100;

int[] iRunningSums = new int[rnd.Next(iRndMin, iRndMax)];

Console.WriteLine("Running Sums length: {0:D}\n", iRunningSums.Length);

for (int i = 0; i < iRunningSums.Length; i++)
{
    iRunningSums[i] = rnd.Next(iRndBottom, IRndTop);

    if (i != (iRunningSums.Length - 1))
    {
        Console.Write("{0:D},", iRunningSums[i]);
    }
    else
    {
        Console.Write("{0:D}\n", iRunningSums[i]);
    }
}

int[] iSums = new int[iRunningSums.Length];
iSums[0] = iRunningSums[0];
Console.Write("{0:D},", iSums[0]);

for (int i = 1; i < iSums.Length; i++)
{
    iSums[i] = iSums[i - 1] + iRunningSums[i];

    if (i != (iRunningSums.Length - 1))
    {
        Console.Write("{0:D},", iSums[i]);
    }
    else
    {
        Console.Write("{0:D}\n", iSums[i]);
    }
}