using Survive_IF_You_Can.Enemies;
using Survive_IF_You_Can.Player;
using Survive_IF_You_Can.Shooting;
using Timer = System.Windows.Forms.Timer;

namespace Survive_IF_You_Can
{
    public partial class MainGameForm : Form
    {
        Random rand = new Random();
        PauseForm pause = new PauseForm();
        GameOverForm gameOverForm = new GameOverForm();
        Ammo Ammo = new Ammo();
        ZomboSpawn zomboSpawn = new ZomboSpawn();

        private List<IShooting> bullets = new List<IShooting>();
        List<PictureBox> zomboList = new List<PictureBox>();

        private PlayerMovementController movementController;
        private PlayerDirection playerDirection;
        private Timer zomboDeadTimer = new Timer();
        private PictureBox deadZomboPictureBox;

        private int _zombieAmount = 3;
        bool goup;
        bool godown;
        bool goleft;
        bool goright;
        string looking = "up";
        double playerHealth = 100;
        int playerSpeed = 7;
        int ammo = 10;
        int zomboSpeed = 1;
        public int kills = 0;
        bool gameOver = false;
        bool isPaused = false;
        Timer pauseTimer;

        public void AddZombieToList(PictureBox zombie)
        {
            zomboList.Add(zombie);
        }

        public MainGameForm()
        {
            InitializeComponent();
            movementController = new PlayerMovementController(this);
            RestartGame();
        }

