using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestUnitarioCentralita
{
    [TestClass]
    public class Ejercicio44b
    {
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestMethod1()
        {
            
                // arrange

                Centralita centralitaTest = new Centralita();

                // act

                centralitaTest += new Local("123", 5.2f, "321", 5.2f);
                centralitaTest += new Local("123", 5.2f, "321", 5.2f);
               
            
        }
    }
}
