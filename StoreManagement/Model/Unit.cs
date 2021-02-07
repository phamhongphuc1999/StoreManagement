using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("Unit")]
    public class Unit
    {
        public Unit()
        {
            this.ObjectTables = new HashSet<ObjectTable>();
        }

        [Key]
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public virtual ICollection<ObjectTable> ObjectTables { get; set; }
    }
}
