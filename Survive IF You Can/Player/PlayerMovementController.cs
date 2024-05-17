using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Survive_IF_You_Can.Player
{
    public class PlayerMovementController
    {
        private readonly MainGameForm mainForm;

        private bool isMovingUp = false;
        private bool isMovingDown = false;
        private bool isMovingLeft = false;
        private bool isMovingRight = false;

        public PlayerMovementController(MainGameForm form)
        {
            mainForm = form;
        }

        public void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                isMovingDown = true;
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                isMovingUp = true;
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                isMovingLeft = true;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                isMovingRight = true;
            }
        }

        public void KeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                isMovingDown = false;
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                isMovingUp = false;
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                isMovingLeft = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                isMovingRight = false;
            }
        }
    }
}
