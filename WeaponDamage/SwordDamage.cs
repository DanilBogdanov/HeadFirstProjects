namespace WeaponDamage
{
    /// <summary>
    /// Calculate sword damage with magic and flame
    /// </summary>
    public class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        private int _roll;

        /// <summary>
        /// Value of the 3d6 roll.
        /// </summary>
        public int Roll
        {
            get => _roll;
            set
            {
                _roll = value;
                CalculateDamage();
            }
        }

        private bool _flaming;

        /// <summary>
        /// True if the sword is flaming.
        /// </summary>
        public bool Flaming
        {
            get => _flaming;
            set
            {
                _flaming = value;
                CalculateDamage();
            }
        }

        private bool _magic;

        /// <summary>
        /// True if the sword is magic.
        /// </summary>
        public bool Magic
        {
            get => _magic;
            set
            {
                _magic = value;
                CalculateDamage();
            }
        }

        public int Damage { get; private set; }

        /// <summary>
        /// Initialize instance of SwordDamage with roll
        /// </summary>
        /// <param name="roll"></param>
        public SwordDamage(int roll)
        {
            _roll = roll;
            CalculateDamage();
        }

        private void CalculateDamage()
        {
            //Magic damage if true is 1.75 otherwise is 1
            decimal magicDamage = Magic ? 1.75M : 1M;
            //Flaming damage if true is const FLAME_DAMAGE otherwise 0
            int flameDamage = Flaming ? FLAME_DAMAGE : 0;

            Damage = (int) (Roll * magicDamage) + BASE_DAMAGE + flameDamage;
        }
    }
}