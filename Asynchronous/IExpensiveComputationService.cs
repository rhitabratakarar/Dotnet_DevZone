namespace Asynchronous
{
    internal interface IExpensiveComputationService
    {
        public Task<long> DoExpensiveComputationForClient();
    }
}
