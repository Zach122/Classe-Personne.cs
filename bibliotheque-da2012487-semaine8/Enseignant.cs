using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque_da2012487_semaine8
{
    public class Enseignant
    {
        //Mon champs
        private Personne personne;
        private string noEmploye;
        private double salaire;

        /// <summary>
        /// Mon constructeur pour ma classe Etudiant.
        /// </summary>
        /// <param name="personne">La personne. Un objet "Personne".</param>
        /// <param name="noEmploye">Le numéro d'employé.</param>
        /// <exception cref="ArgumentNullException">Retourne une éxception si la personne et/ou le noEmploye est nul.</exception>
        public Enseignant(Personne personne, string noEmploye, double salaire)
        {
            this.Personne = personne ?? throw new ArgumentNullException(nameof(Personne));
            this.NoEmploye = noEmploye ?? throw new ArgumentNullException(nameof(NoEmploye));
            this.Salaire = salaire;
        }

        /// <summary>
        /// Mon encapsulation pour ma personne.
        /// </summary>
        public Personne Personne
        {
            get => personne;
            set
            {
                personne = value;
            }
        }

        /// <summary>
        /// Mon accesseur pour ma classe salaire.
        /// </summary>
        /// <exception cref="ArgumentException">Retourne une éxception si le salaire est moindre à 0.</exception>
        public double Salaire
        {
            get => salaire;
            set
            {
                if (salaire <= 0)
                {
                    throw new ArgumentException("Le salaire ne peut pas être moins de 0.");
                }
                else 
                {
                    Salaire = value;
                }
            }
        }

        /// <summary>
        /// Mon accesseur pour mon numéro d'employé.
        /// </summary>
        /// <exception cref="ArgumentException">Retourne une éxception si le numéro d'employé ne fait pas six chiffres de long.</exception>
        private string NoEmploye
        {
            get => noEmploye;
            set
            {
                if (value.Length != 6)
                {
                    throw new ArgumentException("Lu numéro d'employé fait 6 chiffres de long.");
                }
                if (!int.TryParse(value, out int numéro))
                {
                    throw new ArgumentException("Le numéro d'employé est constitué que de chiffre.");
                }
                else
                {
                    noEmploye = value;
                }
            }
        }

        /// <summary>
        /// Ma fonction to string pour mon enseigant.
        /// </summary>
        /// <returns>Retourne un chaine de carctères représentant les propriété de mon enseignant.</returns>
        public override string ToString()
        {

            StringBuilder chaineCaractere = new StringBuilder();

            chaineCaractere.AppendLine(this.personne.ToString());

            chaineCaractere.AppendLine(this.NoEmploye);

            chaineCaractere.AppendLine("Cette personne gagne : " + this.Salaire + "$ par année.");

            return chaineCaractere.ToString();
        }
    }
}
