using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFlower01.Shared.Entities
{
    public class Oder
    {
        public int Id { get; set; }

        //
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public string? Address { get; set; }

        //
        public int? FlowersId { get; set; }
        public Flower? Flower { get; set; }

        public string Colour { get; set; }
        public string Contity { get; set; }
        public string Price { get; set; }
        public DateTime? OderDate { get; set; }
    }
}
