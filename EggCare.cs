using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{   
    internal class EggCare : Bee

    {

        protected new float CostPerShift { get; } = 1.35f;

        public EggCare() :base("EggCare") { }

        protected override void DoJob()
        {
            /*przesłaniana w podklasie*/
        }
    }
}
