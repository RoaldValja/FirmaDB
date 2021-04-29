using FirmaDBMigration.Context;
using FirmaDBMigration.Domain;
using System;

namespace FirmaDBMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new FirmaDBContext())
            {
                db.Firmas.Add(new Firma { FirmaId = 1, Registri_number = "123", Nimi = "firma1", Lühinimi = "f1", Aadress = "a1", Kontaktisik = "isik1", Kontakt_telefon = "1234567", Kontakt_email = "email1", Kommentaar = "komment1"});
                db.Harukontors.Add(new Harukontor { HarukontorId = 1, FirmaId = 1, Aadress = "ah1", Kommentaar = "komment1", Kontaktisik = "isik1", Kontakt_email = "email1", Kontakt_telefon = "1234567", Nimi = "haru1" });
                //db.Employees.Add(new Employee { Id = 1, FirstName = “Roald”, LastName = “Valja”});
              //  db.Employees.Add(new Employee { Id = 2, FirstName = “Karl”, LastName = “Jakobson”});
                db.SaveChanges();

                foreach (var firma in db.Firmas)
                {
                    Console.WriteLine(firma.Nimi);
                }
                foreach (var harukontor in db.Harukontors)
                {
                    Console.WriteLine(harukontor.Nimi);
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
