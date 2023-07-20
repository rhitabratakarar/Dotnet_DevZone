namespace Asynchronous
{
    internal interface IClient
    {
        public Task<long> DoHeavyWork();
    }
}
