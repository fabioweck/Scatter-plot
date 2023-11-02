using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScatterGraph
{
    //This class serves as a plot object, holding data to be used by the graph component

    public class Plot
    {
        public int Age {  get; set; }
        public double Hours { get; set; }
        public SolidBrush Brush { get; set; } //Sets the plot color

        public Plot(int age, double hours, SolidBrush brush) 
        {
            Age = age;
            Hours = hours;
            Brush = brush;
        }
    }
}
