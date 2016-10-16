using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient.Models
{
    using CodeGenerator.Models;

    public class Region: IToConvertSearchable
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
