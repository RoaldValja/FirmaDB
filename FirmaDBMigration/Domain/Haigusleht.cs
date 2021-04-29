using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class Haigusleht
    {
        [Key]
        public int HaiguslehtId { get; set; }
        public int? TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        public DateTime Haiguslehe_algus { get; set; }
        [Required]
        public DateTime Haiguslehe_lõpp { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
    }
}
