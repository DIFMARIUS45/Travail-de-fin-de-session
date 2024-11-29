using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttrapeEtoile
{
    public class Vaisseau : ObjetMobile
    {
        public Vaisseau()
        {
            pic.Width = 75;
            pic.Height = 30;
            pic.Left = 350;
            pic.Top = 650;
            pic.Image = Image.FromFile("Vaisseau.png");
            vitesse = 20;
        }

        public override void Deplacer()
        {
            if (direction == Direction.Droite && pic.Left < 700)
                pic.Left += vitesse;
            if (direction == Direction.Gauche && pic.Left > 0)
                pic.Left -= vitesse;
        }
    }
}
