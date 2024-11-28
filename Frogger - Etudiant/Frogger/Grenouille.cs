using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    // Todo : 2) Complétez la classe Grenouille. Vous pouvez vous inspirer du code de la classe Grenouille de la démonstration.

    /// <summary>
    ///   Représente une gronouille.
    /// </summary>
    public class Grenouille : ObjetMobile
    {
        public int nombreVie = 100;

        /// <summary>
        ///   Constructeur de la grenouille.
        ///   Initialse l'image ainsi que sa position et ses dimensions.
        ///   Doit appeler le constructeur de la classe parent.
        ///   Doit appeler la méthode Repositionner de la classe Grenouille.
        /// </summary>
        public Grenouille() : base() // Le constructeur de la classe Personnage sera exécuté avant.
        {
            pic.Width = 56;
            pic.Height = 60;
            pic.Image = Image.FromFile("Grenouille.png");
            Repositionner();
        }

        /// <summary>
        ///   Positionne la grenouille à son endroit d'origine.
        /// </summary>
        public void Repositionner()
        {
            pic.Top = 625;
            pic.Left = 475;
        }

        /// <summary>
        ///   Déplace la grenouille.
        ///   Cette méthode doit appeler la méthode équivalente de la classe parente.
        ///   La grenouille ne doit pas dépasser l'écran.
        /// </summary>
        public override void Deplacer()
        {
            // *** À compléter...



        }

        /// <summary>
        ///   Valide si la grenouille a atteint le lac ou non.
        ///   Dès que la grenouille atteint la position verticale de 150 ou moins, on considère que la grenouille a atteint le lac.
        /// </summary>
        /// <returns>bool</returns>
        public bool VerifierGameOver()
        {
            return pic.Top <= 150;
        }

        /// <summary>
        ///   Vérifie s'il y a une collision entre la grenouille et un obstacle.
        ///   S'il y a une collision, replace la grenouille en bas de l'écran.
        ///   Cette méthode doit appeler la méthode équivalente de la classe parente.
        /// </summary>
        /// <param name="picObstacle">PictureBox de l'obstacle</param>
        /// <returns>bool</returns>
        public override bool VerifierCollision(PictureBox picObstacle)
        {
            // *** À compléter...



        }
    }
}
