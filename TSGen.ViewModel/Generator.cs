using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TSGen.ViewModel.Models;

namespace TSGen.ViewModel
{
    public class Generator
    {
        public Assembly Assemply { get; set; }

        public string GenerateCodeBasic(Type type)
        {
            var properties = type.GetProperties().Where(x => x.PropertyType.IsPublic).ToList();

            var modelProperties = new List<string>();

            foreach (var item in properties)
            {
                modelProperties.Add(item.Name);
            }

            var mdl = new Models.InterfaceModelBasic()
            { 
                Name = type.Name,
                Properties = modelProperties
            };

            var generator = new TSGen.ViewModel.BasicTemplate() { Model = mdl };

            var template = generator.TransformText();
            return template;
        }

        public string GenerateCodeGeneral(Type type)
        {
            var parser = new Core.Parsers.PropertyParser() { IsFindInterface = true, Assemply = Assemply };

            var properties = type.GetProperties();

            var modelProperties = new List<InterfaceModelProperty>();

            foreach (var item in properties)
            {
                modelProperties.Add(new InterfaceModelProperty()
                {
                    FieldName = item.Name,
                    TypeName = parser.Convert(item.PropertyType)
                });
            }

            var mdl = new InterfaceModelGeneral()
            {
                Name = "Person",
                Properties = modelProperties
            };

            var generator = new GeneralTemplate() { Model = mdl };

            var template = generator.TransformText();
            return template;
        }


    }

}
