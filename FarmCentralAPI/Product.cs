using System.ComponentModel.DataAnnotations;

namespace FarmCentralAPI
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string ProductName { get; set; } = string.Empty;

        public DateTime DateAdded { get; set; }

        public int ProductTypeId { get; set; }

        public ProductType? ProductType { get; set; }
    }
}
