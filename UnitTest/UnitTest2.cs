using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_002;
using System.Data.Entity;

namespace Projekt_002.Tests
{

    namespace UnitTest
    {
        [TestClass]
        public class UnitTest2
        {
            #region Zusätzliche Testattribute
            //
            // Sie können beim Schreiben der Tests folgende zusätzliche Attribute verwenden:
            //
            // Verwenden Sie ClassInitialize, um vor Ausführung des ersten Tests in der Klasse Code auszuführen.
            // [ClassInitialize()]
            // public static void MyClassInitialize(TestContext testContext) { }
            //
            // Verwenden Sie ClassCleanup, um nach Ausführung aller Tests in einer Klasse Code auszuführen.
            // [ClassCleanup()]
            // public static void MyClassCleanup() { }
            //
            // Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen. 
            // [TestInitialize()]
            // public void MyTestInitialize() { }
            //
            // Mit TestCleanup können Sie nach jedem Test Code ausführen.
            // [TestCleanup()]
            // public void MyTestCleanup() { }
            //
            #endregion

            [TestMethod]
            public void TestMethodSpielAnlegen()
            {

                Spiele spiel1 = new Spiele("The Evil within 3", "Horror", 4, true, 18, 19.99);
                Spiele spiel2 = new Spiele("Fable", "rpg", 3, true, 12, 19.99);
                Spiele spiel3 = new Spiele("Dark Souls", "rpg", 10, true, 16, 19.99);
                Spiele spiel4 = new Spiele("Anno", "strategie", 5, true, 6, 19.99);
                Spiele spiel5 = new Spiele("Dragon Age", "rpg", 8, true, 18, 19.99);
                // Spiel Anlegen, um Datenbank zu erstellen(noch unvollständig)
                bool NeuesSpielAnlegen(Spiele neuesSpiel)
                {

                    //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ContextKlasse, Configuration>());
                    {
                        using (var con = new ContextKlasse())
                        {

                            try
                            {
                                con.Spiele.Add(neuesSpiel);
                                con.SaveChanges();
                            }
                            catch (Exception e)
                            {
                                return true;
                            }

                        }


                        return true;
                    }
                }



                NeuesSpielAnlegen(spiel1);
                NeuesSpielAnlegen(spiel2);
                NeuesSpielAnlegen(spiel3);
                NeuesSpielAnlegen(spiel4);
                NeuesSpielAnlegen(spiel5);




            }
            [TestMethod]
            public void TestMethodKundenAnlegen()
            {
                Kunde kunde1 = new Kunde("B1", "com", "meins", "Am Gries", "83026", "Rosenheim", "DE");
                // Spiel Anlegen, um Datenbank zu erstellen(noch unvollständig)
                bool NeuenKundenAnlegen(Kunde kundeNeu)
                {
                    {
                        using (var con1 = new ContextKlasse())
                        {
                            try
                            {
                                con1.Kunde.Add(kundeNeu);
                                con1.SaveChanges();
                            }
                            catch (Exception e)
                            {
                                return false;
                            }

                        }


                        return true;
                    }
                }



                NeuenKundenAnlegen(kunde1);


            }

            [TestMethod]
            public void TestMethodAdminAnlegen()
            {
                Admin admin1 = new Admin("ShadowSpider", "shadow@gmail.com", "spider8", "83026", "Rosenheim", "DE");
                Admin admin2 = new Admin("Explosive", "explosive@web.de", "super", "82362", "Rosenheim", "DE");
                Admin admin3 = new Admin("Operation2.0", "operation@gmx.de", "deutschland", "83533", "Rosenheim", "Germanien");
                // Spiel Anlegen, um Datenbank zu erstellen(noch unvollständig)
                bool NeuenAdminAnlegen(Admin adminNeu)
                {
                    {
                        using (var con2 = new ContextKlasse())
                        {
                            try
                            {
                                con2.Admin.Add(adminNeu);
                                con2.SaveChanges();
                            }
                            catch (Exception e)
                            {
                                return false;
                            }

                        }


                        return true;
                    }
                }

                NeuenAdminAnlegen(admin1);
                NeuenAdminAnlegen(admin2);
                NeuenAdminAnlegen(admin3);




            }
        }
    }
}
