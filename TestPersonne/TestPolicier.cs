using bibliotheque_da2012487_semaine8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPersonne
{
    /// <summary>
    /// Classe de test pour la classe policier.
    /// </summary>
    [TestClass()]
    public class TestPolicier
    {
        Personne personneValide = new Personne("doe", "John", DateTime.Now.AddYears(-1));

        [TestMethod()]
        public void PolicierConstructeurValide()
        {
            Policier p = new Policier(personneValide, "666666", "1");
        }

        [TestMethod()]
        public void PolicierPersonneNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Policier(null, "666666", "1"));
        }

        [TestMethod()]
        public void PolicierNumeroMatriculeNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Policier(personneValide, null, "1"));
        }

        [TestMethod()]
        public void PoliciertNumeroPosteNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Policier(personneValide, "666666", null));
        }

        [TestMethod()]
        public void PolicierNumeroMatriculeVide()
        {
            string matriculeVide = "";

            Assert.ThrowsException<ArgumentException>(
            () => new Policier(personneValide, matriculeVide, "1"));
        }

        [TestMethod()]
        public void PolicierNumeroPelotonVide()
        {
            string posteVide = "";

            Assert.ThrowsException<ArgumentException>(
            () => new Policier(personneValide, "666666", posteVide));
        }
    }
}

