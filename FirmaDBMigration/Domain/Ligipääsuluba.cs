using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class Ligipääsuluba
    {
        [Key]
        public int LigipääsulubaId { get; set; }
        public int? TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        public int LigipääsuTase { get; set; }
        [Required]
        public DateTime Ligipääsu_algus { get; set; }
        [Required]
        public DateTime Ligipääsu_lõpp { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
    }
}
