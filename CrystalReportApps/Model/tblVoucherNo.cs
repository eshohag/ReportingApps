namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblVoucherNo")]
    public partial class tblVoucherNo
    {
        public int id { get; set; }

        [StringLength(50)]
        public string vcNo { get; set; }

        public DateTime? dt { get; set; }
    }
}
