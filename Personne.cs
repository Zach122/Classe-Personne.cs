using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA2012487_ZacharieNolet_Transtypage
{
    public class Personne
    {
        ///Mes attribuuts Personne
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        /// <summary>
        /// Mon constructeur pour ma classe "Personne" partielle.
        /// </summary>
        /// <param name="nom">Le nom de famille de la personne. Une chaine de caractères.</param>
        /// <param name="prenom">Le prénom de ma personne. Une chaine de caractères.</param>
        /// <param name="dateNaissance">La date de naissance de la personne. Un "DateTime".</param>
        /// <exception cref="ArgumentNullException">Lançe une éxception si : le prenom est nul et/ou le nom est nul</exception>
        public Personne(string nom, string prenom, DateTime dateNaissance)
        {

            this.Nom = nom ?? throw new ArgumentNullException(nameof(nom));
            this.Prenom = prenom ?? throw new ArgumentNullException(nameof(prenom));
            this.DateNaissance = dateNaissance;
        }

        /// <summary>
        /// Ma construccteur clone pour mon objet "Personne".
        /// </summary>
        /// <param name="personne">Un objet personne.</param>
        public Personne(Personne personne)
        {
            this.nom = personne.nom;
            this.prenom = personne.prenom;
            this.dateNaissance = personne.dateNaissance;
        }

        /// <summary>
        /// Ma méthode d'encapsulation pour mon nom.
        /// </summary>
        /// <exception cref="ArgumentException">Lançe une éxception si le nom est vide.</exception>
        public string Nom
        {
            get => nom;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Le nom doit être nom vide");
                }
                else
                {
                    nom = value;
                }
            }
        }

        /// <summary>
        /// Ma méthode d'encapsulation pour mon prénom.
        /// </summary>
        /// <exception cref="ArgumentException">Lançe une éxception si le prenom est vide.</exception>
        private string Prenom
        {
            get => prenom;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Le prénom doit être nom vide");
                }
                else
                {
                    prenom = value;
                }
            }
        }

        /// <summary>
        /// L'encapsulation de la date de naissance.
        /// </summary>
        /// <exception cref="ArgumentException">Lançe une éxception si la date se situe dans le futur.</exception>
        private DateTime DateNaissance
        {
            get => dateNaissance;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("La date de naissance ne peut pas se situé dans le futur.");
                }
                else
                {
                    dateNaissance = value;
                }

            }
        }

        /// <summary>
        /// Mon encapsulation pour la création du nom complet.
        /// </summary>
        public string NomComplet
        {
            get => nom + ", " + prenom;
            set
            {
                NomComplet = value;
            }
        }

        /// <summary>
        /// Mon encapsulation pour mon age
        /// </summary>
        public int Age
        {

            get => CalculerAge();
            set
            {

                Age = value;
            }
        }

        /// <summary>
        /// Un méthode me permettant de calculer l'age de la personne.
        /// </summary>
        /// <returns>Retourne l'age en nombre d'année(s).</returns>
        private int CalculerAge()
        {
            TimeSpan difference = DateTime.Now.Subtract(dateNaissance);
            return (int)(difference.Days / 365);
        }

        /// <summary>
        /// Méthode me permttant d'observer les propriétés de mon objet.
        /// </summary>
        /// <returns>Une chaine de carctères représentant les caractéristiques.</returns>
        public override string ToString()
        {
            StringBuilder chaineCaractere = new StringBuilder();

            chaineCaractere.AppendLine(this.Nom + "," + this.Prenom + " : " + this.DateNaissance);

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

            if (obj is not Personne)
                return false;

            Personne autrePersonne = ((Personne)obj);

            if (this.nom != autrePersonne.nom  || this.prenom != autrePersonne.prenom || this.dateNaissance != autrePersonne.dateNaissance)
                return false;

            else
            {
                return true;
            }
        }
    }
}
