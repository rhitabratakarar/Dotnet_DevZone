namespace InventoryManagementSystem.Interfaces
{
    internal interface IInventoryManagementService
    {
        public void AddNewInventory(IInventoryManager manager, IInventory newInventory);
        public void RemoveExistingInventory(IInventoryManager manager, IInventory existingInventory);
    }
}
