using InventoryManagementSystem.Interfaces;

namespace InventoryManagementSystem.Classes
{
    internal class Inventory: IInventory
    {
        public IList<IInventoryObject> ListOfObjects { get; set; }
        public Inventory(IList<IInventoryObject> listOfObjects)
        {
            this.ListOfObjects = listOfObjects;
        }
    }
}
