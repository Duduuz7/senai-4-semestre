using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApiTest.Domains
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public Guid IdPRoduct { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        public string? Name { get; set; }

        [Column(TypeName = "DECIMAL(4,2)")]
        public decimal? Price { get; set; }
    }
}
