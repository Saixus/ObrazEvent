namespace ObrazEvent.Data.Migrations
{
    using ObrazEvent.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ObrazEvent.Data.ObrazEventDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ObrazEvent.Data.ObrazEventDbContext context)
        {
            context.Services.AddOrUpdate(x => x.Name,
                new Service() { Name = "Мимы", Description = "Описание выступления мимов.. Краткое. Какой-то текст, который что-то описывает. Тра-та-та." },
                new Service() { Name = "Живые скульптуры", Description = "Другое описание чего-то ещё. Текст текст текст." },
                new Service() { Name = "Детская анимация", Description = "Анимация. Интересно, от куда происходит это слово? Неужели от animls?.." });

            context.SaveChanges();

            context.Videos.AddOrUpdate(x => x.Name,
                new Video() { Name = "1", Service = context.Services.Find(1), Url = "http://youtube.com?v=123321" },
                new Video() { Name = "2", Service = context.Services.Find(1), Url = "http://youtube.com?v=123321" },
            new Video() { Name = "3", Service = context.Services.Find(2), Url = "http://youtube.com?v=123321" },
            new Video() { Name = "4", Service = context.Services.Find(2), Url = "http://youtube.com?v=123321" },
            new Video() { Name = "5", Service = context.Services.Find(2), Url = "http://youtube.com?v=123321" },
            new Video() { Name = "6", Service = context.Services.Find(3), Url = "http://youtube.com?v=123321" },
            new Video() { Name = "7", Service = context.Services.Find(3), Url = "http://youtube.com?v=123321" });

            context.SaveChanges();


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
