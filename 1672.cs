Random rnd = new Random();

int iCustomerMin = 1;
int iCustomerMax = 50;

int iBankMin = 1;
int IBankMax = 50;

int iValueMin = 0;
int IValueMax = 100;

int iCustomer = rnd.Next(iCustomerMin, iCustomerMax);
int iBank = rnd.Next(iBankMin, IBankMax);

int[,] iAccounts = new int[iCustomer, iBank];

for (int i = 0; i < iCustomer; i++)
{
    Console.Write("Row {0:D}: ", i);
    for (int j = 0; j < iBank; j++)
    {
        iAccounts[i, j] = rnd.Next(iValueMin, IValueMax);
        Console.Write("{0:D} ", iAccounts[i, j]);
    }

    Console.WriteLine();
}

int[] iWealths = new int[iCustomer];

for (int i = 0; i < iCustomer; i++)
{
    for (int j = 0; j < iBank; j++)
    {
        iWealths[i] += iAccounts[i, j];
    }
    Console.WriteLine("{0:D} ", iWealths[i]);
}

int iMaxValue = 0;
int iRichestCustomer = 0;

for (int i = 0; i < iWealths.Length; i++)
{
    if (iWealths[i] > iMaxValue)
    {
        iMaxValue = iWealths[i];
        iRichestCustomer = i;
    }
}

Console.WriteLine("\nRichest customer is customer #{0:D} with a total of ${1:D}", iRichestCustomer + 1, iMaxValue);