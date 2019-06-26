using System.Collections.Generic;
using System.Linq;

namespace Wox.Plugin.PepMassCalculator {
    public class MassCalculationResult {
        public double MonoisotopicMass { get; set; }
        public double AverageMass { get; set; }
        public List<char> NotRecognisedChars { get; set; }

        public MassCalculationResult() {
            NotRecognisedChars  = new List<char>();
            MonoisotopicMass = 0;
            AverageMass = 0;
        }

        public void AddAminoAcid(AminoAcid aminoAcid) {
            MonoisotopicMass += aminoAcid.MonoIsotopicMass;
            AverageMass += aminoAcid.AverageMass;
        }

        public string GetNotRecognisedCharsString() {
            if (!NotRecognisedChars.Any()) {
                return "";
            }

            return string.Join(", ", NotRecognisedChars.Distinct().OrderBy(x => x));
        }
    }
}