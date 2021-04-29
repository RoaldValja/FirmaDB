using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class AsjadeLaenutus
    {
        [Key]
        public int AsjadeLaenutusId { get; set; }
        public int? HarukontorId { get; set; }
        public Harukontor Harukontor { get; set; }
        public int? TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        [MaxLength(30)]
        public string Asja_nimi { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Asja_kirjeldus { get; set; }
        [Required]
        public int Kogus { get; set; }
        [Required]
        public DateTime Laenutuse_algus { get; set; }
        [Required]
        public DateTime Laenutuse_lõpp { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
    }
}
