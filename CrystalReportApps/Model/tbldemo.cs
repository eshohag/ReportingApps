namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbldemo")]
    public partial class tbldemo
    {
        public int Id { get; set; }

        public int? PartyId { get; set; }

        public int? AccountId { get; set; }

        public decimal? Cr_Amount { get; set; }

        public decimal? Dr_Amount { get; set; }

        public DateTime? Date { get; set; }
    }
}
