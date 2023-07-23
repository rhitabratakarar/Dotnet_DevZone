namespace InventoryManagementSystem.Interfaces
{
    internal interface IInventoryManagementService
    {
        public void AddNewInventory(IInventoryManager manager, IInventory newInventory);
        public void RemoveExistingInventory(IInventoryManager manager, IInventory existingInventory);
        public void AddToInventory(IInventory inventory, IInventoryObject newInventoryObject);
        public void RemoveFromInventory(IInventory inventory, IInventoryObject existingInventoryObject);
        public void EditInventoryObject(IInventory inventory, IInventoryObject existingObject, IInventoryObject newObject);
    }
}
