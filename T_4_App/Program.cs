using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_4_App
{
    using Models;
    using System.Reflection;

    class Program
    {
        private static ViewModel Generate()
        {
            return new ViewModel()
            {
                Title = "Person",
                Properties = new List<ViewModelProperty>()
                {
                   new ViewModelProperty() { Title = "id", Type = "number" },
                   new ViewModelProperty() { Title = "title", Type = "string" },
                   new ViewModelProperty() { Title = "age", Type = "number" },
                }
            };
        }

        private static void getLast()
        {
            var data = Generate();

            var generation = new TypeScriptViewModelTemplate() { Model = data };

            var template = generation.TransformText();

            //System.IO.File.WriteAllText("outputPage.html", template);
        }



        static void Main(string[] args)
        {
            var data = Generate();

            Type type = typeof(Models.ViewModel);

            Type searchInterface = typeof(Models.ICustomConvert);

            var ss = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.GetInterfaces().Any((t) => t.Name == searchInterface.Name)).ToList();

            foreach (var tp in ss)
            {
                var attrs = tp.GetProperties();
            }

        }


    }
}
