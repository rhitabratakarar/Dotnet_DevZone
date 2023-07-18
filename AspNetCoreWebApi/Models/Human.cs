using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApi.Models
{
    public class Human
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? BirthPlace { get; set; }
    }
}
