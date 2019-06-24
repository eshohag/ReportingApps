namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBalanceSheet")]
    public partial class tblBalanceSheet
    {
        public int Id { get; set; }

        public int? AccountId { get; set; }

        public decimal? Balance { get; set; }

        public decimal? TotalSale { get; set; }

        public decimal? ClientDebit { get; set; }

        public decimal? BankDebit { get; set; }

        public decimal? ExpenseDebit { get; set; }

        public decimal? Part1 { get; set; }

        public decimal? BankCredit { get; set; }

        public decimal? ClientCredit { get; set; }

        public decimal? labour { get; set; }

        public decimal? ExpenseCredit { get; set; }

        public decimal? Part2 { get; set; }

        public decimal? CashInHand { get; set; }

        public decimal? PrevAccReceiv { get; set; }

        public decimal? TAR { get; set; }

        public decimal? CashCollected { get; set; }

        public decimal? Summary { get; set; }

        public DateTime? MakeDate { get; set; }
    }
}
