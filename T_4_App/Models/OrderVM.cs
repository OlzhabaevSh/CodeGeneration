using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_4_App.Models
{
    public class OrderVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public int RegionFromId { get; set; }
        public RegionVM RegionFrom { get; set; }

        public int RegionToId { get; set; }
        public RegionVM RegionTo { get; set; }

        public int RecipientId { get; set; }
        public PersonVM Recipient { get; set; }

        public List<int> Indexes { get; set; }

        public List<string> Areas { get; set; }

    }
}
