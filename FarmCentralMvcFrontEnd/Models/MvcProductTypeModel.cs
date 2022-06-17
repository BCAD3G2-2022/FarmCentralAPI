using System.ComponentModel.DataAnnotations;

namespace FarmCentralMvcFrontEnd.Models
{
    public class MvcProductTypeModel
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string TypeName { get; set; } = string.Empty;
    }
}
