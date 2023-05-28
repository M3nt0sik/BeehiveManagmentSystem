using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    internal class Bee
    {
        private string job; 
        protected float CostPerShift { get; }

        public Bee(string job)
        {
            this.job = job;
        }

        public void TheNextShift()
        {
           if(HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }

        }

        protected virtual void DoJob()
        {
            /*przesłaniana w podklasie*/
        }

    }
}
