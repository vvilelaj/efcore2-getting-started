using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
    public class Samurai
    {
        public Samurai()
        {
            Quogtes = new List<Quote>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quogtes { get; set; }
        //public int BatleId { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
