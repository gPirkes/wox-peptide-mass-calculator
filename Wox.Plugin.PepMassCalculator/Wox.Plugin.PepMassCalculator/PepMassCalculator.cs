using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wox.Plugin.PepMassCalculator {
    public class PepMassCalculator : IPlugin {
        private static Dictionary<char, AminoAcid> AminoAcids = new Dictionary<char, AminoAcid> {
            {'A', new AminoAcid(71.037114, 71.0779)}, //71.03712
            {'R', new AminoAcid(156.101111, 156.1857)}, //156.10112
            {'N', new AminoAcid(114.042927, 114.1026)}, //114.04293
            {'D', new AminoAcid(115.026943, 115.0874)}, //115.02695
            {'C', new AminoAcid(103.009185, 103.1429)}, //103.00919
            {'E', new AminoAcid(129.042593, 129.114)}, //129.0426
            {'Q', new AminoAcid(128.058578, 128.1292)}, //128.05858
            {'G', new AminoAcid(57.021464, 57.0513)}, //57.02147
            {'H', new AminoAcid(137.058912, 137.1393)}, //137.05891
            {'I', new AminoAcid(113.084064, 113.1576)}, //113.08407
            {'L', new AminoAcid(113.084064, 113.1576)},
            {'K', new AminoAcid(128.094963, 128.1723)}, //128.09497
            {'M', new AminoAcid(131.040485, 131.1961)}, //131.0405
            {'F', new AminoAcid(147.068414, 147.1739)}, //147.06842
            {'P', new AminoAcid(97.052764, 97.1152)}, //97.05277
            {'S', new AminoAcid(87.032028, 87.0773)}, //87.03203
            {'T', new AminoAcid(101.047679, 101.1039)}, //101.04768
            {'U', new AminoAcid(150.95363, 150.0379)},
            {'W', new AminoAcid(186.079313, 186.2099)}, //186.07932
            {'Y', new AminoAcid(163.06332, 163.1733)}, //163.06332
            {'V', new AminoAcid(99.068414, 99.1311)}, //99.06842
            {'J', new AminoAcid(113.084064, 113.1576)},
            {'O', new AminoAcid(237.14772677, 237.300713363271)},
        };


        public List<Result> Query(Query query) {
            return new List<Result> {new Result("Test", "no", "test")};
//            throw new NotImplementedException();
        }

        public void Init(PluginInitContext context) {
//            throw new NotImplementedException();
        }
    }
}