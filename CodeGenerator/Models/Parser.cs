using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Models
{
    public class Parser
    {
        private Assembly _assembly;
        public Assembly Assembly
        {
            set { _assembly = value; }
            get
            {
                if (_assembly == null)
                {
                    throw new Exception("Assemble не выб передан вместе с конструктором");
                }
                return _assembly;
            }

        }

        public bool IsFindInterface { get; set; } = false;

        private Dictionary<Type, string> _vals;

        public Parser()
        {
            _vals = new Dictionary<Type, string>();
            RegistTypes();
        }

        public string Convert(Type type)
        {
            var res = string.Empty;

            if (_vals.Any(x => x.Key == type))
            {
                res = _vals.First(x => x.Key == type).Value;
            }
            else
            {
                res = GenerateCustomName(type);
            }

            return res;
        }
        
        private void RegistTypes()
        {
            // numbers
            _vals.Add(typeof(int), "number");
            _vals.Add(typeof(float), "number");
            _vals.Add(typeof(double), "number");
            _vals.Add(typeof(long), "number");
            // date
            _vals.Add(typeof(DateTime), "Date");
            _vals.Add(typeof(DateTimeOffset), "Date");
            // string
            _vals.Add(typeof(string), "string");
            // primitive types array numbers
            _vals.Add(typeof(int[]), "Array<number>");
            _vals.Add(typeof(float[]), "Array<number>");
            _vals.Add(typeof(double[]), "Array<number>");
            _vals.Add(typeof(long[]), "Array<number>");
            // primitive types array string
            _vals.Add(typeof(string[]), "Array<string>");
            // primitive types array date
            _vals.Add(typeof(DateTime[]), "Array<Date>");
            // list numbers
            _vals.Add(typeof(List<int>), "Array<number>");
            _vals.Add(typeof(List<float>), "Array<number>");
            _vals.Add(typeof(List<double>), "Array<number>");
            _vals.Add(typeof(List<long>), "Array<number>");
            // list strings
            _vals.Add(typeof(List<string>), "Array<string>");
            // list dates
            _vals.Add(typeof(List<DateTime>), "Array<Date>");
        }

        private string GenerateCustomName(Type type)
        {
            var res = "any";

            if (type.IsArray)
            {
                res = "Array<any>";
            }

            // IEnumarable
            else if (type.GetInterfaces().Any(x => x.Name == "IEnumerable"))
            {
                var genericArg = type.GetGenericArguments().First();

                if (_vals.Any(x => x.Key == genericArg))
                {
                    var argName = _vals.First(x => x.Key == genericArg).Value;
                    res = string.Format("Array<{0}>", argName);
                }
                else if (IsFindInterface)
                {
                    
                    var types = Assembly.GetTypes().Where(x => x.GetInterfaces().Any(tp => tp == typeof(IToConvertSearchable))).ToList();

                    if (types.Any(x => x.Name == genericArg.Name))
                    {
                        res = string.Format("Array<I{0}>", genericArg.Name);
                    }
                    else
                    {
                        res = "Array<any>";
                    }
                }
                else
                {
                    res = "Array<any>";
                }

            }
            else if (IsFindInterface)
            {
                var types = Assembly.GetTypes().Where(x => x.GetInterfaces().Any(tp => tp.Name == typeof(IToConvertSearchable).Name)).ToList();

                if (types.Any(x => x.Name == type.Name))
                {
                    res = string.Format("I{0}", type.Name);
                }
                else
                {
                    res = "any";
                }
            }


            return res;
        }

    }
}
