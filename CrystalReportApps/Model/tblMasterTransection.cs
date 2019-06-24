namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMasterTransection")]
    public partial class tblMasterTransection
    {
        public int Id { get; set; }

        public int? AccountId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dtTransection { get; set; }

        [StringLength(50)]
        public string VoucherNo { get; set; }

        public decimal? Cr_Amount { get; set; }

        public decimal? Dr_Amount { get; set; }

        [StringLength(550)]
        public string Remarks { get; set; }

        [StringLength(50)]
        public string TransectionType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MakeDate { get; set; }

        [StringLength(50)]
        public string MakeBy { get; set; }

        public virtual dbAccountInfo dbAccountInfo { get; set; }
    }
}
