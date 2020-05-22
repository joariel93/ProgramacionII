using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System.Runtime.CompilerServices;

namespace TestUnitarioCentralita
{
    [TestClass]
    public class Ejercicio44a

    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange

            Centralita centralitaTest;

            // act

            centralitaTest = new Centralita() ;

            // assert

            Assert.IsNotNull(centralitaTest.Llamadas);
        }

        
    }
}
