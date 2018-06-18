using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        //public List<Samurai> Samuais { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
