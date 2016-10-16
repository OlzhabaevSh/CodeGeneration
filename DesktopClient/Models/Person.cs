using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient.Models
{
    using CodeGenerator.Models;

    class Person: IToConvertSearchable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public List<string> Tasks { get; set; }
    }
}
