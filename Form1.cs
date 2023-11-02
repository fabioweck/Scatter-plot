namespace ScatterGraph
{
    public partial class Form1 : Form
    {
        public Graph graph = new Graph();
        public Plot MyPlot;

        public Form1()
        {
            InitializeComponent();
            pnlGraph.Controls.Add(graph);
        }

        private void ChangePlotSize(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "btnIncreaseSize":
                    graph.IncreasePlotSize(2, 2);
                    graph.Refresh();
                    break;
                case "btnDecreaseSize":
                    graph.DecreasePlotSize(2, 2);
                    graph.Refresh();
                    break;
            }
        }

        private void btnCustomPlot(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SolidBrush brush = new SolidBrush(Color.Blue);

            if (button.Name == "btnAddPlot")
            {
                int age = (int)numAgeSelected.Value;
                double hours = (double)numHoursSelected.Value;
                MyPlot = new(age, hours, brush);
                graph.AddPlot(MyPlot);
                graph.Refresh();
            }
            else if (button.Name == "btnRemovePlot")
            {
                graph.RemovePlot();
                graph.Refresh();
            }
        }
    }
}