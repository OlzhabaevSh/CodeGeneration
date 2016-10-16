using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient.Models
{
    using CodeGenerator.Models;

    class Order: IToConvertSearchable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public int RegionToId { get; set; }
        public Region RegionTo { get; set; }

        public List<Person> Executors { get; set; }

    }
}
