using AttrapeEtoile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttrapeEtoile
{
    /// <summary>
    ///   Classe représentant un Etoile rose.
    /// </summary>
    public class EtoileRose : Etoile
    {
        /// <summary>
        ///   Constructeur
        ///   L'Etoile doit apparaître aléatoirement en haut de l'écran.
        ///   Image : EtoileRose.png
        ///   Direction initiale : bas
        ///   vitesse intiale : 4
        /// </summary>
        public EtoileRose()
        {
            pic.Left = Hasard.random.Next(0, 700);
            pic.Top = Hasard.random.Next(15, 50);
            pic.Image = Image.FromFile("EtoileRose.png");
            vitesse = 4;
            direction = Direction.Bas;
        }

        /// <summary>
        ///   Déplace l'Etoile rose vers le bas.
        ///   Il n'est pas nécessaire d'appeler la méthode de la classe parent.
        /// </summary>
        public override void Deplacer()
        {
            pic.Top += vitesse;
        }
    }
}
