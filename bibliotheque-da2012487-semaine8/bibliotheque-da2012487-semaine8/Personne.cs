using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace bibliotheque_da2012487_semaine8
{
    public class Personne
    {
        ///Mes attribuuts Personne
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string nas;
        private Personne mereBiologique;
        private Personne pereBiologique;

        /// <summary>
        /// Mon constructeur pour ma classe "Personne" complête.
        /// </summary>
        /// <param name="nom">Le nom de famille de la personne. Une chaine de caractères.</param>
        /// <param name="prenom">Le prénom de ma personne. Une chaine de caractères.</param>
        /// <param name="dateNaissance">La date de naissance de la personne. Un "DateTime".</param>
        /// <param name="nas">Le NAS de la personne. Une chaine de caractères</param>
        /// <param name="pereBiologique">Le père biologique de la personne. Un objet "Personne".</param>
        /// <param name="mereBiologique">La mère biologique de la personne. Un objet "Personne".</param>
        /// <exception cref="ArgumentNullException">Lançe une éxception si : le prenom est nul, le nom est nul, le nas est nul, la mère est nul et/ou le père est nul.</exception>
        public Personne(string nom, string prenom, DateTime dateNaissance, string nas, Personne pereBiologique, Personne mereBiologique)
        {
            this.Nom = nom ?? throw new ArgumentNullException(nameof(nom));
            this.Prenom = prenom ?? throw new ArgumentNullException(nameof(prenom));
            this.DateNaissance = dateNaissance;
            this.Nas = nas ?? throw new ArgumentNullException(nameof(nas));
            this.MereBiologique = mereBiologique ?? throw new ArgumentNullException(nameof(mereBiologique));
            this.PereBiologique = pereBiologique ?? throw new ArgumentNullException(nameof(pereBiologique));
        }

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
                if(value > DateTime.Now)
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
        /// Mon encapsulation pour mon NAS.
        /// </summary>
        /// <exception cref="ArgumentException">Lançe une éxception si le NAS est vide.</exception>
        private string Nas 
        {
            get => nas;
            set 
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Le prénom doit être nom vide");
                }
                else
                {
                    nas = value;
                }
            }
        }

        /// <summary>
        /// Mon encapsulation pour la mère.
        /// </summary>
        private Personne MereBiologique
        {
            get => mereBiologique;
            set
            { 
                mereBiologique = value;
            }
        }

        /// <summary>
        /// Mon encapsulation pour le père.
        /// </summary>
        private Personne PereBiologique 
        {
            get => pereBiologique; 
            set 
            {
                pereBiologique = value;
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
    } 
}