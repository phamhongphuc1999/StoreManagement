using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("Suplier")]
    public class Suplier
    {
        public Suplier()
        {
            this.ObjectTables = new HashSet<ObjectTable>();
        }

        [Key]
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public string Address { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string MoreInfo { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? ContractDate { get; set; }

        public virtual ICollection<ObjectTable> ObjectTables { get; set; }
    }
}
