namespace InventoryManagementSystem.Interfaces
{
    internal interface IInventoryManager
    {
        public IList<IInventory> ListOfInventories { get; set; }
        public void AddInventory(IInventory inventory);
        public void RemoveInventory(IInventory inventory);
        public void RemoveInventoryObject(IInventory inventory, IInventoryObject objectToRemove);
        public void AddInventoryObject(IInventory inventory, IInventoryObject objectToAdd);
        public void EditInventoryObject(IInventory inventory, IInventoryObject existingObject, IInventoryObject newObject);
    }
}