using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef_core_6.DataContext
{
    [Table("tbl_kos")]
    public class KosEntity
    {
        [Key]
        [Column("kos_id")]
        public int Id { get; set; }

        [Column("kos_nama")]
        public String NamaPenyewa { get; set; }

        [Column("kos_gender")]
        public String Gender { get; set; }

        [Column("kos_status")]
        public String Status { get; set; }

        [Column("kos_sewa")]
        public int Sewa { get; set; }

        [Column("kos_jenis")]
        public String JenisKos { get; set; }

        [Column("kos_waktu")]
        public int LamaSewa { get; set; }
    }
}
