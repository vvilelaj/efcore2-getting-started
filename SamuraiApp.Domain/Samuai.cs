using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
    public class Samuai
    {
        public Samuai()
        {
            Quogtes = new List<Quote>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quogtes { get; set; }
        public int BatleId { get; set; }
    }
}
