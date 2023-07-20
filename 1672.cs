Random rnd = new Random();

int iCustomerMin = 1;
int iCustomerMax = 50;

int iBankMin = 1;
int IBankMax = 50;

int iValueMin = 0;
int IValueMax = 100;

int iCustomer = rnd.Next(iCustomerMin, iCustomerMax);
int iBank = default;

int[][] iAccounts = new int[iCustomer][];

for (int i = 0; i < iCustomer; i++)
{
    iBank = rnd.Next(iBankMin, IBankMax);
    iAccounts[i] = new int[iBank];
    Console.Write("Row {0:D}: ", i);
    for (int j = 0; j < iBank; j++)
    {
        int iTempValue = rnd.Next(iValueMin, IValueMax);
        iAccounts[i][j] = iTempValue;
        Console.Write("{0:D} ", iAccounts[i][j]);
    }

    Console.WriteLine();
}


int[] iWealths = new int[iCustomer];


for (int i = 0; i < iAccounts.GetLength(0); i++)
{
    for (int j = 0; j < iAccounts[i].Length; j++)
    {
        iWealths[i] += iAccounts[i][j];
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
