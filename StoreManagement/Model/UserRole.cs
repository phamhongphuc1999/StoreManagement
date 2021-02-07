using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("UserRole")]
    public class UserRole
    {
        public UserRole()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
