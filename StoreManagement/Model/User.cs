using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        [ForeignKey("UserRole")]
        public int IdRole { get; set; }
    }
}
