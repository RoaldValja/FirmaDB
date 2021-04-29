using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class Ametinimetus
    {
        [Key]
        public int AmetinimetusId { get; set; }
        public int TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        [MaxLength(30)]
        public string Ametinimetus_nimi { get; set; }
        [Required]
        public DateTime Määramise_aeg { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
    }
}
