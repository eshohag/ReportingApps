namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblExpense")]
    public partial class tblExpense
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string AccountId { get; set; }

        [StringLength(50)]
        public string ExpenseName { get; set; }

        public decimal? Withdraw { get; set; }

        public decimal? Deeposit { get; set; }

        public DateTime? MakeDate { get; set; }
    }
}
