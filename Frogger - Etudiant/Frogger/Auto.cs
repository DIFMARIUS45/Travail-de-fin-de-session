using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    // Todo : 4) Complétez la classe Auto.

    /// <summary>
    ///   Représente une auto / voiture.
    /// </summary>
    public class Auto : ObjetMobile
    {
        private readonly string nomFichier = "Auto"; // Nom du fichier selon la direction de l'auto
        private readonly int[] tabPositionVertical = { 207, 311, 420, 533 }; // Tableau contenant les positions verticales possibles des autos
        public readonly int nbViesPerdues = 10; // Nombre de vie à enlever à la grenouille lors d'une collision

        /// <summary>
        ///   Constructeur d'une auto.
        ///   Doit appeler le constructeur de la classe parent.
        ///   Initilaise les dimensions de l'image.
        ///   Appelle la méthode NouveauMouvement.
        /// </summary>
        /// Écrivez le constructeur.

        // *** À compléter...




        /// <summary>
        ///   Replace aléatoirement l'auto et réinialise son déplacement.
        ///   Choisit aléatoirement une direction entre gauche et droite.
        ///   Place à gauche ou à droite selon la direction choisie.
        ///   Choisit l'image de l'auto selon la direction.
        ///   Choisit aléatoirement une des voie.
        ///   Place verticalement selon la voie choisie.
        ///   Choisit une vitesse aléatoire entre 5 et 15.
        ///   L'auto doit réapparaître légèrement à l'extérieur de l'écran pour un meilleur effet visuel.
        /// </summary>
        /// Indice : allez voir, avec le concepteur/designer, la largeur du PictureBox contenant la route déjà placée dans le formulaire.
        public void NouveauMouvement()
        {
            // *** À compléter...



        }

        /// <summary>
        ///   Déplace l'auto selon sa direction.
        ///   Cette méthode doit appeler la méthode Deplacer de la classe parente.
        ///   Si l'auto dépasse l'écran, la méthode NouveauMouvement doit être appelé afin de réinitialiser l'auto.
        /// </summary>
        /// Surcharger / redéfinissez la méthode Deplacer()

        // *** À compléter...



    }
}
