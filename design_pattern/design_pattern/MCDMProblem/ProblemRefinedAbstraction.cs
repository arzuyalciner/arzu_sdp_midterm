using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.MCDMProblem
{
    public class ProblemRefinedAbstraction : Problem
    {
        public override void Ranking()
        {
            Console.WriteLine(Methodology.RankAlternatives());
        }
    }
}
