using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TSViewModelTemplate
    {
        public bool IsModule { get; set; } = false;

        public string ModuleText
        {
            get
            {
                return IsModule ? "export" : string.Empty;
            }
        }

        public string Namespace { get; set; } = "ViewModels";

        public string Name { get; set; }

        public Dictionary<string, string> Properties { get; set; }

    }
}
