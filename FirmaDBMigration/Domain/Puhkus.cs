using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class Puhkus
    {
        [Key]
        public int PuhkusId { get; set; }
        public int? TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        public DateTime Puhkuse_algus { get; set; }
        [Required]
        public DateTime Puhkuse_lõpp { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
        public List<PuhkuseLiik> PuhkuseLiiks { get; set; }
    }
}
