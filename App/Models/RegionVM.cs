using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    using CodeGenerator.Models;

    public class RegionVM : IToConvertSearchable
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
