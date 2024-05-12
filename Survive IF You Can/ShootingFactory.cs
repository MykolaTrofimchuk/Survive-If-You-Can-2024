using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive_IF_You_Can
{
    internal class ShootingFactory
    {
        public static IShooting CreateShooting(string direction, int left, int top, Form form)
        {
            return new Bullet(direction, left, top, form);
        }
    }
}
