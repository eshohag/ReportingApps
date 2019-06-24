namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAccountTransaction")]
    public partial class tblAccountTransaction
    {
        public int Id { get; set; }

        public int? AccountId { get; set; }

        public int? CustomerId { get; set; }

        [StringLength(50)]
        public string InvoiceNo { get; set; }

        public decimal? GrandTotal { get; set; }

        public decimal? ReciveAmount { get; set; }

        public DateTime? MakeDate { get; set; }
    }
}
