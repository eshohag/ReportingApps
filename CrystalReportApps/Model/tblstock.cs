namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblstock")]
    public partial class tblstock
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public decimal? PurchaseQty { get; set; }

        public decimal? SaleQty { get; set; }

        public DateTime? Date { get; set; }
    }
}
