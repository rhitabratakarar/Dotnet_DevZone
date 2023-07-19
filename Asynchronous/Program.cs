class Program
{
    private async static Task<string> AsyncMethod()
    {
        int sum = 0;
        for(int i = 0; i < 100000; i ++)
        {
            for (int j = 0; j < 10; j++)
            {
                sum += i;
            }
        }
        return sum.ToString() ;
    }
    private async static void PrintThousandTimes()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void Main()
    {
        //string p = AsyncMethod().Result;
        //Console.WriteLine(p);
        PrintThousandTimes();
    }
}