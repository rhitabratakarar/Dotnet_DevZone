namespace InventoryManagementSystem.Interfaces
{
    internal interface IInventoryManager
    {
        public IList<IInventory> ListOfInventories { get; set; }
    }
}