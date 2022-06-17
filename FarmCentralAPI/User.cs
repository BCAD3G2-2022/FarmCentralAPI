using System.ComponentModel.DataAnnotations;

namespace FarmCentralAPI
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public int UserTypeId { get; set; }

        public UserType? UserType { get; set; }
    }
}
