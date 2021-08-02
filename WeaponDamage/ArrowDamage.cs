using System;

namespace WeaponDamage
{
    /// <summary>
    /// Calculate sword damage with magic and flame
    /// </summary>
    public class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = .35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        /// <summary>
        /// Initialize instance of SwordDamage with roll
        /// </summary>
        /// <param name="roll"></param>
        public ArrowDamage(int roll)
        {
            Roll = roll;
        }

        protected override void CalculateDamage()
        {
            //Magic damage if true using const otherwise is 1
            decimal magicDamage = Magic ? MAGIC_MULTIPLIER : 1M;
            //Flaming damage if true is const otherwise 0
            decimal flameDamage = Flaming ? FLAME_DAMAGE : 0;

            Damage = (int) Math.Ceiling((Roll * BASE_MULTIPLIER * magicDamage) + flameDamage);
        }
    }
}