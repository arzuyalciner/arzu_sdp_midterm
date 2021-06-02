using design_pattern.Methodology;
using System;
using System.Collections.Generic;
using System.Text;


namespace design_pattern.MCDMProblem
{
    public abstract class Problem
    {
        public IMethodology Methodology { get; set; }
        public abstract void Ranking();



    }
}
