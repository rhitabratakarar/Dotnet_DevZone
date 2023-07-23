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

        public void AddInventory(IInventory inventory)
        {
            this._managementService.AddNewInventory(this, inventory);
        }

        public void RemoveInventory(IInventory inventory)
        {
            this._managementService.RemoveExistingInventory(this, inventory);
        }

        public void RemoveInventoryObject(IInventory inventory, IInventoryObject objectToRemove)
        {
            int indexOfInventory = this.ListOfInventories.IndexOf(inventory);
            this.ListOfInventories[indexOfInventory].ListOfObjects.Remove(objectToRemove);
        }

        public void AddInventoryObject(IInventory inventory, IInventoryObject objectToAdd)
        {
            int indexOfInventory = this.ListOfInventories.IndexOf(inventory);
            this.ListOfInventories[indexOfInventory].ListOfObjects.Add(objectToAdd);
        }
    }
}
