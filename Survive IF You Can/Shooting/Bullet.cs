using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace Survive_IF_You_Can.Shooting
{
    internal class Bullet : IShooting
    {
        private string bulletDirection;
        private int bulletLeft;
        private int bulletTop;
        private int bulletSpeed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public Bullet(string direction, int left, int top, Form form)
        {
            bulletDirection = direction;
            bulletLeft = left;
            bulletTop = top;

            bullet.Tag = "bullet";
            bullet.BackColor = Color.Yellow;
            bullet.Size = new Size(6, 6);
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = bulletSpeed;
            bulletTimer.Tick += BulletTimerEvent;
            bulletTimer.Start();
        }

        public void Shoot()
        {
            if (bulletDirection == "left")
                bullet.Left -= bulletSpeed;
            else if (bulletDirection == "right")
                bullet.Left += bulletSpeed;
            else if (bulletDirection == "up")
                bullet.Top -= bulletSpeed;
            else if (bulletDirection == "down")
                bullet.Top += bulletSpeed;

            if (bullet.Left < 10 || bullet.Left > 1150 || bullet.Top < 10 || bullet.Top > 770)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
            }
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            Shoot();
        }
    }
}
