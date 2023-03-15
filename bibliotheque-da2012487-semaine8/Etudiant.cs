using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque_da2012487_semaine8
{
    public class Etudiant
    {
        //Mon champs
        private Personne personne;
        private string da;

        /// <summary>
        /// Mon constructeur pour ma classe Etudiant.
        /// </summary>
        /// <param name="personne">La personne. C'est un objet "Personne".</param>
        /// <param name="da">Le numéro de DA.</param>
        /// <exception cref="ArgumentNullException">Retourne une éxception si la personne et/ou le DA est nul.</exception>
        public Etudiant(Personne personne, string da)
        {
            this.Personne= personne ?? throw new ArgumentNullException(nameof(personne));
            this.Da = da ?? throw new ArgumentNullException(nameof(da));
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
        /// Mon accesseur pour mon DA.
        /// </summary>
        /// <exception cref="ArgumentException">Retourne une éxception si le numéro d'employé ne fait pas six chiffres de long.</exception>
        private string Da 
        {
            get => da;
            set 
            {
                if(value.Length != 7)
                {
                    throw new ArgumentException(nameof(da));
                }
                if (!int.TryParse(value, out int numero))
                {
                    throw new ArgumentException("Le numéro d'employé est constitué que de chiffre.");
                }
                else
                {
                    da = value;
                }
            } 
        }

        /// <summary>
        /// Ma fonction to string pour mon étudiant.
        /// </summary>
        /// <returns>Retourne un chaine de carctères représentant les propriété de mon étudiant.</returns>
        public override string ToString()
        {

            StringBuilder chaineCaractere = new StringBuilder();

            chaineCaractere.AppendLine(this.personne.ToString());

            chaineCaractere.AppendLine(this.Da);

            return chaineCaractere.ToString();
        }
    }
}
