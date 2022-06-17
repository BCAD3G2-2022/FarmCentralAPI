using System.ComponentModel.DataAnnotations;

namespace FarmCentralAPI
{
    public class UserType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string TypeName { get; set; } = string.Empty;
    }
}
