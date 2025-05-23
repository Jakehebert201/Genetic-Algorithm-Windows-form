namespace GradientDescent
{
    using System;

    public class GradientDescent
    {
        public delegate double OptimizationFunction(double x);
        static Random randall = new Random();

        /// <summary>
        /// Definition for the function to optimize: sin(x) + 0.1x
        /// </summary>
        //static OptimizationFunction func = x => (System.Math.Sin(x)) + (0.1 * x);

        // Descent system  
        public static double Optimize(OptimizationFunction func, bool minimize)
        {
            double currentX = randall.NextDouble() * 10.0;
            double learningRate = 0.01;
            int maxIterations = 1000;

            for (int i = 0; i < maxIterations; i++)
            {
                double dydx = Derivative.CalculateDerivative(func, currentX);
                currentX += (minimize ? -1 : 1) * learningRate * dydx;
            }

            return currentX;
        }
    }
}
