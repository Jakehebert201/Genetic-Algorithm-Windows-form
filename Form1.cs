namespace GeneticAlgorithms;
using AngouriMath;
using System.Drawing.Text;
using GradientDescent;
using System.Security.AccessControl;
using System.Linq.Expressions;
using static GradientDescent.GradientDescent;
using Antlr4.Runtime.Misc;
using ScottPlot;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        btnRun.Click += btnRun_Click;
        btnReset.Click += btnReset_Click;

    }
    private GeneticAlgorithm ga;
    private int populationSize;
    private double MutationRate;
    private bool minimize;
    private int generations;
    private double minRange;
    private double maxRange;
    private GradientDescent.OptimizationFunction func;
    private string functionText;
    private int printInterval => Math.Max(1,generations / 10); //Interval to generate table and plot across the generations
    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        tabControl1.TabPages.Clear();
        //Vals from UI
        populationSize = int.Parse(numPopSize.Text);
        MutationRate = double.Parse(numMutationRate.Text);
        minimize = chkMinimize.Checked;
        generations = int.Parse(numGenerations.Text);
        minRange = double.Parse(numMinRange.Text);
        maxRange = double.Parse(numMaxRange.Text);

        //Settings summary label
        LabelSettingsSummary.Visible = true;
        LabelSettingsSummary.Text = $"Population Size: {populationSize}\nMutation Rate: {MutationRate}\nMinimized? {minimize}";

        //Function input
        func = GetUserDefinedFunction();
        if (func == null) { return; }

        //create ga object and evolve
        ga = new GeneticAlgorithm(populationSize, MutationRate, func, minimize, minRange, maxRange);
        for (int i = 0; i < generations; i++)
        {
            ga.Evolve();
            //Take a snapshot based on interval
            if (i % printInterval == 0 || i == generations-1)
            {
                double[] Population = ga.GetPopulation();
                int labelgen = (i == generations - 1) ? generations : i;
                SaveSnapshot(labelgen, Population);

            }
            }

    }

        
    private void btnReset_Click(object sender, EventArgs e)
    {
        //Reread UI values
        populationSize = int.Parse(numPopSize.Text);
        MutationRate = double.Parse(numMutationRate.Text);
        minimize = chkMinimize.Checked;
        minRange = double.Parse(numMinRange.Text);
        maxRange = double.Parse(numMaxRange.Text);

        //Recompile function
        func = GetUserDefinedFunction();


        //Reset Ga
        ga = new(populationSize, MutationRate, func, minimize, minRange, maxRange);


    }
    public OptimizationFunction GetUserDefinedFunction()
    {
        try
        {
            Entity expr = MathS.FromString(userInputFunc.Text);
            var compiled = expr.Compile("x");
            functionText= userInputFunc.Text;
            return x => (double)compiled.Call(x).Real;

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Invalid function: {ex.Message}");
            return null; // or throw if you want stricter control
        }
    }
    private void Drawplot(ScottPlot.WinForms.FormsPlot plot, double[] pop)
    {
        //Plot
        double[] ys = pop.Select(x => func(x)).ToArray();
        //Sort values
        var sorted = pop.Zip(ys, (x, y) => new { x, y }).OrderBy(Pair => Pair.x).ToArray();

        double[] sortedXs = sorted.Select(p => p.x).ToArray();
        double[] sortedYs = sorted.Select(p => p.y).ToArray();

        plot.Plot.Clear();
        plot.Plot.Add.Scatter(sortedXs, sortedYs);
        plot.Plot.Title($"Population after {generations}");
        plot.Plot.XLabel("x");
        plot.Plot.YLabel($"f(x) = {functionText}");
        plot.Refresh();
    }
    private void DrawTable(DataGridView grid, double[] pop)
    {
        grid.Columns.Clear();
        grid.Rows.Clear();

        grid.Columns.Add("X", "Individual");
        grid.Columns.Add("Y", "Fitness");

        //populate table
        foreach (var individual in pop)
        {
            grid.Rows.Add(individual.ToString("F4"), func(individual).ToString("F4"));
        }
        
    }
    private void SaveSnapshot(int generation, double[] population)
    {
        var tabPage = new TabPage($"Gen {generation:N0}");
        var grid = new DataGridView() { Dock = DockStyle.Top, Height = 200 };
        var formsPlot = new ScottPlot.WinForms.FormsPlot() { Dock = DockStyle.Fill};

        

        DrawTable(grid, population);
        Drawplot(formsPlot, population);

        tabPage.Controls.Add(grid);
        tabPage.Controls.Add(formsPlot);
        tabControl1.TabPages.Add(tabPage);
        tabControl1.Visible = true;
        
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void userInputFunc_TextChanged(object sender, EventArgs e)
    {

    }

    private void chkMinimize_CheckedChanged(object sender, EventArgs e)
    {

    }
}
