using System;
using CentralitaHerencia;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarioCentralita
{
    [TestClass]
    
    public class Ejercicio44c
    {
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestMethod1()
        {
            // arrange

            Centralita centralitaTest = new Centralita();

            // act

            centralitaTest += new Provincial("123",0,5.2f,"321");
            centralitaTest += new Provincial("123", 0, 5.2f, "321");

        }
    }
}
