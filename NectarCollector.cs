using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    internal class NectarCollector :Bee
    {
        protected new float CostPerShift { get; } = 1.95f;
        public NectarCollector() : base("NectarCollectro") { }

        protected override void DoJob()
        {
            /*przesłaniana w podklasie*/
        }
    }
}
