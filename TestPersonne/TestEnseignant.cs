using bibliotheque_da2012487_semaine8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPersonne
{
    /// <summary>
    /// Classe de test pour la classe soldat.
    /// </summary>
    [TestClass()]
    public class TestEnseignant
    {
        Personne personneValide = new Personne("doe", "John", DateTime.Now.AddYears(-1));

        [TestMethod()]
        public void EnseignantConstructeurValide()
        {
            Enseignant p = new Enseignant(personneValide, "666666", 0.1);
        }

        [TestMethod()]
        public void EnseignantPersonneNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Enseignant(null, "666666", 0.1));
        }

        [TestMethod()]
        public void EnseignanNumeroEmployeNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Enseignant(personneValide, null, 0.1));
        }


        [TestMethod()]
        public void EnseignanNumeroEmployeVide()
        {
            string numeroEmployeVide = "";

            Assert.ThrowsException<ArgumentException>(
            () => new Enseignant(personneValide, numeroEmployeVide, 0.1));
        }

        [TestMethod()]
        public void SoldatNumeroPelotonVide()
        {
            

            Assert.ThrowsException<ArgumentException>(
            () => new Enseignant(personneValide, "666666", 0));
        }

    }
}
