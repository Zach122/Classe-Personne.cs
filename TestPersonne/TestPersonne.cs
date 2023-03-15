using bibliotheque_da2012487_semaine8;

namespace TestPersonne
{
        /// <summary>
        /// Classe de test pour la classe personne.
        /// </summary>
        [TestClass()]
        public class PersonneTests
        {
            //Modifiez ce r�sultat en fonction de pr�nom : John et nom : Doe
            string nomComplet = "Doe, John";

            /******************************************************************************
                    Vous n'�tes pas authoris� � modifier le code au del� de ce point.
            *******************************************************************************/

            string prenom = "John";
            string nom = "Doe";

            Personne personneValide = new Personne("doe", "John", DateTime.Now.AddYears(-1));

            //Test le constructeur � 3 param�tres valides
            [TestMethod()]
            public void PersonneConstructeurValideTest()
            {
                Personne p = new Personne("nonvide", "nonvide", DateTime.Now.AddYears(-1));
            }
            /// <summary>
            ///  Test le constructeur � 3 param�tres avec des valeur vide
            /// </summary>

            [TestMethod()]
            public void PersonneConstructeurValideVideTest()
            {
                new Personne("nonvide", "nonvide", DateTime.Now.AddYears(-1), "nonVide", personneValide, personneValide);
            }

            /// <summary>
            /// Test que le nom complet est valide
            /// </summary>
            [TestMethod()]
            public void PersonneNomCompletConstructeurCompletTest()
            {
                Personne p = new Personne(nom, prenom, DateTime.Now.AddYears(-1), "nonVide", personneValide, personneValide);
                Assert.AreEqual(nomComplet, p.NomComplet);
            }

            /// <summary>
            /// Test chacun des champs nullable
            /// /// </summary>
            [TestMethod()]
            public void PersonneConstructeurCompletChampsNullTest()
            {
                TesterConstructeurCompletNomNull();
                TesterConstructeurCompletPrenomNull();
                TesterConstructeurCompletNASNull();
            }

            /// <summary>
            /// Test le constructeur � 6 param�tres avec des valeur vide
            /// </summary>
            [TestMethod()]
            public void PersonneConstructeurCompletChampsVideTest()
            {
                TesterConstructeurCompletNomVide();
                TesterConstructeurCompletPrenomVide();
                TesterConstructeurCompletDateNaissanceInvalide();
                TesterConstructeurCompletNASVide();
            }

