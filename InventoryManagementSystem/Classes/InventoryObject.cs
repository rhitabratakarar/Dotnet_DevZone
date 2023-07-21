using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Interfaces;

namespace InventoryManagementSystem.Classes
{
    internal class InventoryObject: IInventoryObject
    {
        public string Name { get; set; }
        public InventoryObject(string name)
        {
            this.Name = name;
        }
    }
}
