using Asynchronous;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        IExpensiveComputationService service = new ExpensiveComputationService();
        IClient client = new Client(service);
        long p = client.DoHeavyWork().Result;
        Console.WriteLine(p);
    }
}