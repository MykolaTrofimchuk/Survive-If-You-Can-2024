using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive_IF_You_Can
{
    public class Ammo
    {
        private readonly Random rand = new Random();

        public void DropAmmo(MainGameForm form)
        {
            PictureBox ammo = new PictureBox();
            ammo.Tag = "ammo";
            ammo.Image = Properties.Resources.ammoIMG;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rand.Next(10, form.ClientSize.Width - ammo.Width);
            ammo.Top = rand.Next(50, form.ClientSize.Height - ammo.Height);
            form.Controls.Add(ammo);

            ammo.BringToFront();
        }
    }
}
