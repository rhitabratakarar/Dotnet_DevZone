using InventoryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    internal class InventoryManager : IInventoryManager
    {
        public IList<IInventory> ListOfInventories { get; set; }
        private IInventoryManagementService _managementService { get; set; }
        public InventoryManager(IList<IInventory> listOfInventories, IInventoryManagementService managementService)
        {
            this.ListOfInventories = listOfInventories;
            this._managementService = managementService;
        }
    }
}
