using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("Output")]
    public class Output
    {
        [Key]
        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DateOutput { get; set; }
    }
}
