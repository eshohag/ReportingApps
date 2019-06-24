namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblStoreOutMaster")]
    public partial class tblStoreOutMaster
    {
        [Key]
        public int aId { get; set; }

        [StringLength(150)]
        public string InvoiceNo { get; set; }

        public int? CustomerId { get; set; }

        public DateTime? TrnDate { get; set; }

        public int? AccountId { get; set; }

        public decimal? LaburCharge { get; set; }

        public decimal? LabourCost { get; set; }

        public decimal? BagCharge { get; set; }

        public decimal? BagCost { get; set; }

        public decimal? TotalAmount { get; set; }

        public int? BrokerId { get; set; }

        public decimal? TransportCost { get; set; }

        public decimal? ReciveAmount { get; set; }

        public decimal? GrandTotal { get; set; }

        [StringLength(50)]
        public string MakeBy { get; set; }

        public DateTime? MakeDate { get; set; }
    }
}
