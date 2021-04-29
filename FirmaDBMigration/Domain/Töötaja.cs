using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FirmaDBMigration.Domain
{
    public enum Sugu
    {
        Mees,
        Naine,
        Teadmatu
    }
    class Töötaja
    {
        [Key]
        public int TöötajaId { get; set; }
        public int HarukontorId { get; set; }
        public Harukontor Harukontor { get; set; }
        [Required]
        [MaxLength(30)]
        public string Eesnimi { get; set; }
        [Required]
        [MaxLength(30)]
        public string Perekonnanimi { get; set; }
        [Required]
        [MaxLength(11)]
        [Column(TypeName = "nchar")]
        public string Isikukood { get; set; }
        [Required]
        public Sugu Sugu { get; set; }
        [Required]
        [MaxLength(50)]
        public string Kontakt_aadress { get; set; }
        [Required]
        [MaxLength(15)]
        public string Kontakt_telefon { get; set; }
        [Required]
        [MaxLength(30)]
        public string Kontakt_email { get; set; }
        [Required]
        public DateTime Tööl_alates { get; set; }
        [Required]
        public DateTime Tööl_kuni { get; set; }
        public String Kommentaar { get; set; }
        public ICollection<AsjadeLaenutus> AsjadeLaenutus { get; set; }
        public ICollection<Puhkus> Puhkus { get; set; }
        public List<Ametinimetus> Ametinimetus { get; set; }
        public ICollection<Haigusleht> Haiguslehts { get; set; }
        public ICollection<Tervisekontroll> Tervisekontrolls { get; set; }
        public ICollection<Ligipääsuluba> Ligipääsulubas { get; set; }
        public ICollection<TöötajaLaps> TöötajaLaps { get; set; }
        public ICollection<Vihje> Vihjes { get; set; }
        public ICollection<Palve> Palves { get; set; }
    }
}
