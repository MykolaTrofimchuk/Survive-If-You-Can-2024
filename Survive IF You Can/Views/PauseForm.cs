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
    public partial class PauseForm : Form
    {
        public PauseForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void resumeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendKeys.Send("{ESC}");
        }

        private void PauseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            resumeButton_Click(sender, e);
        }

        private void PauseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
