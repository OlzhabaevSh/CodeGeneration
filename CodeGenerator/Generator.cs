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

        public void GenerateViewModelSimple(Type type, string path, bool isSearchInterfaces = true, bool includeModule = false)
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
                var propertyInfo = parser.Convert(item.PropertyType, isSearchInterfaces);

                var propertyName = propertyInfo.ValueTypeNullable ? item.Name + "?" : item.Name; 

                tsVMModel.Properties.Add(propertyName, propertyInfo.TypeName);
            }

            var data = new List<TSViewModelTemplate>() { tsVMModel };

            var generator = new ViewModelTemplate() { Types = data };

            var template = generator.TransformText();
            var savePath = string.Format("{0}\\{1}.ts", path, tsVMModel.Name);
            System.IO.File.WriteAllText(savePath, template);
        }

        public void GenerateViewModelSimple(List<Type> types, string path, bool isSearchInterfaces = true, bool includeModule = false)
        {
            var parser = new Parser() { IsFindInterface = isSearchInterfaces, Assembly = Assembly };

            var data = new List<TSViewModelTemplate>();

            foreach (var cType in types)
            {
                var properties = cType.GetProperties();

                var tsVMModel = new TSViewModelTemplate()
                {
                    Name = cType.Name,
                    Properties = new Dictionary<string, string>()
                };

                foreach (var item in properties)
                {
                    var propertyInfo = parser.Convert(item.PropertyType, isSearchInterfaces);

                    var propertyName = propertyInfo.ValueTypeNullable ? item.Name + "?" : item.Name;

                    tsVMModel.Properties.Add(propertyName, propertyInfo.TypeName);
                }

                data.Add(tsVMModel);
            }

            
            var generator = new ViewModelTemplate() { Types = data };

            var template = generator.TransformText();
            var savePath = string.Format("{0}\\{1}.ts", path, "ViewModels");
            System.IO.File.WriteAllText(savePath, template);
        }

        public void GenerateHttpService(Type type, string path, Type controllerType, bool isSearchInterfaces = true, bool includeModule = false)
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
                var propertyInfo = parser.Convert(item.PropertyType, isSearchInterfaces);

                var propertyName = propertyInfo.ValueTypeNullable ? item.Name + "?" : item.Name;

                tsVMModel.Properties.Add(propertyName, propertyInfo.TypeName);
            }

            var data = new List<TSViewModelTemplate>() { tsVMModel };

            var startIndex = controllerType.Name.IndexOf("Controller");
            var ctrlName = controllerType.Name.Remove(startIndex);

            var tmpl = new HttpServiceTemplate()
            {
                Type = data.First(),
                ClassName = ctrlName,
            };

            var res = tmpl.TransformText();
            var savePath = string.Format("{0}\\{1}{2}.ts", path, ctrlName, "Service");
            System.IO.File.WriteAllText(savePath, res);
        }

        public void GenerateHttpService(Type type, string path, string controllerName, bool isSearchInterfaces = true, bool includeModule = false)
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
                var propertyInfo = parser.Convert(item.PropertyType, isSearchInterfaces);

                var propertyName = propertyInfo.ValueTypeNullable ? item.Name + "?" : item.Name;

                tsVMModel.Properties.Add(propertyName, propertyInfo.TypeName);
            }

            var data = new List<TSViewModelTemplate>() { tsVMModel };
            
            var tmpl = new HttpServiceTemplate()
            {
                Type = data.First(), 
                ClassName = controllerName,
            };

            var res = tmpl.TransformText();
            var savePath = string.Format("{0}\\{1}.ts", path, tsVMModel.Name);
            System.IO.File.WriteAllText(savePath, res);
        }

        public List<Type> GetTypes()
        {
            return Assembly.GetTypes().ToList();
        }

        public List<Type> GetTypesForSearch()
        {
            return Assembly.GetTypes().Where(x => x.GetInterfaces().Any(tp => tp == typeof(IToConvertSearchable))).ToList();
        }

        public List<Type> GetTypes(Type interfaceType)
        {
            return Assembly.GetTypes().Where(x => x.GetInterfaces().Any(type => type.Name == interfaceType.Name)).ToList();
        }

    }
}
