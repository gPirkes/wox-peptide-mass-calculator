using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wox.Plugin.PepMassCalculator {
    public class AminoAcid {

        public double MonoIsotopicMass { get; private set; }
        public double AverageMass { get; private set; }

        public AminoAcid(double monoIsotopicMass, double averageMass) {
            AverageMass = averageMass;
            MonoIsotopicMass = monoIsotopicMass;
        }
    }
}