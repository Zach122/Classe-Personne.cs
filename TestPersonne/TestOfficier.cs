using bibliotheque_da2012487_semaine8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPersonne
{
    /// <summary>
    /// Classe de test pour la classe Officier.
    /// </summary>
    [TestClass()]
    public class TestOfficier
    {
        Personne personneValide = new Personne("doe", "John", DateTime.Now.AddYears(-1));

       
        [TestMethod()]
        public void SoldatConstructeurValide()
        {
            Officier p = new Officier(personneValide, "666666", "1", "1");
        }

        [TestMethod()]
        public void OfficierPersonneNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Officier(null, "666666", "1", "1"));
        }

        [TestMethod()]
        public void OfficierNumeroMatriculeNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Officier(personneValide, null, "1", "1"));
        }

        [TestMethod()]
        public void OfficierBataillonNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Officier(personneValide, "666666", null, "1"));
        }

        [TestMethod()]
        public void OfficierGradeNul()
        {
            Assert.ThrowsException<ArgumentNullException>(
            () => new Officier(personneValide, "666666", "1", null));
        }

        [TestMethod()]
        public void OfficierNumeroMatriculeVide()
        {
            string matriculeVide = "";

            Assert.ThrowsException<ArgumentException>(
            () => new Officier(personneValide, matriculeVide, "1", "1"));
        }

        [TestMethod()]
        public void OfficierBtaillonVide()
        {
            string bataillonVide = "";

            Assert.ThrowsException<ArgumentException>(
            () => new Officier(personneValide, "666666", bataillonVide, "1"));
        }

        [TestMethod()]
        public void OfficierGradeVide()
        {
            string gradeVide = "";

            Assert.ThrowsException<ArgumentException>(
            () => new Officier(personneValide, "666666", "1", gradeVide));
        }
    }
}
