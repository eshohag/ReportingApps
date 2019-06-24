namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBrokerInformation")]
    public partial class tblBrokerInformation
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string BrokerName { get; set; }

        [StringLength(50)]
        public string BrokerContactNo { get; set; }

        [StringLength(50)]
        public string BrokerAddress { get; set; }
    }
}
