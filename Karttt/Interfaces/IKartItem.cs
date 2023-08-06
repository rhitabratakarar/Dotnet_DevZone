namespace Karttt.Interfaces
{
    public interface IKartItem
    {
        public Guid Id { get; } 
        public string? Name { get; set; }
    }
}
