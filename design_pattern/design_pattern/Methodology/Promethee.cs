﻿using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern.Methodology
{
    class Promethee : IMethodology
    {
        const string METHODOLOGY_NAME = "Promethee";
        public string RankAlternatives()
        {
            //throw new NotImplementedException();
            return string.Format("Alternatives Ranked with " + METHODOLOGY_NAME);
        }
    }
}
