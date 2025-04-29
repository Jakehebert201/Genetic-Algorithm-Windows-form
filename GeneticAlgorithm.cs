public class GeneticAlgorithm
{



    private int populationSize;
    private double[] population;
    private double mutationRate;
    private Random randall = new Random();
    private bool minimize;
    private GradientDescent.GradientDescent.OptimizationFunction fitnessFunction;
    private double minRange { get; set; }
    private double maxRange { get; set; }
    private double range => maxRange - minRange;
    private int evolveCount { get; set; }
    public int _evolveCount { get; set; }

    public GeneticAlgorithm(int populationSize, double mutationRate, GradientDescent.GradientDescent.OptimizationFunction fitnessFunction, bool minimize, double MinRange, double MaxRange)
    {
        this.populationSize = populationSize;
        this.mutationRate = mutationRate;
        this.fitnessFunction = fitnessFunction;
        this.minimize = minimize;
        this.minRange = MinRange;
        this.maxRange = MaxRange;
        InitializePopulation();
    }
    private void InitializePopulation()
    {
        population = new double[populationSize];
        for (int i = 0; i < populationSize; i++)
        {
            population[i] = randall.NextDouble() * (maxRange - minRange) + minRange;
        }
    }

    public void Evolve()
    {
        //fitness function, a higher value = better candidate
        double[] fitness = CalculateFitness(population, fitnessFunction);
        double fitnessThreshold = fitness.Average() * 0.9;
        //Elite selection
        int eliteCount = Math.Max(1, (int)(populationSize * 0.05));
        var eliteRaw = minimize
            ? population.Zip(fitness, (val, fit) => new { val, fit }).OrderBy(x => x.fit).Where(x => x.fit < fitnessThreshold)
            : population.Zip(fitness, (val, fit) => new { val, fit }).OrderByDescending(x => x.fit).Where(x => x.fit < fitnessThreshold);

        var elite = eliteRaw.Take(eliteCount).Select(x => x.val).ToList();


        //Selection

        int selectedCount = (int)Math.Ceiling((populationSize - eliteCount) / 2.0);
        int tournamentSize = Math.Min(10, / 10000);
        List<double> selectedParents = new();
        for (int i = 0; i < selectedCount; i++)
        {

            double parent = TournamentSelection(population, fitness, tournamentSize);
            selectedParents.Add(parent);
        }
        //Crossover

        double[] newPopulation = Crossover(selectedParents);
        //Mutation and Replacement

        newPopulation = Mutation(newPopulation, mutationRate);
        Array.Copy(elite.ToArray(), 0, newPopulation, 0, elite.Count);
    }

    /// <summary>
    /// I've probably had to change this one function 100 times at this point. It now normalizes the values and determines fitness based on the best value.
    /// </summary>
    /// <param name="population"></param>
    /// <param name="fitnessFunction"></param>
    /// <returns></returns>
    private double[] CalculateFitness(double[] population, GradientDescent.GradientDescent.OptimizationFunction fitnessFunction)
    {
        double[] fitness = new double[population.Length];
        for (int i = 0; i < population.Length; i++)
        {
            double raw = fitnessFunction(population[i]);
            fitness[i] = minimize ? 1.0 / (1.0 + Math.Abs(raw)) : raw;
        }
        return fitness;
    }
    /// <summary>
    /// Depricated
    /// </summary>
    /// <param name="population"></param>
    /// <param name="fitnesses"></param>
    /// <returns></returns>
    private double RouletteSelection(double[] population, double[] fitnesses)
    {
        double totalFitness = 0.0;
        foreach (var fitness in fitnesses)
            totalFitness += fitness;

        double r = randall.NextDouble() * totalFitness;
        double cumulative = 0.0;

        for (int i = 0; i < population.Length; i++)
        {
            cumulative += fitnesses[i];
            if (r <= cumulative)
                return population[i];
        }

        return population[population.Length - 1]; // fallback
    }

    private double TournamentSelection(double[] population, double[] fitness, int tournamentSize)
    {
        double bestIndividual = 0;
        double bestFitness = minimize ? double.MaxValue : double.MinValue;
        for (int i = 0; i < tournamentSize; i++)
        {
            int randomIndex = randall.Next(0, population.Length);
            double candidateFitness = fitness[randomIndex];
            if (minimize)
            {
                if (candidateFitness < bestFitness)
                {
                    bestFitness = candidateFitness;
                    bestIndividual = population[randomIndex];
                }
            }
            else
            {
                if (candidateFitness > bestFitness)
                {
                    bestIndividual = population[randomIndex];
                    bestFitness = candidateFitness;
                }
            }
        }
        return bestIndividual;
    }

    //Combine 2 parent values into a new child value
    //either average crossover, or random weighted crossover (child = (1-a) * p[1] + a x p[2])
    private double[] Crossover(List<double> parents)
    {
        List<double> newPopulation = new();

        var shuffled = parents.OrderBy(x => randall.Next()).ToList();
        for (int i = 0; i < parents.Count; i += 2)
        {

            double parent1 = shuffled[i];
            double parent2 = shuffled[(i + 1) % parents.Count]; //Wrapping in case of out of odd
            for (int j = 0; j < 2; j++)
            {
                double alpha = randall.NextDouble();
                double child = ((1 - alpha) * parent1) + alpha * parent2;
                newPopulation.Add(child);
            }
        }
        return newPopulation.ToArray();
    }
    private double[] Mutation(double[] population, double mutationRate)
    {

        for (int i = 0; i < population.Length; i++)
        {
            if (randall.NextDouble() < mutationRate)
            {
                double epsilon = (randall.NextDouble() * 1.0) - 0.5; //Should now be a random value between -0.5 and 0.5
                population[i] += epsilon;
                population[i] = Math.Max(minRange, Math.Min(maxRange, population[i]));
            }
        }
        return population;
    }
    public override string ToString()
    {
        string popvalues = string.Join(",", population);
        return $"GENETIC ALGORITHM:\nMinimized?:{minimize}\nMutation Rate: {mutationRate}\nPopulation Size: {populationSize}\nPopulation: {popvalues}";
    }

    public double[] GetPopulation()
    {
        return this.population;
    }
    public void ResetPopulation()
    {
        InitializePopulation();
    }

}
