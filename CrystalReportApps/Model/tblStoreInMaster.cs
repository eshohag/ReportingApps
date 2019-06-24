namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblStoreInMaster")]
    public partial class tblStoreInMaster
    {
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dtTransection { get; set; }

        public int? AccountId { get; set; }

        [StringLength(50)]
        public string VoucherNo { get; set; }

        public decimal? TotalAmount { get; set; }

        [StringLength(50)]
        public string Remarks { get; set; }

        public int? SupplierId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MakeDate { get; set; }

        [StringLength(50)]
        public string MakeBy { get; set; }

        public virtual dbAccountInfo dbAccountInfo { get; set; }
    }
}
