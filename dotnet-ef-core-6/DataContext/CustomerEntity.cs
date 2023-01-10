using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotnet_ef_core_6.DataContext
{
    [Table("tbl_customer")]
    public class CustomerEntity
    {
        [Key]
        [Column("id")]
        public int CustomerId { get; set; }

        [Column("customer_name")]
        public String CustomerName { get; set; }

        [Column("customer_gender")]
        public String Gender { get; set; }

        [Column("customer_address")]
        public String Address { get; set; }

        [Column("customer_city")]
        public String City { get; set; }

        [Column("customer_province")]
        public String Province { get; set; }
    }
}
