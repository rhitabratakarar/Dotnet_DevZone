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
            this._managementService.RemoveFromInventory(inventory, objectToRemove);
        }

        public void AddInventoryObject(IInventory inventory, IInventoryObject objectToAdd)
        {
            this._managementService.AddToInventory(inventory, objectToAdd);
        }

        public void EditInventoryObject(IInventory inventory, IInventoryObject existingObject, IInventoryObject newObject)
        {
            this._managementService.EditInventoryObject(inventory, existingObject, newObject);
        }
    }
}
