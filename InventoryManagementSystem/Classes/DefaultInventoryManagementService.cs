using InventoryManagementSystem.Interfaces;

namespace InventoryManagementSystem.Classes
{
    internal class DefaultInventoryManagementService : IInventoryManagementService
    {
        public void AddNewInventory(IInventoryManager manager, IInventory newInventory)
        {
            manager.ListOfInventories.Add(newInventory);
        }

        public void RemoveExistingInventory(IInventoryManager manager, IInventory existingInventory)
        {
            manager.ListOfInventories.Remove(existingInventory);
        }

        public void AddToInventory(IInventory inventory, IInventoryObject newInventoryObject)
        {
            inventory.ListOfObjects.Add(newInventoryObject);
        }

        public void RemoveFromInventory(IInventory inventory, IInventoryObject existingInventoryObject)
        {
            inventory.ListOfObjects.Remove(existingInventoryObject);
        }

        public void EditInventoryObject(IInventory inventory, IInventoryObject existingObject, IInventoryObject newObject)
        {
            inventory.ListOfObjects.IndexOf(existingObject);
        }
    }
}
