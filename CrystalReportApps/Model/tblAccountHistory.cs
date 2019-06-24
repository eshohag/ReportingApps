namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAccountHistory")]
    public partial class tblAccountHistory
    {
        public int Id { get; set; }

        public int? PartyId { get; set; }

        public int? AccountId { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? CreditAmount { get; set; }

        public DateTime? Date { get; set; }
    }
}
