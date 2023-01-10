using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef_core_6.DataContext
{
    [Table("tbl_rental")]
    public class RentalEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("rental_nama")]
        public String NamaPenyewa { get; set; }

        [Column("rental_jenis")]
        public String Jenis { get; set; }

        [Column("rental_merk")]
        public String Merk { get; set; }

        [Column("rental_sewa")]
        public int Sewa { get; set; }

        [Column("rental_harisewa")]
        public int HariSewa { get; set; }
    }
}
