namespace InventoryManagementSystem.Interfaces
{
    internal interface IInventory
    {
        public IList<IInventoryObject> ListOfObjects { get; set; }
    }
}
