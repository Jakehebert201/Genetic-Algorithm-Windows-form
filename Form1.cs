namespace GeneticAlgorithms;

using System.Drawing.Text;
using GradientDescent;
public partial class Form1 : Form
{
    public Form1(){}

           
    private void btnRun_Click(object sender, EventArgs e){
        //Vals from UI
        int populationSize = int.Parse(txtPopulationSize.Text);
        double MutationRate = double.Parse(txtMutationRate.Text);
        bool minimize = chkMinimize.Checked;

        GradientDescent.OptimizationFunction func = x => (Math.Sin(x)) + 0.1*x;

        GeneticAlgorithm ga = new GeneticAlgorithm(populationSize, MutationRate,func,minimize);
        for(int i = 0; i < 1000; i++){
            ga.Evolve();
        }
    }
}
