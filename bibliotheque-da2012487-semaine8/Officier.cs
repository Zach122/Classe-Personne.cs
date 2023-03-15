using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque_da2012487_semaine8
{
    public class Officier
    {
        //Mon champs
        private Personne personne;
        private string noMatricule;
        private string bataillon;
        private string grade;

        /// <summary>
        /// Mon constructeur pour ma classe officier.
        /// </summary>
        /// <param name="personne">La personne. Un objet "Personne".</param>
        /// <param name="noMatricule">Le numéro de Matricule. Un chaine de caractères.</param>
        /// <param name="bataillon">Le bataillon. Une chaine de caractères.</param>
        /// <param name="grade">Le grade. Un chaine de caractères.</param>
        /// <exception cref="ArgumentNullException">Retourne une éxception si la personne, le noMatricule, le bataillon et/ou grade est nul.</exception>
        public Officier(Personne personne, string noMatricule,string bataillon, string grade)
        {
            this.Personne = personne ?? throw new ArgumentNullException(nameof(personne));
            this.NoMatricule = noMatricule ?? throw new ArgumentNullException(nameof(NoMatricule));
            this.Bataillon = bataillon ?? throw new ArgumentNullException(nameof(Bataillon));
            this.Grade = grade ?? throw new ArgumentNullException(nameof(Grade));
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
        /// Mon accesseur pour mon bataillon.
        /// </summary>
        /// <exception cref="ArgumentException">Retourne une éxception si le bataillon est vide.</exception>
        public string Bataillon
        {
            get => bataillon;
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Le bataillon ne peut pas être vide.");
                }
                else
                {
                    Bataillon = value;
                    
                }
            }
        }

        /// <summary>
        /// Mon accesseur pour mon grade.
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
        /// Ma fonction to string pour mon officier.
        /// </summary>
        /// <returns>Retourne un chaine de carctères représentant les propriété de mon officier.</returns>
        public override string ToString()
        {

            StringBuilder chaineCaractere = new StringBuilder();

            chaineCaractere.AppendLine(this.personne.ToString());

            chaineCaractere.AppendLine("Matricule : " + this.NoMatricule);

            chaineCaractere.AppendLine("Bataillon : " + this.Bataillon);

            chaineCaractere.AppendLine("Grade : " + this.Grade);

            return chaineCaractere.ToString();
        }
    }
}
