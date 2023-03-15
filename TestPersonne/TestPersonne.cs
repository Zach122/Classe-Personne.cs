using bibliotheque_da2012487_semaine8;

namespace TestPersonne
{
        /// <summary>
        /// Classe de test pour la classe personne.
        /// </summary>
        [TestClass()]
        public class PersonneTests
        {
            //Modifiez ce résultat en fonction de prénom : John et nom : Doe
            string nomComplet = "Doe, John";

            /******************************************************************************
                    Vous n'êtes pas authorisé à modifier le code au delà de ce point.
            *******************************************************************************/

            string prenom = "John";
            string nom = "Doe";

            Personne personneValide = new Personne("doe", "John", DateTime.Now.AddYears(-1));

            //Test le constructeur à 3 paramètres valides
            [TestMethod()]
            public void PersonneConstructeurValideTest()
            {
                Personne p = new Personne("nonvide", "nonvide", DateTime.Now.AddYears(-1));
            }
            /// <summary>
            ///  Test le constructeur à 3 paramètres avec des valeur vide
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
            /// Test le constructeur à 6 paramètres avec des valeur vide
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
            /// Test que le constructeur s'assure que la mère ne peut être être null
            /// </summary>
            [TestMethod()]
            public void MereNullTest()
            {

                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(-1), "nonvide", personneValide, null),
                            "ArgumentException non levé sur mère null");
            }


            /// <summary>
            /// test que le constructeur à 6 paramètres n'accepte pas un père null
            /// </summary>
            [TestMethod()]
            public void PereNullTest()
            {
                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(-1), "non vide", null, personneValide),
                            "ArgumentException non levé sur père null");
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
                //on recule d'une année + 1 jours
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
                //on recule d'une année + 1 jours
                Personne p = new Personne("Doe", "John", DateTime.Now.AddYears(-1));

                //la personne a exactement 1 an aujourd'hui
                Assert.AreEqual(1, p.Age, "l'age ne correspond pas");
            }


            /// <summary>
            /// Test que la date de naissance ne peut pas être dans le futur
            /// </summary>
            private void TesterDateNaissanceFuture()
            {
                Assert.ThrowsException<ArgumentException>(
                () => new Personne("non vide", "nonvide", DateTime.Now.AddDays(1)),
                "ArgumentException non levé sur date de naissance dans le futur");
            }

            /// <summary>
            /// Test que le nom ne peut pas être null.
            /// </summary>
            private static void TesterNomNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne(null, "nonvide", DateTime.Now),
                            "ArgumentNullException non levé sur nom null");
            }
            /// <summary>
            /// Test que le nom ne peut pas être vide.
            /// </summary>
            private static void TesterNomVide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("", "nonVide", DateTime.Now),
                            "ArgumentException non levé sur nom vide");
            }

            /// <summary>
            /// Test que le prénom ne peut pas être vide.
            /// </summary>
            private static void TesterPrenomVide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("nonVide", "", DateTime.Now),
                            "ArgumentException non levé sur nom vide");
            }

            private static void TesterPrenomNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne("nonvide", null, DateTime.Now),
                            "ArgumentException non levé sur prénom null");
            }

            /// <summary>
            /// Test si le prenom null leve ArgumentNullException
            /// </summary>
            private void TesterConstructeurCompletPrenomNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                    () => new Personne("nonvide", null, DateTime.Now.AddYears(-1), "nonvide", personneValide, personneValide)
                    , "ArgumentNullException non levé sur prenom null");
            }

            /// <summary>
            /// Test si le nom null leve ArgumentNullException
            /// </summary>
            private void TesterConstructeurCompletNomNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                    () => new Personne(null, "nonvide", DateTime.Now.AddYears(-1), "nonvide", personneValide, personneValide)
                    , "ArgumentNullException non levé sur prenom null");
            }

            /// <summary>
            /// Test que le nas ne peut pas être vide
            /// </summary>
            /// 
            private void TesterConstructeurCompletNASVide()
            {

                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(-1), "", personneValide, personneValide),
                            "ArgumentException non levé sur nas vide");
            }

            /// <summary>
            /// Test si un nas null leve ArgumentNullException
            /// </summary>
            private void TesterConstructeurCompletNASNull()
            {
                Assert.ThrowsException<ArgumentNullException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(-1), null, personneValide, personneValide),
                            "ArgumentNullException non levé sur nas null");
            }

            /// <summary>
            /// Test que la date de naissance invalide lève ArgumentException
            /// </summary>
            private void TesterConstructeurCompletDateNaissanceInvalide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("non vide", "non vide", DateTime.Now.AddDays(1), "nonvide", personneValide, personneValide),
                            "ArgumentException non levé sur date invalide");
            }

            /// <summary>
            /// Test que le prenom vide leve ArgumentException
            /// </summary>
            private void TesterConstructeurCompletPrenomVide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("non vide", "", DateTime.Now.AddDays(-1), "nonvide", personneValide, personneValide),
                            "ArgumentException non levé sur prénom vide");
            }

            /// <summary>
            /// Test que le nom vide lève ArgumentException
            /// </summary>
            private void TesterConstructeurCompletNomVide()
            {
                Assert.ThrowsException<ArgumentException>(
                            () => new Personne("", "non vide", DateTime.Now.AddDays(-1), "non vide", personneValide, personneValide),
                            "ArgumentException non levé sur nom vide");
            }
        }
    
}