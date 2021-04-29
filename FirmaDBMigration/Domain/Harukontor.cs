using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FirmaDBMigration.Domain
{
    class Harukontor
    {
        [Key]
        public int HarukontorId { get; set; }
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nimi { get; set; }
        [Required]
        [MaxLength(50)]
        public string Aadress { get; set; }
        [Required]
        [MaxLength(30)]
        public string Kontaktisik { get; set; }
        [Required]
        [MaxLength(15)]
        public string Kontakt_telefon { get; set; }
        [Required]
        [MaxLength(30)]
        public string Kontakt_email { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
        public ICollection<AsjadeLaenutus> AsjadeLaenutus { get; set; }
        public List<Töötaja> Töötajas { get; set; }
    }
}
