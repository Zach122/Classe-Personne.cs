﻿using bibliotheque_da2012487_semaine8;
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

        [TestMethod()]
        public void SoldatNumeroMatriculeVide()
        {
            string matriculeVide = "";

            Assert.ThrowsException<ArgumentException>(
            () => new Soldat(personneValide, matriculeVide, "1", "1"));
        }

        [TestMethod()]
        public void SoldatNumeroPelotonVide()
        {
            string pelotoneVide = "";

            Assert.ThrowsException<ArgumentException>(
            () => new Soldat(personneValide, "666666", pelotoneVide, "1"));
        }

        [TestMethod()]
        public void SoldatGradeVide()
        {
            string gradeVide = "";

            Assert.ThrowsException<ArgumentException>(
            () => new Soldat(personneValide, "666666", "1", gradeVide));
        }
    }
}
