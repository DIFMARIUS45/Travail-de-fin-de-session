using System.Reflection;
using System.Threading.Tasks;

namespace AttrapeEtoile
{
    public partial class Form1 : Form
    {
        private int niveau = 1;
        private Vaisseau tank;
        public Bombe bombe;
        public List<Etoile> listeEtoiles = new List<Etoile>();
        public Form1() 
        {
            InitializeComponent();

            tank = new Vaisseau();
            Controls.Add(tank.pic);
        }


        private void CommencerPartie()
        {
            listeEtoiles.Clear();

            for (int x = 0; x < niveau; x++)
            {
                AjouterEtoile(new EtoileBleu());
                AjouterEtoile(new EtoileRose());
                AjouterEtoile(new EtoileVert());
            }

            timerPrincipal.Start();
        }

       
        private void AjouterEtoile(Etoile etoile)
        {
            listeEtoiles.Add(etoile);
            Controls.Add(etoile.pic);
        } 

}
