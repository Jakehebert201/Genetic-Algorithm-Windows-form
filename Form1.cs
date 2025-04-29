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
        btnRun.Click += btnRun_Click_1;

    }
    private GeneticAlgorithm ga;


    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnRun_Click_1(object sender, EventArgs e)
    {
        //Vals from UI
        int populationSize = int.Parse(numPopSize.Text);
        double MutationRate = double.Parse(numMutationRate.Text);
        bool minimize = chkMinimize.Checked;
        LabelSettingsSummary.Visible = true;
        LabelSettingsSummary.Text = $"Population Size: {populationSize}\nMutation Rate: {MutationRate}\nMinimized? {minimize}";
        GradientDescent.OptimizationFunction func;

        func = GetUserDefinedFunction();
        if (func == null) { return; }
        ga = new GeneticAlgorithm(populationSize, MutationRate, func, minimize);
        for (int i = 0; i < 1000; i++)
        {
            ga.Evolve();
        }
        foreach (var individual in ga.GetPopulation())
        {
            dataGridView1.Rows.Add(individual.ToString("F4"));
        }
        dataGridView1.Visible = true;
    }
    private void btnReset_Click(object sender, EventArgs e)
    {
        //Reset values to default
        ga.ResetPopulation();
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


}
