using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScatterGraph
{
    public class Plot
    {

        public int Age {  get; set; }
        public double Hours { get; set; }
        public SolidBrush Brush { get; set; }

        public Plot(int age, double hours, SolidBrush brush) 
        {
            Age = age;
            Hours = hours;
            Brush = brush;
        }
    }
}
