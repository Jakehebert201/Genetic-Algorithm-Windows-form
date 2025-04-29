namespace GeneticAlgorithms;
using AngouriMath;
using System.Drawing.Text;
using GradientDescent;
using System.Security.AccessControl;
using System.Linq.Expressions;
using static GradientDescent.GradientDescent;

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
        //populate table
        foreach (var individual in ga.GetPopulation())
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
