namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MassStore")]
    public partial class MassStore
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public decimal? Mass { get; set; }

        public DateTime? MakeDate { get; set; }
    }
}
