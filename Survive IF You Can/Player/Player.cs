using Survive_IF_You_Can.Constants;
using Survive_IF_You_Can.General_object;

namespace Survive_IF_You_Can.Player;

public class Player : GameObject, IGameCharacter
{
    private MainGameForm gameForm;
    public Player(MainGameForm gameForm)
    {
        this.gameForm = gameForm;
        Initialize(Properties.Resources.BayraktarUP, new Size(GameConstants.AmmoSizeWidth, GameConstants.AmmoSizeHeight), new Point(100, 100));
        gameForm.Controls.Add(pictureBox);
    }

    public void Move(PlayerDirection direction)
    {
        int speed = GameConstants.PlayerSpeed;
        switch (direction)
        {
            case PlayerDirection.Up:
                if (Position.Y > 0)
                    Position = new Point(Position.X, Position.Y - speed);
                break;
            case PlayerDirection.Down:
                if (Position.Y + pictureBox.Height < gameForm.ClientSize.Height)
                    Position = new Point(Position.X, Position.Y + speed);
                break;
            case PlayerDirection.Left:
                if (Position.X > 0)
                    Position = new Point(Position.X - speed, Position.Y);
                break;
            case PlayerDirection.Right:
                if (Position.X + pictureBox.Width < gameForm.ClientSize.Width)
                    Position = new Point(Position.X + speed, Position.Y);
                break;
        }
    }
}
