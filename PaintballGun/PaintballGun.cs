using System.Reflection;
using System.Security;

namespace PaintballGun
{
    public class PaintballGun
    {
        public int MagazineSize { get; private set; }
        private int balls = 0;

        public int Balls
        {
            get => balls;
            set
            {
                if (value > 0)
                {
                    balls = value;
                }

                Reload();
            }
        }

        public int BallsLoaded { get; private set; } 

        public bool IsEmpty()
        {
            return BallsLoaded == 0;
        }

        public void Reload()
        {
            if (balls > MagazineSize)
            {
                BallsLoaded = MagazineSize;
            }
            else
            {
                BallsLoaded = balls;
            }
        }

        public bool Shoot()
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            balls--;
            return true;
        }
    }
}