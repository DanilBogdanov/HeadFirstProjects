using System.Diagnostics;

namespace SwordDamage_ConsoleApp
{
    public class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        public int Roll;
        private decimal MagicMultiplier = 1M;
        private int FlamingDamage = 0;
        public int Damage;
        

        private void CalculateDamage()
        {
            Damage = (int) (Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
            Debug.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
            Debug.WriteLine($"SetMagic finished: {Damage} (roll: {Roll})");
        }

        public void SetFlaming(bool isFlaming)
        {            
            if (isFlaming)
            {
                FlamingDamage = FLAME_DAMAGE;
            }
            else
            {
                FlamingDamage = 0;
            }
            CalculateDamage();
            Debug.WriteLine($"SetFlaming finished: {Damage} (roll: {Roll})");
        }
    }
}