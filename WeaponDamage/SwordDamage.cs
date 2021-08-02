namespace WeaponDamage
{
    /// <summary>
    /// Calculate sword damage with magic and flame
    /// </summary>
    public class SwordDamage : WeaponDamage
    {
        private const int BaseDamage = 3;
        private const int FlameDamage = 2;

        /// <summary>
        /// Initialize instance of SwordDamage with roll
        /// </summary>
        /// <param name="roll"></param>
        public SwordDamage(int roll)
        {
            Roll = roll;
        }

        protected override void CalculateDamage()
        {
            //Magic damage if true is 1.75 otherwise is 1
            decimal magicDamage = Magic ? 1.75M : 1M;
            //Flaming damage if true is const FLAME_DAMAGE otherwise 0
            int flameDamage = Flaming ? FlameDamage : 0;

            Damage = (int) (Roll * magicDamage) + BaseDamage + flameDamage;
        }
    }
}