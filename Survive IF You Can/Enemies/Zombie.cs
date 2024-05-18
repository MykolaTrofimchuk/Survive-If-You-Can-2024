using Survive_IF_You_Can.Constants;
using Survive_IF_You_Can.General_object;

namespace Survive_IF_You_Can.Enemies;

public class Zombie : GameObject, IEnemy
{
    public Zombie(MainGameForm gameForm, Point startPosition)
    {
        Initialize(Properties.Resources.ZombieLEFT, new Size(GameConstants.ZombieSizeWidth, GameConstants.ZombieSizeHeight), startPosition);
        gameForm.Controls.Add(pictureBox);
    }

    public void MoveTowardsPlayer(Point playerLocation)
    {
        int speed = GameConstants.ZombieSpeed;
        var moveX = (int x) => Position = new Point(x, Position.Y);
        var moveY = (int y) => Position = new Point(Position.X, y);

        if (Position.X > playerLocation.X)
        {
            moveX(Position.X - speed);
            pictureBox.Image = Properties.Resources.ZombieLEFT;
        }
        else if (Position.X < playerLocation.X)
        {
            moveX(Position.X + speed);
            pictureBox.Image = Properties.Resources.ZombieRight;
        }

        if (Position.Y > playerLocation.Y)
        {
            moveY(Position.Y - speed);
            pictureBox.Image = Properties.Resources.ZombieUP;
        }
        else if (Position.Y < playerLocation.Y)
        {
            moveY(Position.Y + speed);
            pictureBox.Image = Properties.Resources.ZombieDOWN;
        }
    }
}
