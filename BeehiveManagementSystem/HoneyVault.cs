using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        private const float NECTAR_CONVERSION_RATIO = .19f;
        private const float LOW_LEVEL_WARNING = 10f;
        private static float honey = 25f;
        private static float nectar = 100f;
        public static string StatusReport
        {
            get
            {
                string result = string.Format($"Vault report:" +
                    $"\n{honey:0.0} units of honey" +
                    $"\n{nectar} units of nectar");

                if (nectar < LOW_LEVEL_WARNING)
                {
                    result += "\nLOW NECTAR - ADD A NECTAR COLLECTOR";
                }
                if (honey < LOW_LEVEL_WARNING)
                {
                    result += "\nLOW HONEY - ADD A HONEY MANUFACTURER";
                }
                return result;
            }            
        } 

        public static void CollectNectar(float amount)
        {
            if (amount > 0)
            {
                nectar += amount;
            }
        }

        public static void ConvertNectarToHoney(float amount)
        {
            if (nectar >= amount)
            {
                honey += amount * NECTAR_CONVERSION_RATIO;
                nectar -= amount;
            }
            else
            {
                honey += nectar * NECTAR_CONVERSION_RATIO;
                nectar = 0;
            }
        }

        public static bool ConsumerHoney(float amount)
        {
            if (amount <= honey)
            {
                honey -= amount;
                return true;
            }
            return false;
        }
    }
}
