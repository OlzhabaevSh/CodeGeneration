using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_4_App.Converters
{
    using Models;
    using System.Reflection;

    public class PropertyConverter
    {
        private Dictionary<Type, string> _vals;

        public PropertyConverter()
        {
            _vals = new Dictionary<Type, string>();
        }

        private void RegistTypes()
        {
            //_vals.Add(int, "");
        }

        public ViewModelProperty ConvertProperty(PropertyInfo property)
        {
            var res = new ViewModelProperty();



            return res;
        }
    }
}
