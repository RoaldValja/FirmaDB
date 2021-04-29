using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using FirmaDBMigration.Domain;

namespace FirmaDBMigration.Context
{
    class FirmaDBContext : DbContext
    {
        public FirmaDBContext() : base()
        {
            Database.SetInitializer<FirmaDBContext>(new DropCreateDatabaseIfModelChanges<FirmaDBContext>());
        }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Harukontor> Harukontors { get; set; }
        public DbSet<AsjadeLaenutus> AsjadeLaenutuss { get; set; }
        public DbSet<Töötaja> Töötajas { get; set; }
        public DbSet<Puhkus> Puhkus { get; set; }
        public DbSet<PuhkuseLiik> PuhkuseLiiks { get; set; }
        public DbSet<Ametinimetus> Ametinimetus { get; set; }
        public DbSet<Haigusleht> Haiguslehts { get; set; }
        public DbSet<Tervisekontroll> Tervisekontrolls { get; set; }
        public DbSet<Ligipääsuluba> Ligipääsulubas { get; set; }
        public DbSet<TöötajaLaps> TöötajaLaps { get; set; }
        public DbSet<Vihje> Vihjes { get; set; }
        public DbSet<Palve> Palves { get; set; }
    }
}
