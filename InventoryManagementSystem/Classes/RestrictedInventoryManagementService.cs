using InventoryManagementSystem.Interfaces;
using InventoryManagementSystem.Exceptions;

namespace InventoryManagementSystem.Classes;
internal class RestrictedInventoryManagementService : IInventoryManagementService
{
    public void AddNewInventory(IInventoryManager manager, IInventory newInventory)
    {
        if (manager.ListOfInventories.Count >= 5)
            throw new ListTooLongException("Inventories can not exceed more than 5. Remove any existing to add another.");
    }

    public void AddToInventory(IInventory inventory, IInventoryObject newInventoryObject)
    {
        if (inventory.ListOfObjects.Count > 100)
            throw new ListTooLongException("Objects within an inventory can not exceed more that 100. Remove some existing to add others.");
    }

    public void EditInventoryObject(IInventory inventory, IInventoryObject existingObject, IInventoryObject newObject)
    {
        if (newObject.Name == "" || newObject.Name == null)
            throw new PropertyNullOrEmptyException("Name can not be empty of an inventory item.");
    }

    public void RemoveExistingInventory(IInventoryManager manager, IInventory existingInventory)
    {
        manager.ListOfInventories.Remove(existingInventory);
    }

    public void RemoveFromInventory(IInventory inventory, IInventoryObject existingInventoryObject)
    {
        inventory.ListOfObjects.Remove(existingInventoryObject);
    }
}
