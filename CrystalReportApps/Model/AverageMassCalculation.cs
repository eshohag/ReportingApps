namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AverageMassCalculation")]
    public partial class AverageMassCalculation
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Remarks { get; set; }

        public int? ProductId { get; set; }

        public decimal? Qty { get; set; }

        public decimal? TotalMass { get; set; }

        public decimal? AverageMass { get; set; }

        public DateTime? MakeDate { get; set; }
    }
}
