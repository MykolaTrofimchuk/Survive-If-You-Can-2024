using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive_IF_You_Can
{
    public class Zombie
    {
        private PictureBox zombiePictureBox;
        private MainGameForm gameForm;
        private int zombieSpeed = 1;

        public PictureBox PictureBox => zombiePictureBox; // Властивість для доступу до PictureBox

        public Point PlayerPosition { get; set; }
        public bool IsHit { get; set; }

        private PictureBox pictureBox;
        private Point startPosition;

        public Zombie(MainGameForm gameForm, PictureBox pictureBox, Point startPosition)
        {
            this.gameForm = gameForm;
            this.pictureBox = pictureBox;
            this.startPosition = startPosition;

            // Ініціалізуємо PictureBox і додаємо його до форми
            zombiePictureBox = new PictureBox();
            InitializeZombie(startPosition);
            gameForm.Controls.Add(zombiePictureBox);
        }

        private void InitializeZombie(Point location)
        {
            zombiePictureBox.Image = Properties.Resources.ZombieLEFT;
            zombiePictureBox.Size = new Size(50, 50); // Розмір зображення зомбі
            zombiePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            zombiePictureBox.Tag = "zombie";
            zombiePictureBox.Location = location; // Початкова позиція зомбі
            zombiePictureBox.BringToFront(); // Перемістимо на передній план
        }

        public void MoveTowardsPlayer(Point playerLocation)
        {
            if (zombiePictureBox != null && zombiePictureBox.Left > playerLocation.X)
            {
                zombiePictureBox.Left -= zombieSpeed;
                zombiePictureBox.Image = Properties.Resources.ZombieLEFT;
            }
            else if (zombiePictureBox != null && zombiePictureBox.Left < playerLocation.X)
            {
                zombiePictureBox.Left += zombieSpeed;
                zombiePictureBox.Image = Properties.Resources.ZombieRight;
            }

            if (zombiePictureBox != null && zombiePictureBox.Top > playerLocation.Y)
            {
                zombiePictureBox.Top -= zombieSpeed;
                zombiePictureBox.Image = Properties.Resources.ZombieUP;
            }
            else if (zombiePictureBox != null && zombiePictureBox.Top < playerLocation.Y)
            {
                zombiePictureBox.Top += zombieSpeed;
                zombiePictureBox.Image = Properties.Resources.ZombieDOWN;
            }
        }
    }

}
