namespace GeneticAlgorithms;
using AngouriMath;
using System.Drawing.Text;
using GradientDescent;
using System.Security.AccessControl;
using System.Linq.Expressions;
using static GradientDescent.GradientDescent;
using Antlr4.Runtime.Misc;

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
    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnRun_Click(object sender, EventArgs e)
    {
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
        }
        double[] Population = ga.GetPopulation();
        //Plot
        double[] xs = Population;
        double[] ys = xs.Select(x => func(x)).ToArray();
            //Sort values
        var sorted = xs.Zip(ys, (x, y) => new { x, y }).OrderBy(Pair => Pair.x).ToArray();

        double[] sortedXs = sorted.Select(p => p.x).ToArray();
        double[] sortedYs = sorted.Select(p => p.y).ToArray();
        formsPlot1.Plot.Clear();
        formsPlot1.Plot.Add.Scatter(sortedXs, sortedYs);
        formsPlot1.Plot.Title($"Final Population after {generations}");
        formsPlot1.Plot.XLabel("x");
        formsPlot1.Plot.YLabel($"f(x) = {functionText}");
        formsPlot1.Refresh();


        //populate table
        foreach (var individual in Population)
        {
            double fx = func(individual);
            dataGridView1.Rows.Add(individual.ToString("F4"), fx.ToString("F4"));
        }
        dataGridView1.Visible = true;
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

        //Clear table
        dataGridView1.Visible = false;
        dataGridView1.Rows.Clear();

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
