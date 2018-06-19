using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SamuraiApp.Data;
using SamuraiApp.Domain;

namespace SomeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertSamurai();
            //InsertManySamurais();
            //var samurai = GetSamurai("Victor");

            //Console.WriteLine($"{samurai.Id} - {samurai.Name}");

            //var samurais = GetSamurais("Victor");
            //foreach (var samurai in samurais)
            //{
            //    Console.WriteLine($"{samurai.Id} - {samurai.Name}");
            //}

            //UpdateSamurai();

            //ManyCommands();

            DeleteSamurai();
        }

        private static void InsertSamurai()
        {
            var samurai = new Samurai {Name = "Victor"};
            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }

        private static void InsertManySamurais()
        {
            using (var context = new SamuraiContext())
            {
                context.Samurais.AddRange(new List<Samurai>
                {
                    new Samurai(){Name = "Victor 10"},
                    new Samurai(){Name = "Victor 11"},
                    new Samurai(){Name = "Victor 12"},
                    new Samurai(){Name = "Victor 13"},
                });
                context.SaveChanges();
            }
        }

        private static Samurai GetSamurai(string name)
        {
            using (var context = new SamuraiContext())
            {
                return context.Samurais.FirstOrDefault(x => x.Name == name);
            }
        }

        private static List<Samurai> GetSamurais(string name)
        {
            using (var context = new SamuraiContext())
            {
                return context.Samurais.Where(x => EF.Functions.Like(x.Name, name + "%")).ToList();
            }
        }

        private static void UpdateSamurai()
        {
            using (var context = new SamuraiContext())
            {
                var samuraiVictor = context.Samurais.First(x => x.Name == "Victor");
                samuraiVictor.Name = "Victor Vilela";
                context.SaveChanges();
            }
        }

        private static void ManyCommands()
        {
            using (var context = new SamuraiContext())
            {
                var samuraiVictor = context.Samurais.First();
                samuraiVictor.Name = "Victor Vilela Jacobo";
                context.Samurais.Add(new Samurai() {Name = "Richard Vilela"});
                context.Samurais.Add(new Samurai() { Name = "Hector" });
                context.SaveChanges();
            }
        }

        private static void DeleteSamurai()
        {
            using (var context = new SamuraiContext())
            {
                var samuraiVictor = context.Samurais.FirstOrDefault(x=> x.Name == "Victor");
                if(samuraiVictor != null) context.Samurais.Remove(samuraiVictor);
                context.SaveChanges();
            }
        }
    }
}
