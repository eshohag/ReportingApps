namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAccountDueCollection")]
    public partial class tblAccountDueCollection
    {
        public int Id { get; set; }

        public int? PartyId { get; set; }

        public int? AccountId { get; set; }

        public decimal? DueAmount { get; set; }

        public decimal? DebitAmount { get; set; }

        public decimal? CredtiAmount { get; set; }

        public DateTime? MakeDate { get; set; }
    }
}
