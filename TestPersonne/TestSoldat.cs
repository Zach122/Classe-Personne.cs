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
    public class TestSoldat
    {
        Personne personneValide = new Personne("doe", "John", DateTime.Now.AddYears(-1));

        //Test le constructeur à 3 paramètres valides
        [TestMethod()]
        public void SoldatConstructeurValide()
        {
            Soldat p = new Soldat(personneValide, "666666", "1", "1");
        }

        [TestMethod()]
        public void SoldatPersonneNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Soldat(null, "666666", "1", "1"));
        }

        [TestMethod()]
        public void SoldatNumeroMatriculeNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Soldat(personneValide, null, "1", "1"));
        }

        [TestMethod()]
        public void SoldatNumeroPelotonNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Soldat(personneValide, "666666", null, "1"));
        }

        [TestMethod()]
        public void SoldatGradeNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Soldat(personneValide, "666666", "1", null));
        }
    }
}
