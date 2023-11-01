using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScatterGraph
{
    public partial class Graph : UserControl
    {
        public Graphics G;
        public List<Plot> Plots;

        public Graph()
        {
            InitializeComponent();
            G = this.CreateGraphics();
            Plots = new();
            PopulatePlots();
        }

        private void PopulatePlots()
        {
            Plots.Add(new Plot(35, 7));
            Plots.Add(new Plot(37, 7.5));
            Plots.Add(new Plot(22, 8.5));
            Plots.Add(new Plot(31, 8));
        }

        public void AddPlot(int age, int hours)
        {
            Plots.Add(new Plot(age, hours));
        }

        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            int xAxis = 70; //Axis to define graph start point
            int yAxis = 540;

            StringFormat stringFormat = new StringFormat();
            Font font = new Font("Arial", 13);

            Point titleLocation = new Point(350, 10);
            Point ageFontLocation = new Point(370, yAxis + 30);
            Point hoursFontLocation = new Point(5, 380);

            SolidBrush fontBrush = new SolidBrush(Color.DarkGray);

            G.TranslateTransform(hoursFontLocation.X, hoursFontLocation.Y); // Move the origin to the desired rotation point
            G.RotateTransform(270); // Rotate the text by 90 degrees clockwise

            G.DrawString("Sleeping hours", font, fontBrush, new Point(0, 0), stringFormat); // Draw the rotated string
            G.ResetTransform();

            G.DrawString("Sleeping hours by age", font, fontBrush, titleLocation, stringFormat);
            G.DrawString("Age (years)", font, fontBrush, ageFontLocation, stringFormat);

            Pen pen = new Pen(Color.Black, 2);

            Point[] points = new Point[3];

            points[0] = new Point(xAxis, xAxis);
            points[1] = new Point(xAxis, yAxis);
            points[2] = new Point(xAxis + 800, yAxis);

            G.DrawLines(pen, points);

            int counterAge = 0;
            
            for(int i = 0; i < 800; i += 88)
            {
                Rectangle markerAge = new Rectangle(xAxis - 1 + i, yAxis - 5, 2, 10);
                G.DrawRectangle(pen, markerAge);

                Font legendFont = new Font("Arial", 10);
                Point legendLocation = new Point(xAxis - 10 + i, yAxis + 10);
                G.DrawString(counterAge.ToString(), legendFont, fontBrush, legendLocation, stringFormat);

                counterAge += 10;
            }

            int counterHours = 12;
            for (int i = 0; i < 480; i+= 40)
            {
                Rectangle markerHours = new Rectangle(xAxis - 5, xAxis - 1 + i, 10, 2);
                G.DrawRectangle(pen, markerHours);

                Font legendFont = new Font("Arial", 10);
                Point legendLocation = new Point(xAxis - 25, 40 + i);
                G.DrawString(counterHours.ToString(), legendFont, fontBrush, legendLocation, stringFormat);

                counterHours -= 1;
            }

            foreach(Plot plot in Plots)
            {
                double x = xAxis + (plot.Age * 9.5);
                double y = yAxis - (plot.Hours * 20) * 2;
                int width = 10;
                int height = 10;

                SolidBrush brush = new SolidBrush(Color.Cyan);
                SolidBrush borderBrush = new SolidBrush(Color.DarkGray);

                G.FillEllipse(brush, (int)x, (int)y + 4, width, height);
                G.DrawEllipse(new Pen(borderBrush, 2), (int)x, (int)y + 4, width, height);
            }
        }
    }
}
