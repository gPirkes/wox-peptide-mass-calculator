namespace Wox.Plugin.PepMassCalculator {
    /// <summary>
    /// data structure for the map
    /// </summary>
    public class AminoAcid {

        public double MonoIsotopicMass { get; private set; }
        public double AverageMass { get; private set; }

        public AminoAcid(double monoIsotopicMass, double averageMass) {
            AverageMass = averageMass;
            MonoIsotopicMass = monoIsotopicMass;
        }
    }
}