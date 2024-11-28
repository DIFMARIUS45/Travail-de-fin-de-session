namespace Frogger
{
    // Pour voir les t�ches : Barre du haut de Visual Studio (menu) -> Affichage -> Liste des t�ches

    // Todo : 3) Ajouter uniquement le fonctionnement de la GRENOUILLE dans la classe Form1 et testez.
    //           Ne fa�te pas fonctionner le reste tout de suite, allez-y morceau par morceau. Soyez agile !
    //           Ne g�rez pas tout de suite les collisions entre les autos et la grenouille, ceci sera � une autre �tape.

    // Todo : 5) Ajouter uniquement le fonctionnement des AUTOS dans la classe Form1 et testez.

    // Todo : 7) Ajouter uniquement le fonctionnement de l'AVION dans la classe Form1 et testez.

    /// <summary>
    ///   Repr�sente le formulaire contenant le jeu.
    /// </summary>
    public partial class Form1 : Form
    {
        private Grenouille? grenouille; // � ? � signifie que la valeur de cette variable peut �tre null.
        //private Avion? avion; // � ? � signifie que la valeur de cette variable peut �tre null.
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
        ///   D�roulement de la partie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NullReferenceException"></exception>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (estTermine)
                return;

            // *** � compl�ter : lancer une exception quand la grenouille OU l'avion est null.
            if (grenouille is null)
                throw new NullReferenceException("La grenouille et l'avion ne doivent pas �tre null une fois la partie commenc�e.");

            // D�placer la grenouille et l'avion.
            grenouille.Deplacer();
            // *** � compl�ter...


            // D�placer chaque auto.
            // Si la grenouille est en collision avec une auto, le nombre de vie de la grenouille doit changer.
            // Utilisez la v�rification de collision de la grenouille et non celle de l'auto,
            // celle-ci a une logique � ex�cuter pour repositionner la grenouille.
            // Si la grenouille perd de la vie, il faut mettre � jour le texte du textbox correspondant.

            // *** � compl�ter...




            // S'il y a collision entre la grenouille et l'avion, la partie termine im�diatement (variable estTermine).
            // Dans ce cas, il faut remplacer l'image de l'avion par l'explosion et un messagebox est affich�.

            // *** � compl�ter...




            // Si la grenouille a termin�e la partie, il faut changer de niveau (voir la m�thode ChangerNiveau).
            if (grenouille.VerifierGameOver())
                ChangerNiveau();

            // Si le nombre de vie est � 0 ou plus bas, il faut arr�ter la partie (variable estTermine) et afficher un MessageBox.
            if (grenouille.nombreVie <= 0)
            {
                estTermine = true;
                MessageBox.Show("Partie termine� !");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Si la grenouille est null, la partie n'est pas encore commenc�e.
            if (grenouille is null)
                return;

            // Changer la direction de la grenouille selon la touche enfonc�e.
            switch (e.KeyCode)
            {
                case Keys.Left:
                    grenouille.direction = Direction.Gauche;
                    break;
                case Keys.Right:
                    grenouille.direction = Direction.Droite;
                    break;

                    // *** � compl�ter...


            }
        }

        /// <summary>
        ///   �v�nement : clique sur le bouton � Commencer �.
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
        /// <param name="niveau">Niveau (1 �tant le premier)</param>
        private void CommencerNouvellePartie()
        {
            // Grenouille
            grenouille = new Grenouille();
            Controls.Add(grenouille.pic); // Ajout du PictureBox � l'�cran
            grenouille.pic.BringToFront(); // Mettre l'image en avant plan

            // Avion : m�me pricipe que la grenouille
            // *** � compl�ter...




            // Autos : ajout d'une voiture � la liste
            // *** � compl�ter...




            // Mettre � jour la vie et le niveau ainsi que leurs textbox.
            niveau = 1;
            txtNiveau.Text = 1.ToString();

            // *** � compl�ter...




            // D�marrage du timer
            timer1.Interval = 60;
            timer1.Start();
        }

        /// <summary>
        ///   Change de niveau.
        ///   Ajoute une auto de plus dans le niveau.
        ///   Incr�mente le niveau de 1 et met � jour le textbox correspondant.
        ///   Repositionne la grenouille (appeler une m�thode de la grenouille).
        ///   La grenouille et l'avion sont d�j� l�, vous n'avez pas � les instancier une autre fois.
        /// </summary>
        private void ChangerNiveau()
        {
            if (grenouille is null)
                throw new NullReferenceException("La grenouille ne doit pas �tre null une fois la partie commenc�e.");

            // *** � compl�ter...



        }
    }
}
