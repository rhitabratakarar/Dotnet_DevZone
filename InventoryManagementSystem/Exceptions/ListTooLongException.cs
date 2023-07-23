namespace InventoryManagementSystem.Exceptions;
internal class ListTooLongException : Exception
{
    public ListTooLongException() { }
    public ListTooLongException(string message): base(message) { }
}
