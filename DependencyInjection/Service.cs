using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Service : IService
    {
        public int ServiceProperty { get; set; }

        public void ServiceMethod()
        {
            Console.WriteLine("This is inside service method");
        }
    }
}
