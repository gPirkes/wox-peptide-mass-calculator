using System.Collections.Generic;
using System.Linq;

namespace Wox.Plugin.PepMassCalculator {
    /// <summary>
    /// result data structure 
    /// </summary>
    public class MassCalculationResult {
        public double MonoisotopicMass { get; set; }
        public double AverageMass { get; set; }
        public List<char> NotRecognisedChars { get; set; }

        public MassCalculationResult() {
            NotRecognisedChars = new List<char>();
            MonoisotopicMass = 0;
            AverageMass = 0;
        }

        /// <summary>
        /// add the masses of one amino acid to the result. 
        /// </summary>
        public void AddAminoAcid(AminoAcid aminoAcid) {
            MonoisotopicMass += aminoAcid.MonoIsotopicMass;
            AverageMass += aminoAcid.AverageMass;
        }

        /// <summary>
        /// create a string that contains the chars not found in the map
        /// </summary>
        public string GetNotRecognisedCharsString() {
            if (!NotRecognisedChars.Any()) {
                return "";
            }

            return string.Join(", ", NotRecognisedChars.Distinct().OrderBy(x => x));
        }
    }
}