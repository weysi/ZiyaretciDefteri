namespace CFZiyaretciDefteri.Migrations
{
    using CFZiyaretciDefteri.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CFZiyaretciDefteri.Models.ZiyaretContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CFZiyaretciDefteri.Models.ZiyaretContext context)
        {
            if(context.Uyeler.Count() == 0)
            {
                Uye u1 = new Uye();
                u1.AdSoyad = "Duygu Öðünç";
                u1.Email = "d@d.com";
                u1.Sifre = "123";

                Uye u2 = new Uye();
                u2.AdSoyad = "Yönetici";
                u2.Email = "y@y.com";
                u2.Sifre = "123";

                context.Uyeler.Add(u1);
                context.Uyeler.Add(u2);

                context.SaveChanges();
            }
        }
    }
}
