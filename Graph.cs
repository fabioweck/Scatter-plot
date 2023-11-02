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
        public List<Plot> PlotsBR; //Lists to collect plots separated by countries
        public List<Plot> PlotsCA;
        public List<Plot> PlotsCustom;
        public List<List<Plot>> AllPlots;

        public int plotSize = 14; //Defines the initial size of the plot

        public SolidBrush BRbrush = new SolidBrush(Color.FromArgb(150, 0, 204, 0));                //Defines a color for each element displayed on the chart
        SolidBrush CAbrush = new SolidBrush(Color.FromArgb(150, 204, 0, 0));
        SolidBrush userBrush = new SolidBrush(Color.Blue);
        SolidBrush borderBrush = new SolidBrush(Color.FromArgb(150, 128, 128, 128));        //Used for drawing a thin border around the plots
        SolidBrush recommendedBrush = new SolidBrush(Color.FromArgb(180, 230, 230, 230));   //Used for drawing a the recommended sleeping hours stripe

        public Graph()
        {
            InitializeComponent();
            G = this.CreateGraphics();  //Initializes graphics
            PlotsBR = new();
            PlotsCA = new();
            PlotsCustom = new();
            AllPlots = new();
            PopulatePlots();            //Calls the method to generate random data to populate the chart
        }

        public void IncreasePlotSize(int increment)
        {
            plotSize += increment; //Increases the size of the plot
        }

        public void DecreasePlotSize(int increment)
        {
            plotSize -= increment; //Reduces the size of the plot
        }

        public void PopulatePlots()
        {

            if(PlotsBR.Count > 0 || PlotsCA.Count > 0 || PlotsCustom.Count > 0) //Checks if lists are not empty, if yes, then clear lists
            {
                PlotsBR.Clear();
                PlotsCA.Clear();
                PlotsCustom.Clear();
                AllPlots.Clear();
            }

            Random rand = new Random(); //Random instantiated to be used by loop

            for(int i = 0; i < 90; i++)
            {
                if(i <= 10)  //Conditional to create data for children up to 10 years
                {
                    int age = rand.Next(1, 10);

                    int randInt = rand.Next(16, 25);              //Generates a random integer
                    double sleepingHours = randInt / 2.0;         //Divides by two to get random numbers from  8, 8.5, 9, 9.5... to 12
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush)); //Adds plot to Brazilian collection

                    randInt = rand.Next(16, 25);
                    sleepingHours = randInt / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush)); //Adds plot to Canadian collection
                }

                else if (i > 10 && i <= 20) //Conditional to create data for teenagers up to 20 years
                {
                    int age = rand.Next(11, 20);

                    int randInt = rand.Next(14, 24);              
                    double sleepingHours = randInt / 2;           
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randInt = rand.Next(14, 24);
                    sleepingHours = randInt / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 20 && i <= 30) //Conditional to create data for adults up to 30 years
                {
                    int age = rand.Next(21, 30);

                    int randInt = rand.Next(12, 20);              
                    double sleepingHours = randInt / 2.0;         
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randInt = rand.Next(14, 20);
                    sleepingHours = randInt / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 30 && i <= 40) //Conditional to create data for adults up to 40 years
                {
                    int age = rand.Next(31, 40);

                    int randInt = rand.Next(10, 18); 
                    double sleepingHours = randInt / 2.0; 
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randInt = rand.Next(12, 20);
                    sleepingHours = randInt / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 40 && i <= 50) //Conditional to create data for adults up to 50 years
                {
                    int age = rand.Next(41, 50);

                    int randInt = rand.Next(10, 18); 
                    double sleepingHours = randInt / 2.0; 
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randInt = rand.Next(12, 20);
                    sleepingHours = randInt / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 50 && i <= 60)
                {
                    int age = rand.Next(51, 60);

                    int randInt = rand.Next(10, 20); 
                    double sleepingHours = randInt / 2.0;
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randInt = rand.Next(12, 20);
                    sleepingHours = randInt / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 60 && i <= 70) //Conditional to create data for adults up to 70 years
                {
                    int age = rand.Next(61, 70);

                    int randInt = rand.Next(8, 18); 
                    double sleepingHours = randInt / 2.0; 
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randInt = rand.Next(10, 18);
                    sleepingHours = randInt / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 70 && i <= 80) //Conditional to create data for adults up to 80 years
                {
                    int age = rand.Next(71, 80);

                    int randInt = rand.Next(8, 16); 
                    double sleepingHours = randInt / 2.0; 
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randInt = rand.Next(8, 16);
                    sleepingHours = randInt / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }

                else if (i > 80 && i <= 90) //Conditional to create data for adults up to 90 years
                {
                    int age = rand.Next(81, 90);

                    int randInt = rand.Next(8, 14); 
                    double sleepingHours = randInt / 2.0; 
                    PlotsBR.Add(new Plot(age, sleepingHours, BRbrush));

                    randInt = rand.Next(10, 14);
                    sleepingHours = randInt / 2.0;
                    PlotsCA.Add(new Plot(age, sleepingHours, CAbrush));
                }
            }

            //Adds all lists to the collection of plot lists
            AllPlots.Add(PlotsBR); 
            AllPlots.Add(PlotsCA);
            AllPlots.Add(PlotsCustom);

        }

        //Adds new plot to the user plots
        public void AddPlot(Plot newPlot)
        {
            PlotsCustom.Add(newPlot);
        }

        //Removes the last plot added by user
        public void RemovePlot()
        {
            if (PlotsCustom.Count > 0) PlotsCustom.RemoveAt(PlotsCustom.Count - 1);
            else return; //If the list is empty, returns to avoid crash
        }


        //Main method - Renders the graph and its elements on screen
        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            //Axes to define graph limits (numbers in pixels)
            int xAxis = 70; 
            int yAxis = 550;
            int width = 800;

            StringFormat stringFormat = new StringFormat();

            //Title properties
            Font titleFont = new Font("Arial", 18, FontStyle.Underline);
            Point titleLocation = new Point(290, 10);
            SolidBrush titleBrush = new SolidBrush(Color.Black);

            //Labels properties
            Font labelsFont = new Font("Arial", 13);
            Point ageFontLocation = new Point(380, yAxis + 20);
            Point hoursFontLocation = new Point(5, 380);
            SolidBrush labelsBrush = new SolidBrush(Color.Gray);

            //Overlap legend
            Font overlapFont = new Font("Arial", 9);
            Point overlapLocation = new Point(400, yAxis - 70);
            SolidBrush overlapBrush = new SolidBrush(Color.LightSlateGray);
            G.DrawString("(Darker and brighter plots are plots overlapped)", overlapFont, overlapBrush, overlapLocation, stringFormat);

            //Draws regular texts
            G.DrawString("Sleeping hours by age", titleFont, titleBrush, titleLocation, stringFormat);  //Main title
            G.DrawString("Age (years)", labelsFont, labelsBrush, ageFontLocation, stringFormat);        //Label at the bottom 

            //Draws side label in a vertical position. Methods rotate the label.
            G.TranslateTransform(hoursFontLocation.X, hoursFontLocation.Y);         // Move the origin to the desired rotation point
            G.RotateTransform(270);                                                 // Rotate the label
            G.DrawString("Sleeping hours", labelsFont, labelsBrush, new Point(0, 0), stringFormat); 
            G.ResetTransform();     //Resets the transform to be used again without issues

            //Pen to draw rulers
            Pen pen = new Pen(Color.Black, 2);

            //Draws the vertical ruler related to hours and the horizontal ruler related to age
            Point[] lines = new Point[3];

            lines[0] = new Point(xAxis, xAxis);
            lines[1] = new Point(xAxis, yAxis);         //Vertical ruler
            lines[2] = new Point(xAxis + width, yAxis); //Horizontal ruler

            G.DrawLines(pen, lines);

            //Draws the stripe/range of recommended sleeping hours
            Point[] recommendedHours = new Point[4];

            recommendedHours[0] = new Point(xAxis + 1, xAxis + 40);
            recommendedHours[1] = new Point(xAxis + width, xAxis + 160);
            recommendedHours[2] = new Point(xAxis + width, xAxis + 240);
            recommendedHours[3] = new Point(xAxis + 1, xAxis + 160);

            G.FillPolygon(recommendedBrush, recommendedHours);

            //The sequence below draws legend for the plots

            //Brazilian data plots legend
            Point[] brLegend = new Point[4];

            brLegend[0] = new Point(130, 450);
            brLegend[1] = new Point(230, 450);
            brLegend[2] = new Point(230, 470);
            brLegend[3] = new Point(130, 470);

            G.FillPolygon(BRbrush, brLegend);
            G.DrawString("Brazil", labelsFont, labelsBrush, new Point(235, 448), stringFormat);

            //Canadian data plots legend
            Point[] caLegend = new Point[4];

            caLegend[0] = new Point(130, 480);
            caLegend[1] = new Point(230, 480);
            caLegend[2] = new Point(230, 500);
            caLegend[3] = new Point(130, 500);

            G.FillPolygon(CAbrush, caLegend);   //Uses CAbrush for canadian data label
            G.DrawString("Canada", labelsFont, labelsBrush, new Point(235, 478), stringFormat);


            //User data plots legend
            Point[] userLegend = new Point[4];

            userLegend[0] = new Point(130, 510);
            userLegend[1] = new Point(230, 510);
            userLegend[2] = new Point(230, 530);
            userLegend[3] = new Point(130, 530);

            G.FillPolygon(userBrush, userLegend); //Uses BRbrush for user data label
            G.DrawString("User", labelsFont, labelsBrush, new Point(235, 508), stringFormat);       

            //Recommended sleeping hours stripe legend
            Point[] recommendedLegend = new Point[4];

            recommendedLegend[0] = new Point(400, 510);
            recommendedLegend[1] = new Point(500, 510);
            recommendedLegend[2] = new Point(500, 530);
            recommendedLegend[3] = new Point(400, 530);

            G.FillPolygon(recommendedBrush, recommendedLegend); //Uses recommendedBrush for recommended sleeping hours label
            G.DrawString("Recommended sleeping hours", labelsFont, labelsBrush, new Point(505, 508), stringFormat);


            //The following loops draw a thin marker on the rulers to get a more precise and fast reading from the graph

            int counterAge = 0; //Counts the marker to draw correct number
            
            for(int i = 0; i < width; i += 88) //Width is the max size from start point to the final on X axis. 88 represents 800 pixels/9 markers
            {
                Rectangle markerAge = new Rectangle(xAxis - 1 + i, yAxis - 5, 2, 10);
                G.DrawRectangle(pen, markerAge);    //Draws the marker

                Font legendFont = new Font("Arial", 10);
                Point legendLocation = new Point(xAxis - 12 + i, yAxis + 5);
                G.DrawString(counterAge.ToString(), legendFont, labelsBrush, legendLocation, stringFormat); //Places numbers below markers

                counterAge += 10;   //Adds 10 to display correct years number to each marker
            }

            int counterHours = 12;  //Starts from 12 to draw numbers from top to bottom

            for (int i = 0; i < yAxis - xAxis; i+= 40)  //Conditional is 'i < height'. 40 represents 480 pixels/12 markers
            {
                Rectangle markerHours = new Rectangle(xAxis - 5, xAxis - 1 + i, 10, 2);
                G.DrawRectangle(pen, markerHours);  //Draws the marker

                Font legendFont = new Font("Arial", 10);
                Point legendLocation = new Point(xAxis - 30, 60 + i);
                G.DrawString(counterHours.ToString(), legendFont, labelsBrush, legendLocation, stringFormat); //Places numbers beside the markers

                counterHours -= 1;
            }


            //Finally, three loops iterates over each collection of data

            foreach(List<Plot> list in AllPlots)
            {
                foreach (Plot plot in list)
                {

                    double x = xAxis - (plotSize / 2) + (plot.Age * 8.8);   //800px | width divided by 90 years
                    double y = yAxis - (plotSize / 2) - (plot.Hours * 40);  //480px | height divided by 12 hours

                    G.FillEllipse(plot.Brush, (int)x, (int)y, plotSize, plotSize);              //Numbers must be cast to integers
                    G.DrawEllipse(new Pen(borderBrush, 2), (int)x, (int)y, plotSize, plotSize); //Draws a thin border around the plot
                }
            }
        }
    }
}
