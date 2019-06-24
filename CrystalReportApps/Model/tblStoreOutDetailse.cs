namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblStoreOutDetailse")]
    public partial class tblStoreOutDetailse
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string InvoiceNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dtSale { get; set; }

        public int? Product_Id { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public decimal? Qty { get; set; }

        public decimal? UnitMss { get; set; }

        public decimal? TotalMass { get; set; }

        public decimal? UnitRate { get; set; }

        public decimal? Price { get; set; }

        public int? CustomerId { get; set; }

        public int? AccountId { get; set; }

        public decimal? LaburCharge { get; set; }

        public decimal? LabourCost { get; set; }

        public decimal? BagCharge { get; set; }

        public decimal? BagCost { get; set; }

        public decimal? TotalAmount { get; set; }

        public int? BrokerId { get; set; }

        public decimal? BrokerRate { get; set; }

        public decimal? BrokerAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MakeDate { get; set; }
    }
}
