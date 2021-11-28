using System.ComponentModel.DataAnnotations;

namespace E_commerce.Domain.Entities
{
    public class Product
    {
        [Key]public int Id { get; set; }

        public string Name { get; set; }
    }
}