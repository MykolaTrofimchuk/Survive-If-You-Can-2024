using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive_IF_You_Can.Player
{
    public class Player
    {
        private PictureBox playerPictureBox;
        private MainGameForm gameForm;
        private PlayerDirection playerDirection;
        private int playerSpeed = 7;

        public Player(MainGameForm gameForm)
        {
            this.gameForm = gameForm;
            InitializePlayer();
        }

        private void InitializePlayer()
        {
            playerPictureBox = new PictureBox();
            playerPictureBox.Image = Properties.Resources.BayraktarUP;
            playerPictureBox.Size = new Size(50, 50); // Розмір зображення гравця
            playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            playerPictureBox.Tag = "player";
            playerPictureBox.Location = new Point(100, 100); // Початкова позиція гравця
            gameForm.Controls.Add(playerPictureBox);
            playerPictureBox.BringToFront();
        }

        public void Move(PlayerDirection direction)
        {
            switch (direction)
            {
                case PlayerDirection.Up:
                    if (playerPictureBox.Top > 0)
                        playerPictureBox.Top -= playerSpeed;
                    break;
                case PlayerDirection.Down:
                    if (playerPictureBox.Top + playerPictureBox.Height < gameForm.ClientSize.Height)
                        playerPictureBox.Top += playerSpeed;
                    break;
                case PlayerDirection.Left:
                    if (playerPictureBox.Left > 0)
                        playerPictureBox.Left -= playerSpeed;
                    break;
                case PlayerDirection.Right:
                    if (playerPictureBox.Left + playerPictureBox.Width < gameForm.ClientSize.Width)
                        playerPictureBox.Left += playerSpeed;
                    break;
                default:
                    break;
            }
        }
    }
}
