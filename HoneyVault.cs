using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagmentSystem
{
    static class HoneyVault
    {
        private static float NECTAR_CONVERSION_RATIO = .20f;
        private static float LOW_LEVEL_RATIO = 10f;
        private static float honey = 15f;
        private static float nectar = 100f;

        public static void ConvertNectarT0Honey(float amount)
        {
            float toConvertamount = 0f;
            if (amount > nectar) toConvertamount = nectar;
            else toConvertamount = amount;
            honey += (toConvertamount * NECTAR_CONVERSION_RATIO);
            nectar -= toConvertamount;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount <= honey)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        public static void CollectNectar(float amount)
        {
            if (amount > 0) nectar += amount;
        }

        public static string StatusReport
        {
            get
            {
                string warning = "";
                if (honey < LOW_LEVEL_RATIO) warning += "\n Mala ilość midu!!!";
                if (nectar < LOW_LEVEL_RATIO) warning += "\nMała ilość nectaru!!!";
                return($"Ilość dostepnego nectaru: {nectar}\n" +
                       $"Ilość dostepnego miodu: {honey}" +
                       $"{warning}");
            }
        }
    }
}
