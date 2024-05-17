using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive_IF_You_Can.Enemies
{
    public class ZomboSpawn
    {
        private readonly Random rand = new Random();

        public void MakeZombo(MainGameForm form)
        {
            PictureBox zombo = new PictureBox();
            zombo.Tag = "zombo1";
            zombo.Image = Properties.Resources.ZombieLEFT;
            zombo.Left = rand.Next(0, 1200);
            zombo.Top = rand.Next(0, 780);
            zombo.SizeMode = PictureBoxSizeMode.AutoSize;
            form.AddZombieToList(zombo);
            form.Controls.Add(zombo);
        }
    }
}
