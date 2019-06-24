namespace CrystalReportApps.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbProductInfo")]
    public partial class dbProductInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbProductInfo()
        {
            tblStores = new HashSet<tblStore>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        public decimal? SalesPrice { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string OStock { get; set; }

        public int? StockLimit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStore> tblStores { get; set; }
    }
}
