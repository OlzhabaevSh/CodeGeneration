using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSGen.ViewModel.Models
{
    public class InterfaceModelBasic
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

        public List<string> Properties { get; set; }
    }

    public class InterfaceModelGeneral
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

        public List<InterfaceModelProperty> Properties { get; set; }
    }

    public class InterfaceModelProperty
    {
        public string FieldName { get; set; }
        public string TypeName { get; set; }
    }

}
