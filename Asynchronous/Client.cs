using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    internal class Client : IClient
    {
        private readonly IExpensiveComputationService _service;
        public Client(IExpensiveComputationService serviceProvided)
        {
            this._service = serviceProvided;
        }
        public async Task<long> DoHeavyWork()
        {
            long heavyOutput = await this._service.DoExpensiveComputationForClient();
            return heavyOutput;
        }
    }
}
