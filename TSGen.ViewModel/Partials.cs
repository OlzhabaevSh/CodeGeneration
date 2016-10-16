using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSGen.ViewModel
{
    using Models;

    public partial class BasicTemplate
    {
        public InterfaceModelBasic Model { get; set; }
    }

    public partial class GeneralTemplate
    {
        public InterfaceModelGeneral Model { get; set; }
    }

}
