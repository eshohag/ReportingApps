namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBankSummary")]
    public partial class tblBankSummary
    {
        public int Id { get; set; }

        public int? BankId { get; set; }

        public int? AccountId { get; set; }

        public decimal? OpeningBalance { get; set; }

        public decimal? WithdrawBalance { get; set; }

        public decimal? DeepositBalance { get; set; }

        public decimal? ClosingBalance { get; set; }

        public DateTime? Date { get; set; }
    }
}
