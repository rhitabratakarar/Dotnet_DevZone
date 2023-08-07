using Karttt.Interfaces;

namespace Karttt.Classes
{
    public class KartItem : IKartItem
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string? Name { get; set; }
    }
}
