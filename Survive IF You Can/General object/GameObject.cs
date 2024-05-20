namespace Survive_IF_You_Can.General_object;

public class GameObject
{
    protected PictureBox pictureBox;
    protected Point position;

    public PictureBox PictureBox => pictureBox;
    public Point Position
    {
        get => position;
        set
        {
            position = value;
            pictureBox.Location = position;
        }
    }

    protected void Initialize(Image image, Size size, Point startPosition)
    {
        pictureBox = new PictureBox
        {
            Image = image,
            Size = size,
            SizeMode = PictureBoxSizeMode.StretchImage,
            Tag = "gameObject",
            Location = startPosition
        };
        pictureBox.BringToFront();
    }
}
