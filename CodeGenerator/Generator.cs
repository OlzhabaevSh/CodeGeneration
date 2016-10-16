using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    using Models;

    public class Generator
    {
        public Assembly Assembly { get; set; }

        public void GenerateViewModelSimple(Type type, string path, bool includeModule = false, bool isSearchInterfaces = true)
        {
            var parser = new Parser() { IsFindInterface = isSearchInterfaces, Assembly = Assembly }; 
            
            var properties = type.GetProperties();

            var tsVMModel = new TSViewModelTemplate()
            {
                Name = type.Name,
                Properties = new Dictionary<string, string>()
            };
            
            foreach (var item in properties)
            {
                tsVMModel.Properties.Add(item.Name, parser.Convert(item.PropertyType));
            }

            var generator = new ViewModelTemplate() { Model = tsVMModel };

            var template = generator.TransformText();
        }
    }
}
