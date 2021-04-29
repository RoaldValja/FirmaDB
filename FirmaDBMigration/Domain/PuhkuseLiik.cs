using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirmaDBMigration.Domain
{
    class PuhkuseLiik
    {
        [Key]
        public int Puhkuse_liikId { get; set; }
        public int PuhkusId { get; set; }
        public Puhkus Puhkus { get; set; }
        [Required]
        [MaxLength(30)]
        public string Puhkuse_liik { get; set; }
        [MaxLength(2000)]
        public string Kommentaar { get; set; }
    }
}
