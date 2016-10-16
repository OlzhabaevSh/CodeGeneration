using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_4_App
{
    using CodeGenerator.Models;
    using System.Reflection;

    class Program
    {
        private static void getLast()
        {
            //System.IO.File.WriteAllText("outputPage.html", template);
        }

        private static Assembly GetAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }


        static void Main(string[] args)
        {

            var generator = new CodeGenerator.Generator() { Assembly = GetAssembly() };

            generator.GenerateViewModelSimple(typeof(Person), "str");
            
        }

        public class Region//: IToConvertSearchable
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }

        public class Position: IToConvertSearchable
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }

        public class Person: IToConvertSearchable
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public DateTime Date { get; set; }
            public Region Region { get; set; }
            public Position Position { get; set; }
        }
        

        public class Order: IToConvertSearchable
        {
            public int Id { get; set; }
            public DateTime OrdeDate { get; set; }
            public List<Person> Customers { get; set; }
            public int[] SendRegions { get; set; }
            public List<int> CurrentPositions { get; set; }
        }

    }
}
