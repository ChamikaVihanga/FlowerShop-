using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFlower01.Shared.Entities
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cloure { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }

        //
        public List<Oder>? Oders { get; set; }
    }
}
