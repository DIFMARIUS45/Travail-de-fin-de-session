using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    // Enum : permet d'utiliser une valeur textuelle correspondante à une valeur numérique dans le code.
    // Permet d'améliorer la lisibilité du code de la classe Personnage.
    public enum Direction
    {
        Aucune = 0,
        Gauche = 1,
        Droite = 2,
        Haut = 3,
        Bas = 4
    }
}
