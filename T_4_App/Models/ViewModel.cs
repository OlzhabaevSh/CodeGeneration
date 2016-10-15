using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_4_App.Models
{
    public interface ICustomConvert { }

    public class ViewModel: ICustomConvert
    {
        public string Title { get; set; }
        public List<ViewModelProperty> Properties { get; set; }
    }

    public class TestModel : ICustomConvert
    {
        public int Id { get; set; }
        public float Float { get; set; }
        public double Double { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public ViewModel Model { get; set; }
        public List<int> Numbers { get; set; }
        public List<string> Names { get; set; }
        public int[] Vals { get; set; }
        public string[] Phones { get; set; }
    }

    public class ViewModelProperty
    {
        public string Title { get; set; }
        public string Type { get; set; }
    }


}
