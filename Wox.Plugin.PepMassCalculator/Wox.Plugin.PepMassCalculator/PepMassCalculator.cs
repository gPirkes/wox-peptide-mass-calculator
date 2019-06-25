using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wox.Plugin.PepMassCalculator
{
    public class PepMassCalculator : IPlugin
    {
        public List<Result> Query(Query query) {
            return new List<Result>{new Result("Test", "no", "test")};
            throw new NotImplementedException();
        }

        public void Init(PluginInitContext context) {
            throw new NotImplementedException();
        }
    }
}
