using System.Text;

namespace DA2012487_ZacharieNolet_Transtypage
{
    public class Adress
    {
        ///Attributs
        private string rue;
        private string ville;
        private string codePostal;
        private string pays;


        /// <summary>
        /// Mon constructeur pour mon adresse
        /// </summary>
        /// <param name="rue">Le nom de la rue. Une chaine de cacractères.</param>
        /// <param name="ville">Le nom de la ville. Une chaine de caractères.</param>
        /// <param name="codePostal">Le code postal. Une chaine de caractères</param>
        /// <param name="pays">Le pays. Une chaine de caractères</param>
        /// <exception cref="ArgumentNullException">Lançe une exception si : la rue, la ville, le code postal et/ou le pays est nul.</exception>
        public Adress(string rue, string ville, string codePostal, string pays)
        {
            this.Rue = rue ?? throw new ArgumentNullException(nameof(rue));
            this.Ville = ville ?? throw new ArgumentNullException(nameof(ville));
            this.CodePostal = codePostal ?? throw new ArgumentNullException(nameof(codePostal));
            this.Pays = pays ?? throw new ArgumentNullException(nameof(pays));
        }


        /// <summary>
        /// Mon accesseur pour mon attribut "Rue"
        /// </summary>
        ///  <exception cref="ArgumentException">Lançe une exception si : le nom de la rue fait moins de 2 caractères et/ou n'est pas composé de lettre.</exception>
        private string Rue
        {
            get => rue;
            set
            {
                if (value.Length <= 1)
                    throw new ArgumentException("Le nom de la rue doit faire au moins 2 caractères de long.");
                if (int.TryParse(value, out int nombre))
                    throw new ArgumentException("Le nom de la rue doit être composé de lettre(s).");
                else 
                {
                    rue = value;
                }
            }
        }

        /// <summary>
        /// Mon accesseur pour ma propriété "Ville.
        /// </summary>
        ///  <exception cref="ArgumentException">Lançe une exception si : le nom de la ville fait moins de 2 caractères et/ou n'est pas composé uniquement de lettre.</exception>
        private string Ville
        {
            get => ville;
            set
            {
                if (value.Length <= 1)
                    throw new ArgumentException("Le nom de la ville doit faire au moin deux caractères.");
                if (!value.All(char.IsLetter))
                    throw new ArgumentException("Le nom de la ville doit être uniquement composé de lettre.");
                else 
                {
                    ville = value;
                }
            }
        }

        /// <summary>
        /// Mon accesseur pour mon code postal.
        /// </summary>
        ///  <exception cref="ArgumentException">Lançe une exception si : le nom de la rue ne fait pas 6 caractères.</exception>
        private string CodePostal
        {
            get => codePostal;
            set
            {
                if (value.Length != 6)
                    throw new ArgumentException("La longueur du code postale doit être de 6 caractères.");
                else 
                {
                    codePostal = value;
                }
            }
        }

        /// <summary>
        /// Mon accesseur pour mon nom de pays.
        /// </summary>
        ///  <exception cref="ArgumentException">Lançe une exception si : le nom du pays fait moin de deux caarctères et/ou le nom du pays n'est pas uniquement de lettre.</exception>
        private string Pays
        {
            get => pays;
            set
            {
                if (value.Length <= 1)
                    throw new ArgumentException("La longueur du nom du pays doit fair plus de un caractères.");
                if (!value.All(char.IsLetter))
                    throw new ArgumentException("Le nom de pays doit être uniquement composé de lettre.");
                else
                {
                    pays = value;
                }
            }
        }

        /// <summary>
        /// Méthode me permttant d'observer les propriétés de mon objet.
        /// </summary>
        /// <returns>Une chaine de carctères représentant les caractéristiques.</returns>
        public override string ToString()
        {
            StringBuilder chaineCaractere = new StringBuilder();

            chaineCaractere.AppendLine("Rue :" + this.Rue);

            chaineCaractere.AppendLine("Ville : " + this.Ville);

            chaineCaractere.AppendLine("Pays : " + this.Pays);

            chaineCaractere.AppendLine("Code postal : " + this.CodePostal);

            return chaineCaractere.ToString();
        }

        /// <summary>
        /// Ma méthode surchargé de Equals. Elle me permet de comparer deux objet Adresse.
        /// </summary>
        /// <param name="obj">Un objet de n'importe quel type.</param>
        /// <returns>Un type "bool" m'indiquant si oui ou non l'objet est pareille à l'adresse de base.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is null)
                return false;
            if(obj is not Adress)
                return false;
            if(this.rue != ((Adress)obj).rue || this.pays != ((Adress)obj).pays || this.ville != ((Adress)obj).ville || this.codePostal != ((Adress)obj).codePostal)
                return false;
            else
            {
                return true;
            }
        }
    }
}