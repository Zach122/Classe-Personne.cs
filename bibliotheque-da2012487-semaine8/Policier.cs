using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque_da2012487_semaine8
{
    public class Policier
    {
        //Mon champs
        private Personne personne;
        private string noMatricule;
        private string noPoste;

        /// <summary>
        /// Mon constructeur pour ma classe Policier.
        /// </summary>
        /// <param name="personne">La personne. Un objet "Personne".</param>
        /// <param name="noMatricule">Le numéro de matricule.</param>
        /// <param name="noPoste">Le numéro de poste.</param>
        /// <exception cref="ArgumentNullException">Retourne une éxception si la personne, le noMatricule et/ou le noPoste est nul.</exception>
        public Policier(Personne personne, string noMatricule, string noPoste)
        {
            this.Personne = personne ?? throw new ArgumentNullException(nameof(personne));
            this.NoMatricule = noMatricule ?? throw new ArgumentNullException(nameof(NoMatricule));
            this.NoPoste = noPoste ?? throw new ArgumentNullException(nameof(NoPoste));
        }

        /// <summary>
        /// Mon accesseur pour ma numéro de poste.
        /// </summary>
        /// <exception cref="ArgumentException">Retourne une éxception si le noPoste est vide.</exception>
        public string NoPoste
        {
            get => noPoste;
            set
            {
                if (noPoste.Length <= 0)
                {
                    throw new ArgumentException("Le numéro de poste ne peut pas être vide.");
                }
                else
                {
                    NoPoste = value;
                }
            }
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
        /// Mon accesseur pour mon numéro de matricule.
        /// </summary>
        /// <exception cref="ArgumentException">Retourne une éxception si le numéro de matricule est vide.</exception>
        private string NoMatricule
        {
            get => noMatricule;
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Le numéro de matricule ne peut pas être vide.");
                }
                else
                {
                    noMatricule = value;
                }
            }
        }

        /// <summary>
        /// Ma fonction to string pour mon policier.
        /// </summary>
        /// <returns>Retourne un chaine de carctères représentant les propriété de mon policier.</returns>
        public override string ToString()
        {

            StringBuilder chaineCaractere = new StringBuilder();

            chaineCaractere.AppendLine(this.personne.ToString());

            chaineCaractere.AppendLine("Matricule : " + this.NoMatricule);

            chaineCaractere.AppendLine("Poste : " + this.NoPoste);

            return chaineCaractere.ToString();
        }
    }
}
