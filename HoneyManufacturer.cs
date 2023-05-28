using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    internal class HoneyManufacturer : Bee
    {
        protected new float CostPerShift { get; } = 1.7f;
        public HoneyManufacturer() : base("HoneyManufacturer") { }
        protected override void DoJob()
        {
            /*przesłaniana w podklasie*/
        }
    }
}
