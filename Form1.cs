namespace ScatterGraph
{
    public partial class Form1 : Form
    {
        Graph graph = new Graph();

        public Form1()
        {
            InitializeComponent();

            
            pnlGraph.Controls.Add(graph);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph.AddPlot(1, 1);
            graph.AddPlot(1, 2);
            graph.AddPlot(1, 3);
            graph.AddPlot(1, 4);
            graph.AddPlot(1, 5);
            graph.AddPlot(1, 6);
            graph.AddPlot(1, 7);
            graph.AddPlot(1, 8);
            graph.AddPlot(1, 9);
            graph.AddPlot(1, 10);
            graph.AddPlot(1, 11);
            graph.AddPlot(1, 12);
            graph.Refresh();
        }
    }
}