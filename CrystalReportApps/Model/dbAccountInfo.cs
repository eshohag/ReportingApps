namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbAccountInfo")]
    public partial class dbAccountInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbAccountInfo()
        {
            tblMasterTransections = new HashSet<tblMasterTransection>();
            tblStoreInMasters = new HashSet<tblStoreInMaster>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string AccountHead { get; set; }

        [StringLength(50)]
        public string AccountType { get; set; }

        public decimal? Balance { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMasterTransection> tblMasterTransections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStoreInMaster> tblStoreInMasters { get; set; }
    }
}
