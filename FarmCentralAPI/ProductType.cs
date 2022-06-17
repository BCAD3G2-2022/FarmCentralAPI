using System.ComponentModel.DataAnnotations;

namespace FarmCentralAPI
{
    public class ProductType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string TypeName { get; set; } = string.Empty;
    }
}
