namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbBankinfo")]
    public partial class dbBankinfo
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string CHeadName { get; set; }

        [StringLength(50)]
        public string AccountNo { get; set; }

        [StringLength(50)]
        public string AccountHolderName { get; set; }

        [StringLength(50)]
        public string ContactNo { get; set; }

        public decimal? BBalance { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BDate { get; set; }

        [StringLength(50)]
        public string BStatus { get; set; }
    }
}
