using System.ComponentModel.DataAnnotations;

namespace FarmCentralMvcFrontEnd.Models
{
    public class MvcProductModel
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string ProductName { get; set; } = string.Empty;

        public DateTime DateAdded { get; set; }

        public int ProductTypeId { get; set; }

        public MvcProductTypeModel? MvcProductType { get; set; }
    }
}
