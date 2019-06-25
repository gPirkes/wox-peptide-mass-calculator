using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wox.Plugin.PepMassCalculator {
    class AminoAcid {
        public double MonoIsotopicMass { get; private set; }
        public double AvgMass { get; private set; }

        public AminoAcid(double monoIsotopicMass, double avgMass) {
            AvgMass = avgMass;
            MonoIsotopicMass = monoIsotopicMass;
        }
    }
}