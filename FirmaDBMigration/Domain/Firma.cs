using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FirmaDBMigration.Domain
{
    class Firma
    {
        [Key]
        public int FirmaId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Registri_number { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nimi { get; set; }
        [Required]
        [MaxLength(20)]
        public string Lühinimi { get; set; }
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
        public List<Harukontor> Harukontors { get; set; }

    }
}
