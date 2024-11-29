using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttrapeEtoile
{
    public abstract class ObjetMobile
    {
        public PictureBox pic;
        public Direction direction;
        protected int vitesse;

        protected ObjetMobile()
        {
            pic = new PictureBox();
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        public abstract void Deplacer();
    }
}
