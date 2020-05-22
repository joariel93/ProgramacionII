using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestUnitarioCentralita
{
    [TestClass]
    public class Ejercicio44d
    {
        [TestMethod]
        
        public void TestMethod1()
        {

            // arrange

            Centralita centralitaTest = new Centralita();

            // act

            centralitaTest += new Local("123", 5.2f, "321", 5.2f);
            centralitaTest += new Provincial("123", 0, 5.2f, "321");
            try 
            {
            centralitaTest += new Local("123", 5.2f, "321", 5.2f);
            centralitaTest += new Provincial("123", 0, 5.2f, "321");
            }
            catch (CentralitaException)
            {

            }

            // assert

            Assert.AreNotEqual(centralitaTest.Llamadas[0],centralitaTest.Llamadas[1]);
        }
    }
}
