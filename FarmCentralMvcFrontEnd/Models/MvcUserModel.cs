using System.ComponentModel.DataAnnotations;

namespace FarmCentralMvcFrontEnd.Models
{
    public class MvcUserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field is Required!")]
        [StringLength(20)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "This Field is Required!")]
        public string PasswordHash { get; set; } = string.Empty;

        [Required(ErrorMessage = "This Field is Required!")]
        public int UserTypeId { get; set; }

        public MvcUserTypeModel? MvcUserType { get; set; }
    }
}
