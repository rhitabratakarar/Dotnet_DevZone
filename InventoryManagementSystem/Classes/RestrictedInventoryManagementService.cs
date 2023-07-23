using InventoryManagementSystem.Interfaces;
using InventoryManagementSystem.Exceptions;

namespace InventoryManagementSystem.Classes;
internal class RestrictedInventoryManagementService : IInventoryManagementService
{
    public void AddNewInventory(IInventoryManager manager, IInventory newInventory)
    {
        if (manager.ListOfInventories.Count > 4)
            throw new ListTooLongException("Inventories can not exceed more than 5. Remove any existing to add another.");
        else
            manager.ListOfInventories.Add(newInventory);
    }

    public void AddToInventory(IInventory inventory, IInventoryObject newInventoryObject)
    {
        if (inventory.ListOfObjects.Count > 99)
            throw new ListTooLongException("Objects within an inventory can not exceed more that 100. Remove some existing to add others.");
        else
            inventory.ListOfObjects.Add(newInventoryObject);
    }

    public void EditInventoryObject(IInventory inventory, IInventoryObject existingObject, IInventoryObject newObject)
    {
        if (newObject.Name == "" || newObject.Name == null)
            throw new PropertyNullOrEmptyException("Name can not be empty of an inventory item.");
        else
            inventory.ListOfObjects[inventory.ListOfObjects.IndexOf(existingObject)].Name = newObject.Name;
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
