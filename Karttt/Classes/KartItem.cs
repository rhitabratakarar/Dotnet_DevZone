using Karttt.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Karttt.Classes
{
    public class KartItem : IKartItem
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }
        public bool IsItemAddedToKart { get; set; } = false;
    }
}
