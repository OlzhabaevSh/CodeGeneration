using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    using Models;

    public partial class ViewModelTemplate
    {
        public bool IsModule { get; set; } = false;

        public string ModuleText
        {
            get
            {
                return IsModule ? "export" : string.Empty;
            }
        }

        public string Namespace { get; set; } = "Proxy";

        public List<TSViewModelTemplate> Types { get; set; }
    }

    public partial class HttpServiceTemplate
    {
        public bool IsModule { get; set; } = false;

        public string ModuleText
        {
            get
            {
                return IsModule ? "export" : string.Empty;
            }
        }

        public string Namespace { get; set; } = "Proxy";

        public bool IsGenerateModel { get; set; } = true;

        public TSViewModelTemplate Type { get; set; }

        public string ClassName { get; set; } = "Test";
    }


}
