using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("Unit")]
    public class Unit
    {
        [Key]
        public int Id { get; set; }

        public string DisplayName { get; set; }
    }
}
