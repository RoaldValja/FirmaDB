using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class Palve
    {
        [Key]
        public int PalveId { get; set; }
        public int? TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        [MaxLength(30)]
        public string Töötaja_nimi { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Palve_kirjeldus { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Kuupäev { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
    }
}
