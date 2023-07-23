using InventoryManagementSystem.Classes;
using InventoryManagementSystem.Interfaces;

namespace InventoryManagementSystem;
class Program
{
    public static void Main()
    {
        IInventoryObject inventoryObject = new InventoryObject("ball");
        IInventory inventory = new Inventory(new List<IInventoryObject>() { inventoryObject });
        IInventoryManagementService managementService = new RestrictedInventoryManagementService();
        IInventoryManager manager = new InventoryManager(new List<IInventory>() { inventory }, managementService);
        manager.AddInventory(inventory);
        foreach (IInventory inv in manager.ListOfInventories)
        {
            foreach (IInventoryObject obj in inv.ListOfObjects)
            {
                Console.WriteLine(obj.Name);
            }
        }
    }
}