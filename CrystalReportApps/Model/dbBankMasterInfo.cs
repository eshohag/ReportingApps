namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbBankMasterInfo")]
    public partial class dbBankMasterInfo
    {
        public int Id { get; set; }

        public int? BankId { get; set; }

        public decimal? OpeningBalance { get; set; }

        public decimal? DebitedBalance { get; set; }

        public decimal? CreditedBlance { get; set; }

        public decimal? ClosingBalance { get; set; }

        public DateTime? BalanceDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
