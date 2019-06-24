namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbPartyInfo")]
    public partial class dbPartyInfo
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string PartyName { get; set; }

        [StringLength(50)]
        public string PartyAddress { get; set; }

        [StringLength(50)]
        public string ContactNo { get; set; }

        public decimal? OpeningBalance { get; set; }

        public DateTime? OpeningDate { get; set; }

        [StringLength(50)]
        public string Remarks { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
