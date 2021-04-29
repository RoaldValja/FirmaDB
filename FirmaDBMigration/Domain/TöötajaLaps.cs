using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class TöötajaLaps
    {
        [Key]
        public int TöötajaLapsId { get; set; }
        public int? TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        [MaxLength(30)]
        public string Eesnimi { get; set; }
        [Required]
        [MaxLength(30)]
        public string Perekonnanimi { get; set; }
        [Required]
        public Sugu Sugu { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Sünniaasta { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
    }
}
