namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        public int Id { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public int? Price { get; set; }

        [StringLength(30)]
        public string CategoryName { get; set; }

        [StringLength(30)]
        public string ImageName { get; set; }

        [StringLength(30)]
        public string MetaTitle { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual DANHMUC DANHMUC { get; set; }
    }
}