        private void MainGameForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ammo > 0)
            {
                ammo--;
                var bullet = ShootingFactory.CreateShooting(looking, Player.Left + (Player.Width / 2), Player.Top + (Player.Height / 2), this);
                bullets.Add(bullet);
                bullet.Shoot();

                if (ammo < 1)
                    Ammo.DropAmmo(this);
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            movementController.KeyDown(e);

            if (gameOver) return;

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                godown = true;
                looking = "down";
                SetPlayerDirection(PlayerDirection.Down);
                Player.Image = Properties.Resources.BayraktarDOWN;
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                goup = true;
                looking = "up";
                SetPlayerDirection(PlayerDirection.Up);
                Player.Image = Properties.Resources.BayraktarUP;
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                goleft = true;
                looking = "left";
                SetPlayerDirection(PlayerDirection.Left);
                Player.Image = Properties.Resources.BayraktarLEFT;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goright = true;
                looking = "right";
                SetPlayerDirection(PlayerDirection.Right);
                Player.Image = Properties.Resources.BayraktarRIGHT;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            movementController.KeyUp(e);

            if (gameOver == true)
            {
                gameOverForm.Show();
                gameOverForm.ActualScoreLabel.Text = "Ваш рахунок: " + this.kills;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (!goup && !godown && !goleft && !goright)
            {
                ResetPlayerDirection();
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (gameOver)
                {
                    RestartGame();
                }
                else
                {
                    TogglePause();
                }
            }
        }

        private void GameEngine(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                PBforHealth.Value = Convert.ToInt32(playerHealth);
            }
            else
            {
                Player.Image = Properties.Resources.bayrDead;
                timer.Stop();
                gameOver = true;
            }
            if (playerHealth <= 0)
            {
                // Гравець мертвий
                gameOverForm.Show();
                gameOverForm.ActualScoreLabel.Text = "Ваш рахунок: " + this.kills;
                timer.Stop();
                gameOver = true;
                return;
            }
            labelForAmmo.Text = "Снарядів: " + ammo;
            labelForScore.Text = "Рахунок: " + kills;

            ChangeLevel(kills);
            UpdatePlayerMovement();

            foreach (Control controlX in this.Controls)
            {
                // підняття куль гравцем
                if (controlX is PictureBox && (string)controlX.Tag == "ammo")
                {
                    if (Player.Bounds.IntersectsWith(controlX.Bounds))
                    {
                        this.Controls.Remove(controlX);
                        ((PictureBox)controlX).Dispose();
                        ammo += 5;
                    }
                }

                if (controlX is PictureBox && (string)controlX.Tag == "zombo1")
                {
                    // урон отриманий від зомбі
                    if (Player.Bounds.IntersectsWith(controlX.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    // Переміщення (ходьба) зомбі по мапі
                    if (controlX.Left > Player.Left)
                    {
                        controlX.Left -= zomboSpeed;
                        ((PictureBox)controlX).Image = Properties.Resources.ZombieLEFT;
                    }

                    if (controlX.Top > Player.Top)
                    {
                        controlX.Top -= zomboSpeed;
                        ((PictureBox)controlX).Image = Properties.Resources.ZombieUP;
                    }

                    if (controlX.Left < Player.Left)
                    {
                        controlX.Left += zomboSpeed;
                        ((PictureBox)controlX).Image = Properties.Resources.ZombieRight;
                    }

                    if (controlX.Top < Player.Top)
                    {
                        controlX.Top += zomboSpeed;
                        ((PictureBox)controlX).Image = Properties.Resources.ZombieDOWN;
                    }
                }

                foreach (Control controlJ in this.Controls)
                {
                    if (controlX is PictureBox && (string)controlX.Tag == "bullet" && controlJ is PictureBox && (string)controlJ.Tag == "zombo1")
                    {
                        // Влучання в ціль
                        if (controlX.Bounds.IntersectsWith(controlJ.Bounds))
                        {
                            kills++;

                            ((PictureBox)controlJ).Image = null;
                            deadZomboPictureBox = (PictureBox)controlJ;
                            ShowDeadZombo();

                            this.Controls.Remove(controlJ);
                            this.Controls.Remove(controlX);
                            ((PictureBox)controlX).Dispose();

                            zomboList.Remove((PictureBox)controlJ);
                            zomboSpawn.MakeZombo(this);
                            Player.BringToFront();
                        }
                    }
                }
            }
        }

        private void ShowDeadZombo()
        {
            deadZomboPictureBox.Image = Properties.Resources.ZomboDead;
            zomboDeadTimer.Start();
        }

        private void zomboDeadTimer_Tick(object sender, EventArgs e)
        {
            zomboDeadTimer.Stop();
            this.Controls.Remove(deadZomboPictureBox);
        }

        private void RestartGame()
        {
            timer.Stop();

            zomboDeadTimer.Interval = 1000;
            zomboDeadTimer.Tick += zomboDeadTimer_Tick;

            Player.Image = Properties.Resources.BayraktarUP;

            foreach (PictureBox zomb in zomboList)
            {
                this.Controls.Remove(zomb);
            }

            zomboList.Clear();

            for (int zomb = 0; zomb < _zombieAmount; zomb++)
            {
                zomboSpawn.MakeZombo(this);
                Player.BringToFront();
            }

            goup = false;
            godown = false;
            goleft = false;
            goright = false;

            playerHealth = 100;
            kills = 0;
            ammo = 10;

            timer.Start();
        }

        private void MainGameForm_Load(object sender, EventArgs e)
        {
            movementController = new PlayerMovementController(this);
        }

        private void MainGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Реалізація паузи в грі
        private void TogglePause()
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        private void PauseGame()
        {
            isPaused = true;
            timer.Stop();

            using (var overlayForm = new TransparentOverlayForm())
            {
                overlayForm.Bounds = Bounds;
                overlayForm.TopMost = true;
                overlayForm.ShowInTaskbar = false;
                overlayForm.Show();

                pause.Show();
                pause.scoreLabel.Text = "Ваш рахунок: " + this.kills;

                foreach (Control control in Controls)
                {
                    control.Enabled = false;
                }

                pauseTimer = new Timer();
                pauseTimer.Interval = 100;
                pauseTimer.Tick += PauseTimer_Tick;
                pauseTimer.Start();
            }
        }

        private void ResumeGame()
        {
            timer.Stop();

            isPaused = false;
            pauseTimer.Stop();
            pauseTimer.Dispose();
            PauseForm pause = new PauseForm();
            pause.Hide();

            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }

            timer.Start();
        }

        public class TransparentOverlayForm : Form
        {
            public TransparentOverlayForm()
            {
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                BackColor = Color.Transparent;
            }
        }

        private bool IsEscapeKeyPressed()
        {
            PauseForm pause = new PauseForm();
            return (Control.ModifierKeys & Keys.Escape) == Keys.Escape;
        }

        private void PauseTimer_Tick(object sender, EventArgs e)
        {
            if (IsEscapeKeyPressed())
            {
                ResumeGame();
            }
        }

        // Оновлення руху гравця
        private void UpdatePlayerMovement()
        {
            switch (playerDirection)
            {
                case PlayerDirection.Up:
                    if (Player.Top > 0)
                        Player.Top -= playerSpeed;
                    break;
                case PlayerDirection.Down:
                    if (Player.Top + Player.Height < ClientSize.Height)
                        Player.Top += playerSpeed;
                    break;
                case PlayerDirection.Left:
                    if (Player.Left > 0)
                        Player.Left -= playerSpeed;
                    break;
                case PlayerDirection.Right:
                    if (Player.Left + Player.Width < ClientSize.Width)
                        Player.Left += playerSpeed;
                    break;
                default:
                    break;
            }
        }

        // Встановлення напрямку руху гравця
        private void SetPlayerDirection(PlayerDirection direction)
        {
            playerDirection = direction;
        }

        // Скидання напрямку руху гравця
        private void ResetPlayerDirection()
        {
            playerDirection = PlayerDirection.None;
        }

        private void ChangeLevel(int kills)
        {
            int newLevel = kills / 10 + 1;
            int oldLevel = Convert.ToInt32(levelLbl.Text.Split(' ')[1]);

            if (newLevel > oldLevel)
            {
                levelLbl.Text = "Level: " + newLevel;
                zomboSpeed++;
                playerHealth = 100;

                if (newLevel % 3 == 0)
                    playerSpeed++;

                if (newLevel % 5 == 0)
                    _zombieAmount++;
            }
        }
    }
}