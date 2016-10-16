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

        public string Namespace { get; set; } = "ViewModels";

        public List<TSViewModelTemplate> Types { get; set; }
    }
}
