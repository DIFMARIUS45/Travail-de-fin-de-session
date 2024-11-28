namespace Frogger
{
    // Pour voir les tâches : Barre du haut de Visual Studio (menu) -> Affichage -> Liste des tâches

    // Todo : 3) Ajouter uniquement le fonctionnement de la GRENOUILLE dans la classe Form1 et testez.
    //           Ne faîte pas fonctionner le reste tout de suite, allez-y morceau par morceau. Soyez agile !
    //           Ne gèrez pas tout de suite les collisions entre les autos et la grenouille, ceci sera à une autre étape.

    // Todo : 5) Ajouter uniquement le fonctionnement des AUTOS dans la classe Form1 et testez.

    // Todo : 7) Ajouter uniquement le fonctionnement de l'AVION dans la classe Form1 et testez.

    /// <summary>
    ///   Représente le formulaire contenant le jeu.
    /// </summary>
    public partial class Form1 : Form
    {
        private Grenouille? grenouille; // « ? » signifie que la valeur de cette variable peut être null.
        //private Avion? avion; // « ? » signifie que la valeur de cette variable peut être null.
        private List<Auto> listeAuto = [];
        private bool estTermine = false;
        private int nombreVie = 0;
        private int niveau = 0;

        /// <summary>
        ///  Constructeur du formulaire.
        ///  Instancie la grenouille et l'avion tout en affectant les instances aux variables de classes ci-dessus.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   Déroulement de la partie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NullReferenceException"></exception>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (estTermine)
                return;

            // *** À compléter : lancer une exception quand la grenouille OU l'avion est null.
            if (grenouille is null)
                throw new NullReferenceException("La grenouille et l'avion ne doivent pas être null une fois la partie commencée.");

            // Déplacer la grenouille et l'avion.
            grenouille.Deplacer();
            // *** À compléter...


            // Déplacer chaque auto.
            // Si la grenouille est en collision avec une auto, le nombre de vie de la grenouille doit changer.
            // Utilisez la vérification de collision de la grenouille et non celle de l'auto,
            // celle-ci a une logique à exécuter pour repositionner la grenouille.
            // Si la grenouille perd de la vie, il faut mettre à jour le texte du textbox correspondant.

            // *** À compléter...




            // S'il y a collision entre la grenouille et l'avion, la partie termine imédiatement (variable estTermine).
            // Dans ce cas, il faut remplacer l'image de l'avion par l'explosion et un messagebox est affiché.

            // *** À compléter...




            // Si la grenouille a terminée la partie, il faut changer de niveau (voir la méthode ChangerNiveau).
            if (grenouille.VerifierGameOver())
                ChangerNiveau();

            // Si le nombre de vie est à 0 ou plus bas, il faut arrêter la partie (variable estTermine) et afficher un MessageBox.
            if (grenouille.nombreVie <= 0)
            {
                estTermine = true;
                MessageBox.Show("Partie termineé !");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Si la grenouille est null, la partie n'est pas encore commencée.
            if (grenouille is null)
                return;

            // Changer la direction de la grenouille selon la touche enfoncée.
            switch (e.KeyCode)
            {
                case Keys.Left:
                    grenouille.direction = Direction.Gauche;
                    break;
                case Keys.Right:
                    grenouille.direction = Direction.Droite;
                    break;

                    // *** À compléter...


            }
        }

        /// <summary>
        ///   Événement : clique sur le bouton « Commencer ».
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommencer_Click(object sender, EventArgs e)
        {
            CommencerNouvellePartie();

            btnCommencer.Enabled = false;
        }

        /// <summary>
        ///   Initialise une nouvelle partie.
        /// </summary>
        /// <param name="niveau">Niveau (1 étant le premier)</param>
        private void CommencerNouvellePartie()
        {
            // Grenouille
            grenouille = new Grenouille();
            Controls.Add(grenouille.pic); // Ajout du PictureBox à l'écran
            grenouille.pic.BringToFront(); // Mettre l'image en avant plan

            // Avion : même pricipe que la grenouille
            // *** À compléter...




            // Autos : ajout d'une voiture à la liste
            // *** À compléter...




            // Mettre à jour la vie et le niveau ainsi que leurs textbox.
            niveau = 1;
            txtNiveau.Text = 1.ToString();

            // *** À compléter...




            // Démarrage du timer
            timer1.Interval = 60;
            timer1.Start();
        }

        /// <summary>
        ///   Change de niveau.
        ///   Ajoute une auto de plus dans le niveau.
        ///   Incrémente le niveau de 1 et met à jour le textbox correspondant.
        ///   Repositionne la grenouille (appeler une méthode de la grenouille).
        ///   La grenouille et l'avion sont déjà là, vous n'avez pas à les instancier une autre fois.
        /// </summary>
        private void ChangerNiveau()
        {
            if (grenouille is null)
                throw new NullReferenceException("La grenouille ne doit pas être null une fois la partie commencée.");

            // *** À compléter...



        }
    }
}
