using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    internal class Queen:Bee
    {
        private float eggs=0;
        private float unassignedWorkers = 3;
        private const float EGGS_PER_SHIFT = 0.45f;
        private const float HONEY_PER_UNASIGNED_WORKER = .5f;
        public string StatusReport { get; private set; }

        protected override float CostPerShift { get; } = 2.14f;
        private IWorker[] Workers = new IWorker[1];
        public Queen():base("Queen") 
        {
            //AssignBee("EggCare");
            Workers[0] = new EggCare(this);
            AssignBee("NectarCollector");
            AssignBee("HoneyManufacturer");

        }
        private void AddWorker(IWorker worker)
               {
                   if(unassignedWorkers >= 1)
                    {
                        unassignedWorkers--;
                        Array.Resize(ref Workers, Workers.Length + 1);
                        Workers[Workers.Length-1] = worker;
                    }
                }
        private void UpdateStatusReport()
                {
                    StatusReport = $"Raport o stanie skarbca: \n{HoneyVault.StatusReport}" +
                                   $"\nLiczba jaj: {eggs:0.0}" +
                                   $"\nNieprzydzielone robotnice: {unassignedWorkers:0.0}" +
                                   $"\n{WorkerStatus("NectarCollector")}\n{WorkerStatus("HoneyManufacturer")}" +
                                   $"\n{WorkerStatus("EggCare")}\nRobotnice w sumie: {Workers.Length}";
                }
        public void CareOfEggs(float eggsToConvert)
                {
            if (eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            }
         }

        private string WorkerStatus(string job)
        {
            int count = 0;
            foreach (Bee worker in Workers)
            {
                if (worker.Job == job) count++;
            }
            return $"{job}: {count}";
        }

        public void AssignBee(string job)
                {
                    switch (job)
                    {
                        case "NectarCollector":
                            AddWorker(new NectarCollector());
                            break;
                        case "HoneyManufacturer":
                            AddWorker(new HoneyManufacturer());
                            break;
                        case "EggCare":
                            AddWorker(new EggCare(this));
                            break;
                    }
                    UpdateStatusReport();
                }


      
        protected override void DoJob()
        {
            foreach(IWorker worker in Workers)
            {
                worker.TheNextShift();
            }
            eggs += EGGS_PER_SHIFT;
            HoneyVault.ConsumeHoney(unassignedWorkers * HONEY_PER_UNASIGNED_WORKER);
            UpdateStatusReport();
        }

        

       
    }
}
