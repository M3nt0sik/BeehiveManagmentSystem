using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    internal class NectarCollector :Bee
    {
        protected override float CostPerShift { get; } = 1.95f;
        public const float NECTAR_COLECTED_PER_SHIFT = 32.25f;

        public NectarCollector() : base("NectarCollectro") { }

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLECTED_PER_SHIFT);
        }
    }
}
