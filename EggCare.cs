using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{   
    internal class EggCare : Bee

    {
        public const float CARE_PROGRESS_PER_SHIFT = 0.15f;

        protected new float CostPerShift { get; } = 1.35f;
        private Queen queen;
        public EggCare(Queen queen) :base("EggCare") {this.queen = queen; }
        //public EggCare() :base("EggCare") { }

        protected override void DoJob()
        {
            queen.CareOfEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
