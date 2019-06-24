namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBankTransaction")]
    public partial class tblBankTransaction
    {
        public int Id { get; set; }

        public int? BankId { get; set; }

        public decimal? OpeningBalance { get; set; }

        public decimal? WithdrawBalance { get; set; }

        public decimal? DeepositBalance { get; set; }

        public decimal? ClosingBalance { get; set; }

        public DateTime? Date { get; set; }
    }
}
