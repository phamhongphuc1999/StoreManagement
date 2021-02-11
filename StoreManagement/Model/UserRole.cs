using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("UserRole")]
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        public string DisplayName { get; set; }
    }
}
