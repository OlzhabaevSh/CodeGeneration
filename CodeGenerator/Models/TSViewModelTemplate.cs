using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Models
{
    public class TSViewModelTemplate
    {        
        public string Name { get; set; }

        public Dictionary<string, string> Properties { get; set; }
    }
}
