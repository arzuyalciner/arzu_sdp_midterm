using System;
using design_pattern.MCDMProblem;
using design_pattern.Methodology;

namespace design_pattern
{
    class Program 
    {
        static void Main(string[] args)
        {
            IMethodology promethee = new Promethee();
            IMethodology electre = new Electre();
            Problem problem = new ProblemRefinedAbstraction();

            Console.WriteLine("I will choose Promethee and raank alternatives with it");
            problem.Methodology = promethee;
            problem.Ranking();

            Console.WriteLine("I will choose Electre and rank alternatives with it");
            problem.Methodology = electre;
            problem.Ranking();

            Console.ReadLine();

        }
    }
}
