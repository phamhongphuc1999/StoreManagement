using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("InputInfo")]
    public class InputInfo
    {
        [Key]
        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string Id { get; set; }

        [ForeignKey("Object")]
        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string IdObject { get; set; }

        [ForeignKey("Input")]
        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string IdInput { get; set; }

        public int Count { get; set; }

        public double InputPrice { get; set; }

        public double OutputPrice { get; set; }

        public string Status { get; set; }
    }
}
