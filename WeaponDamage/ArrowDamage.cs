using System;

namespace WeaponDamage
{
    /// <summary>
    /// Calculate sword damage with magic and flame
    /// </summary>
    public class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = .35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

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
        public ArrowDamage(int roll)
        {
            _roll = roll;
            CalculateDamage();
        }

        private void CalculateDamage()
        {
            //Magic damage if true using const otherwise is 1
            decimal magicDamage = Magic ? MAGIC_MULTIPLIER : 1M;
            //Flaming damage if true is const otherwise 0
            decimal flameDamage = Flaming ? FLAME_DAMAGE : 0;

            Damage = (int) Math.Ceiling((Roll * BASE_MULTIPLIER * magicDamage) + flameDamage);
        }
    }
}