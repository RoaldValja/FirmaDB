using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class Tervisekontroll
    {
        [Key]
        public int TervisekontrollId { get; set; }
        public int? TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        public DateTime Tervisekontrolli_aeg { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
    }
}
