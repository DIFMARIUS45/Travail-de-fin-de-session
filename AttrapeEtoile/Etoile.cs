using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttrapeEtoile
{
    public abstract class Etoile : ObjetMobile
    {

        protected Etoile()
        {
            pic.Width = 35;
            pic.Height = 35;
            direction = (Direction)Hasard.random.Next(3, 5);
        }
    }
}
