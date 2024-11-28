using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    /// <summary>
    ///   Classe statique permettant d'accéder à une seule instance de Random.
    /// </summary>
    public static class GestionRandom
    {
        public static Random random = new Random();
    }
}
