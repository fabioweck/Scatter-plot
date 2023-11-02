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
        public List<Plot> PlotsBR;
        public List<Plot> PlotsCA;
        public List<Plot> PlotsCustom;
        public int plotWidth = 14;
        public int plotHeight = 14;
        SolidBrush BRbrush = new SolidBrush(Color.FromArgb(180, 0, 204, 0));
        SolidBrush CAbrush = new SolidBrush(Color.FromArgb(180, 204, 0, 0));
        SolidBrush borderBrush = new SolidBrush(Color.FromArgb(150, 128, 128, 128));
        SolidBrush recommendedBrush = new SolidBrush(Color.FromArgb(255, 230, 230, 230));

        public Graph()
        {
            InitializeComponent();
            G = this.CreateGraphics();
            PlotsBR = new();
            PlotsCA = new();
            PlotsCustom = new();
            PopulatePlots();
        }

        public void IncreasePlotSize(int width, int height)
        {
            plotHeight += height;
            plotWidth += width;
        }

        public void DecreasePlotSize(int width, int height)
        {
            plotHeight -= height;
            plotWidth -= width;
        }

        private void PopulatePlots()
        {

            Random rand = new Random();

            for(int i = 0; i < 90; i++)
            {
                if(i <= 10)
                {
                    int age = rand.Next(1, 10);

                    int randomInteger = rand.Next(16, 26); // Generates a random integer
                    double sleepingHours = randomInteger / 2.0; //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12.5
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randomInteger = rand.Next(16, 26);
                    sleepingHours = randomInteger / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 10 && i <= 20)
                {
                    int age = rand.Next(11, 20);

                    int randomInteger = rand.Next(14, 24); // Generates a random integer
                    double sleepingHours = randomInteger / 2.0; //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12.5
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randomInteger = rand.Next(14, 24);
                    sleepingHours = randomInteger / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 20 && i <= 30)
                {
                    int age = rand.Next(21, 30);

                    int randomInteger = rand.Next(14, 20); // Generates a random integer
                    double sleepingHours = randomInteger / 2.0; //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12.5
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randomInteger = rand.Next(14, 20);
                    sleepingHours = randomInteger / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 30 && i <= 40)
                {
                    int age = rand.Next(31, 40);

                    int randomInteger = rand.Next(10, 18); // Generates a random integer
                    double sleepingHours = randomInteger / 2.0; //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12.5
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randomInteger = rand.Next(12, 20);
                    sleepingHours = randomInteger / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 40 && i <= 50)
                {
                    int age = rand.Next(41, 50);

                    int randomInteger = rand.Next(10, 18); // Generates a random integer
                    double sleepingHours = randomInteger / 2.0; //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12.5
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randomInteger = rand.Next(12, 20);
                    sleepingHours = randomInteger / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 50 && i <= 60)
                {
                    int age = rand.Next(51, 60);

                    int randomInteger = rand.Next(10, 20); // Generates a random integer
                    double sleepingHours = randomInteger / 2.0; //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12.5
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randomInteger = rand.Next(12, 20);
                    sleepingHours = randomInteger / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 60 && i <= 70)
                {
                    int age = rand.Next(61, 70);

                    int randomInteger = rand.Next(8, 18); // Generates a random integer
                    double sleepingHours = randomInteger / 2.0; //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12.5
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randomInteger = rand.Next(10, 18);
                    sleepingHours = randomInteger / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 70 && i <= 80)
                {
                    int age = rand.Next(71, 80);

                    int randomInteger = rand.Next(8, 16); // Generates a random integer
                    double sleepingHours = randomInteger / 2.0; //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12.5
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randomInteger = rand.Next(8, 16);
                    sleepingHours = randomInteger / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 80 && i <= 90)
                {
                    int age = rand.Next(81, 90);

                    int randomInteger = rand.Next(8, 14); // Generates a random integer
                    double sleepingHours = randomInteger / 2.0; //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12.5
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randomInteger = rand.Next(10, 14);
                    sleepingHours = randomInteger / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }
            }
        }

        public void AddPlot(Plot newPlot)
        {
            PlotsCustom.Add(newPlot);
        }

        public void RemovePlot()
        {
            if (PlotsCustom.Count > 0) PlotsCustom.RemoveAt(PlotsCustom.Count - 1);
            else return;
        }

        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            int xAxis = 70; //Axis to define graph start point
            int yAxis = 550;

            StringFormat stringFormat = new StringFormat();

            Font titleFont = new Font("Verdana", 18, FontStyle.Bold);
            Point titleLocation = new Point(290, 10);
            SolidBrush titleBrush = new SolidBrush(Color.Black);

            Font labelsFont = new Font("Arial", 13);
            Point ageFontLocation = new Point(380, yAxis + 20);
            Point hoursFontLocation = new Point(5, 380);
            SolidBrush labelsBrush = new SolidBrush(Color.Gray);

            G.DrawString("Sleeping hours by age", titleFont, titleBrush, titleLocation, stringFormat);

            G.TranslateTransform(hoursFontLocation.X, hoursFontLocation.Y); // Move the origin to the desired rotation point
            G.RotateTransform(270); // Rotate the text by 90 degrees clockwise
            G.DrawString("Sleeping hours", labelsFont, labelsBrush, new Point(0, 0), stringFormat); // Draw the rotated string
            G.ResetTransform();

            G.DrawString("Age (years)", labelsFont, labelsBrush, ageFontLocation, stringFormat);

            Pen pen = new Pen(Color.Black, 2);

            Point[] lines = new Point[3];

            lines[0] = new Point(xAxis, xAxis);
            lines[1] = new Point(xAxis, yAxis);
            lines[2] = new Point(xAxis + 800, yAxis);

            G.DrawLines(pen, lines);

            Point[] recommendedHours = new Point[4];

            recommendedHours[0] = new Point(xAxis + 1, xAxis + 40);
            recommendedHours[1] = new Point(xAxis + 800, xAxis + 160);
            recommendedHours[2] = new Point(xAxis + 800, xAxis + 240);
            recommendedHours[3] = new Point(xAxis + 1, xAxis + 160);

            G.FillPolygon(recommendedBrush, recommendedHours);

            int counterAge = 0;
            
            for(int i = 0; i < 800; i += 88)
            {
                Rectangle markerAge = new Rectangle(xAxis - 1 + i, yAxis - 5, 2, 10);
                G.DrawRectangle(pen, markerAge);

                Font legendFont = new Font("Arial", 10);
                Point legendLocation = new Point(xAxis - 12 + i, yAxis + 5);
                G.DrawString(counterAge.ToString(), legendFont, labelsBrush, legendLocation, stringFormat);

                counterAge += 10;
            }

            int counterHours = 12;
            for (int i = 0; i < 480; i+= 40)
            {
                Rectangle markerHours = new Rectangle(xAxis - 5, xAxis - 1 + i, 10, 2);
                G.DrawRectangle(pen, markerHours);

                Font legendFont = new Font("Arial", 10);
                Point legendLocation = new Point(xAxis - 30, 60 + i);
                G.DrawString(counterHours.ToString(), legendFont, labelsBrush, legendLocation, stringFormat);

                counterHours -= 1;
            }

            foreach(Plot plot in PlotsBR)
            {
                
                double x = xAxis - (plotWidth/2) + (plot.Age * 8.8); //800px width divided by 90 years
                double y = yAxis - (plotHeight/2) - (plot.Hours * 40); //480px height divided by 12 hours

                G.FillEllipse(plot.Brush, (int)x, (int)y, plotWidth, plotHeight);
                G.DrawEllipse(new Pen(borderBrush, 1), (int)x, (int)y, plotWidth, plotHeight);
            }

            foreach (Plot plot in PlotsCA)
            {

                double x = xAxis - (plotWidth / 2) + (plot.Age * 8.8); //800px width divided by 90 years
                double y = yAxis - (plotHeight / 2) - (plot.Hours * 40); //480px height divided by 12 hours

                G.FillEllipse(plot.Brush, (int)x, (int)y, plotWidth, plotHeight);
                G.DrawEllipse(new Pen(borderBrush, 1), (int)x, (int)y, plotWidth, plotHeight);
            }

            if(PlotsCustom.Count > 0)
            {
                foreach (Plot plot in PlotsCustom)
                {

                    double x = xAxis - (plotWidth / 2) + (plot.Age * 8.8); //800px width divided by 90 years
                    double y = yAxis - (plotHeight / 2) - (plot.Hours * 40); //480px height divided by 12 hours

                    G.FillEllipse(plot.Brush, (int)x, (int)y, plotWidth, plotHeight);
                    G.DrawEllipse(new Pen(borderBrush, 1), (int)x, (int)y, plotWidth, plotHeight);
                }
            } 
        }
    }
}
