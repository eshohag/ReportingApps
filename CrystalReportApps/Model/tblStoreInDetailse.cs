namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblStoreInDetailse")]
    public partial class tblStoreInDetailse
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        [StringLength(50)]
        public string VoucherNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dtTransection { get; set; }

        public decimal? Qty { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(550)]
        public string Remarks { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MakeDate { get; set; }

        [StringLength(50)]
        public string MakeBy { get; set; }
    }
}
