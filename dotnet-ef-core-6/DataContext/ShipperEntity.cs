using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef_core_6.DataContext
{
    [Table("tbl_shipper")]
    public class ShipperEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("shipper_name")]
        public String NamaShipper { get; set; }

        [Column("shipper_product")]
        public String Product { get; set; }

        [Column("shipper_region")]
        public String Region { get; set; }

        [Column("shipper_price")]
        public int PriceShipper { get; set; }

        [Column("shipper_branch")]
        public int Branch { get; set; }
    }
}
