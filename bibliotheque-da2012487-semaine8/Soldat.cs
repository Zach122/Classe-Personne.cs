using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque_da2012487_semaine8
{
    public class Soldat
    {
        //Mon champs
        private Personne personne;
        private string noMatricule;
        private string noPeloton;
        private string grade;

        /// <summary>
        /// Mon constructeur pour ma classe Soldat.
        /// </summary>
        /// <param name="personne">La personne. Un objet "Personne".</param>
        /// <param name="noMatricule">Le numéro de matricule. Une chaine de caractères.</param>
        /// <param name="noPeloton">Le numéro de peloton. Une chaine de caractères.</param>
        /// <param name="grade">Le grade. Une chaine de caractères.</param>
        /// <exception cref="ArgumentNullException">Retourne une éxception si la personne, le noMatricule, le noPeloton et/ou le grade est nul.</exception>
        public Soldat(Personne personne, string noMatricule, string noPeloton, string grade)
        {
            this.personne = personne ?? throw new ArgumentNullException(nameof(personne));
            this.NoMatricule = noMatricule ?? throw new ArgumentNullException(nameof(NoMatricule));
            this.NoPeloton = noPeloton ?? throw new ArgumentNullException(nameof(NoPeloton));
            this.Grade = grade ?? throw new ArgumentNullException(nameof(NoPeloton));
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
        /// Mon accesseur pour mon numéro de peloton.
        /// </summary>
        /// <exception cref="ArgumentException">Retourne une éxception si le numéro de peloton est vide.</exception>
        public string NoPeloton
        {
            get => noPeloton;
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Le numéro de peloton ne peut pas être vide.");
                }
                else
                {
                    NoPeloton = value;
                }
            }
        }

        /// <summary>
        /// Mon accesseurpour mon grade.
        /// </summary>
        /// <exception cref="ArgumentException">Retourne une éxception si le grade est vide.</exception>
        private string Grade
        {
            get => grade;
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Le grade ne peut pas être vide.");
                }
                else 
                {
                    Grade = value;
                }
            }
        }

        /// <summary>
        /// Mon accesseur pour mon DA.
        /// </summary>
        /// <exception cref="ArgumentException">Retourne une éxception si le DA est vide.</exception>
        private string NoMatricule
        {
            get => noMatricule;
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException(nameof(noMatricule));
                }
                else
                {
                    noMatricule = value;
                }
            }
        }

        /// <summary>
        /// Ma fonction to string pour mon soldat.
        /// </summary>
        /// <returns>Retourne un chaine de carctères représentant les propriété de mon soldat.</returns>
        public override string ToString()
        {

            StringBuilder chaineCaractere = new StringBuilder();

            chaineCaractere.AppendLine(this.personne.ToString());

            chaineCaractere.AppendLine("Matricule : " + this.NoMatricule);

            chaineCaractere.AppendLine("Peloton : " + this.NoPeloton);

            chaineCaractere.AppendLine("Grade : " + this.Grade);

            return chaineCaractere.ToString();
        }
    }
}
