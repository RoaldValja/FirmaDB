using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class Vihje
    {
        [Key]
        public int VihjeId { get; set; }
        public int? TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Vihje_kirjeldus { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Kuupäev { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
    }
}
