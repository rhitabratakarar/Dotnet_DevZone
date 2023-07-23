using InventoryManagementSystem.Interfaces;

namespace InventoryManagementSystem.Classes
{
    internal class InventoryManager : IInventoryManager
    {
        public IList<IInventory> ListOfInventories { get; set; }
        private readonly IInventoryManagementService _managementService;
        public InventoryManager(IList<IInventory> listOfInventories, IInventoryManagementService managementService)
        {
            this.ListOfInventories = listOfInventories;
            this._managementService = managementService;
        }
    }
}
