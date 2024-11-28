using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    // Todo : 1) Compléter la classe ObjetMobile. Vous pouvez vous inspirer du code de la classe Personnage de la démonstration.

    /// <summary>
    ///   Représente tout objet mobile.
    ///   Classe abstraite de base.
    ///   Rappel : une classe abstraite ne peut être directement instanciée.
    /// </summary>
    public abstract class ObjetMobile
    {
        #region Variables

        public PictureBox pic;
        public Direction direction = Direction.Aucune; // Voir le fichier Direction.cs
        protected int vitesse = 20;

        #endregion

        #region Constructeur

        /// <summary>
        ///   Instancie le PictureBox et met le bon mode pour le PictureBox.
        /// </summary>
        protected ObjetMobile()
        {
            pic = new PictureBox();
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #endregion

        #region Méthodes publiques

        /// <summary>
        ///   Déplace le l'image selon la direction et la vitesse.
        ///   L'image peut dépasser l'écran, c'est la classe enfant qui doit gérer les limites.
        /// </summary>
        public virtual void Deplacer()
        {
            switch (direction)
            {
                case Direction.Aucune:
                    break;
                case Direction.Gauche:
                    pic.Left -= vitesse;
                    break;
                case Direction.Droite:
                    pic.Left += vitesse;
                    break;

                    // *** À compléter...



            }
        }

        /// <summary>
        ///   Valide s'il y a une collision entre le PictureBox courante et celui reçu en paramètre.
        /// </summary>
        /// <param name="picAutreObjet">PictureBox de l'autre objet</param>
        /// <returns>bool</returns>
        public virtual bool VerifierCollision(PictureBox picAutreObjet)
        {
            return pic.Bounds.IntersectsWith(picAutreObjet.Bounds);
        }

        #endregion
    }
}
