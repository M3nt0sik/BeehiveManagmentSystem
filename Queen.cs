using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    internal class Queen:Bee
    {
        protected new float CostPerShift { get; } = 2.14f;
        public Queen():base("Queen") { }


        protected override void DoJob()
        {
            /*przesłaniana w podklasie*/
        }
    }
}