            /// <summary>
            /// Test que le constructeur s'assure que la m�re ne peut �tre �tre null
            /// </summary>
            [TestMethod()]
            public void MereNullTest()
            {

                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(-1), "nonvide", personneValide, null),
                            "ArgumentException non lev� sur m�re null");
            }


            /// <summary>
            /// test que le constructeur � 6 param�tres n'accepte pas un p�re null
            /// </summary>
            [TestMethod()]
            public void PereNullTest()
            {
                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(-1), "non vide", null, personneValide),
                            "ArgumentException non lev� sur p�re null");
            }

            /// <summary>
            /// Test la construction d'une personne avec une date de naissance dans le futur.
            /// </summary>
            [TestMethod()]
            public void PersonneConstructeurDateNaissanceFutureTest()
            {
                TesterDateNaissanceFuture();
            }

            /// <summary>
            /// test que l'age est la bonne.
            /// </summary>
            [TestMethod()]
            public void AgeCorrectementCalculeeTest()
            {
                int age = 5;
                Personne p = new Personne("Doe", "John", DateTime.Now.AddYears(-age));

                Assert.AreEqual(age, p.Age, "l'age ne correspond pas");
            }

            /// <summary>
            /// test que l'age est la bonne.
            /// </summary>
            [TestMethod()]
            public void AgeDateAnniversaireFutureTest()
            {
                //on recule d'une ann�e + 1 jours
                Personne p = new Personne("Doe", "John", DateTime.Now.AddYears(-1).AddDays(1));

                //la personne n'a pas encore 1 an.
                Assert.AreEqual(0, p.Age, "l'age ne correspond pas");
            }

            /// <summary>
            /// test que l'age est la bonne.
            /// </summary>
            [TestMethod()]
            public void AgeDateAnniversaireTest()
            {
                //on recule d'une ann�e + 1 jours
                Personne p = new Personne("Doe", "John", DateTime.Now.AddYears(-1));

                //la personne a exactement 1 an aujourd'hui
                Assert.AreEqual(1, p.Age, "l'age ne correspond pas");
            }


            /// <summary>
            /// Test que la date de naissance ne peut pas �tre dans le futur
            /// </summary>
            private void TesterDateNaissanceFuture()
            {
                Assert.ThrowsException<ArgumentException>(
                () => new Personne("non vide", "nonvide", DateTime.Now.AddDays(1)),
                "ArgumentException non lev� sur date de naissance dans le futur");
            }

            /// <summary>
            /// Test que le nom ne peut pas �tre null.
            /// </summary>
            private static void TesterNomNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne(null, "nonvide", DateTime.Now),
                            "ArgumentNullException non lev� sur nom null");
            }
            /// <summary>
            /// Test que le nom ne peut pas �tre vide.
            /// </summary>
            private static void TesterNomVide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("", "nonVide", DateTime.Now),
                            "ArgumentException non lev� sur nom vide");
            }

            /// <summary>
            /// Test que le pr�nom ne peut pas �tre vide.
            /// </summary>
            private static void TesterPrenomVide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("nonVide", "", DateTime.Now),
                            "ArgumentException non lev� sur nom vide");
            }

            private static void TesterPrenomNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne("nonvide", null, DateTime.Now),
                            "ArgumentException non lev� sur pr�nom null");
            }

            /// <summary>
            /// Test si le prenom null leve ArgumentNullException
            /// </summary>
            private void TesterConstructeurCompletPrenomNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                    () => new Personne("nonvide", null, DateTime.Now.AddYears(-1), "nonvide", personneValide, personneValide)
                    , "ArgumentNullException non lev� sur prenom null");
            }

            /// <summary>
            /// Test si le nom null leve ArgumentNullException
            /// </summary>
            private void TesterConstructeurCompletNomNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                    () => new Personne(null, "nonvide", DateTime.Now.AddYears(-1), "nonvide", personneValide, personneValide)
                    , "ArgumentNullException non lev� sur prenom null");
            }

            /// <summary>
            /// Test que le nas ne peut pas �tre vide
            /// </summary>
            /// 
            private void TesterConstructeurCompletNASVide()
            {

                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(-1), "", personneValide, personneValide),
                            "ArgumentException non lev� sur nas vide");
            }

            /// <summary>
            /// Test si un nas null leve ArgumentNullException
            /// </summary>
            private void TesterConstructeurCompletNASNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(-1), null, personneValide, personneValide),
                            "ArgumentNullException non lev� sur nas null");
            }

            /// <summary>
            /// Test que la date de naissance invalide l�ve ArgumentException
            /// </summary>
            private void TesterConstructeurCompletDateNaissanceInvalide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(1), "nonvide", personneValide, personneValide),
                            "ArgumentException non lev� sur date invalide");
            }

            /// <summary>
            /// Test que le prenom vide leve ArgumentException
            /// </summary>
            private void TesterConstructeurCompletPrenomVide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("non vide", "", DateTime.Now.AddDays(-1), "nonvide", personneValide, personneValide),
                            "ArgumentException non lev� sur pr�nom vide");
            }

            /// <summary>
            /// Test que le nom vide l�ve ArgumentException
            /// </summary>
            private void TesterConstructeurCompletNomVide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("", "non vide", DateTime.Now.AddDays(-1), "non vide", personneValide, personneValide),
                            "ArgumentException non lev� sur nom vide");
            }
        }
    
}