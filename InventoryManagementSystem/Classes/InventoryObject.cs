using InventoryManagementSystem.Interfaces;

namespace InventoryManagementSystem.Classes
{
    internal class InventoryObject: IInventoryObject
    {
        public string Name { get; set; }
        public InventoryObject(string name)
        {
            this.Name = name;
        }
    }
}
