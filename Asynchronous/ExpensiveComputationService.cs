namespace Asynchronous
{
    internal class ExpensiveComputationService : IExpensiveComputationService
    {
        public async Task<long> DoExpensiveComputationForClient()
        {
            long sum = 0;
            for (int i = 0; i < 100000000; i++)
            {
                sum += i;
            }
            await Task.Delay(1000);
            return sum;
        }
    }
}
