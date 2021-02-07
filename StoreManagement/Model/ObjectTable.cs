﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Model
{
    [Table("Object")]
    public class ObjectTable
    {
        public ObjectTable()
        {
            this.InputInfoes = new HashSet<InputInfo>();
            this.OutputInfoes = new HashSet<OutputInfo>();
        }

        [Key]
        [MaxLength(128)]
        [Required(AllowEmptyStrings = false)]
        public string Id { get; set; }

        public string DisplayName { get; set; }

        [ForeignKey("Unit")]
        public int IdUnit { get; set; }

        [ForeignKey("Suplier")]
        public int IdSuplier { get; set; }

        public string QRCode { get; set; }

        public string BarCode { get; set; }

        public virtual ICollection<InputInfo> InputInfoes { get; set; }

        public virtual ICollection<OutputInfo> OutputInfoes { get; set; }
    }
}
