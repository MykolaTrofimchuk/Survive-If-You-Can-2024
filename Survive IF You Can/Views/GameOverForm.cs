using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survive_IF_You_Can
{
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGameForm form = new MainGameForm();
            form.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameOverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ActualScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {
            MainGameForm mainform = new MainGameForm();
            

        }
    }
}
