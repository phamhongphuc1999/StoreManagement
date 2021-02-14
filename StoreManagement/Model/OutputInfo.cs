using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("OutputInfo")]
    public class OutputInfo
    {
        [Key]
        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string Id { get; set; }

        [ForeignKey("Object")]
        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string IdObject { get; set; }

        [ForeignKey("Output")]
        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string IdOutput { get; set; }

        [ForeignKey("Customer")]
        public int IdCustomer { get; set; }

        public int Count { get; set; }

        public string Status { get; set; }
    }
}
