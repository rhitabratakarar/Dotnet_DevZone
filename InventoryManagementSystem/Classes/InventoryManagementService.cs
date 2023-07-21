using InventoryManagementSystem.Interfaces;

namespace InventoryManagementSystem.Classes
{
    internal class InventoryManagementService : IInventoryManagementService
    {
        public void AddNewInventory(IInventoryManager manager, IInventory newInventory)
        {
            manager.ListOfInventories.Add(newInventory);
        }

        public void RemoveExistingInventory(IInventoryManager manager, IInventory existingInventory)
        {
            manager.ListOfInventories.Remove(existingInventory);
        }
    }
}
