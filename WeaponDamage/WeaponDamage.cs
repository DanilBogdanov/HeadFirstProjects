namespace WeaponDamage
{
    public abstract class WeaponDamage
    {
        private int _roll;
        private bool _flaming;
        private bool _magic;

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

        public int Damage { get; protected set; }
        protected abstract void CalculateDamage();
    }
}