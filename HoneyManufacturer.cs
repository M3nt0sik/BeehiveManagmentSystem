using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    internal class HoneyManufacturer : Bee
    {
        public const float NECTAR_PROCES_PER_SHIFT = 32.15f;
        protected override float CostPerShift { get; } = 1.7f;
        public HoneyManufacturer() : base("HoneyManufacturer") { }
        protected override void DoJob()
        {
            HoneyVault.ConvertNectarT0Honey (NECTAR_PROCES_PER_SHIFT);
        }
    }
}
