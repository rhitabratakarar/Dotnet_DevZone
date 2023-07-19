using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Client: IClient
    {
        private readonly IService _service;

        public Client(IService injectedService)
        {
            // constructor for dependency injection.
            this._service = injectedService;
        }
        public void UseDependency()
        {
            this._service.ServiceProperty = 38;
            Console.WriteLine(this._service.ServiceProperty);
            this._service.ServiceMethod();
        }
    }
}
