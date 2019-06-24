namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPartyTrnasection")]
    public partial class tblPartyTrnasection
    {
        [Key]
        public int system_id { get; set; }

        public int? Party_id { get; set; }

        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [StringLength(50)]
        public string DueInvoice { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(550)]
        public string Remark { get; set; }

        public decimal? Cr_Amnt { get; set; }

        public decimal? Dr_Amnt { get; set; }

        [StringLength(50)]
        public string makeBy { get; set; }

        public DateTime? makeDate { get; set; }

        [StringLength(50)]
        public string updateBy { get; set; }

        public DateTime? updateDate { get; set; }

        [StringLength(50)]
        public string deleteBy { get; set; }

        public DateTime? deleteDate { get; set; }

        public bool? ysnactive { get; set; }
    }
}
