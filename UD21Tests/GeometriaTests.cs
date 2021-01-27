using Microsoft.VisualStudio.TestTools.UnitTesting;
using UD21;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD21
{
    [TestClass()]
    public class GeometriaTests
    {
        Geometria G = new Geometria();
        [TestMethod()]
        public void areacuadradoTest()
        {
            int resultat = G.areacuadrado(2);
            Assert.AreEqual(4, resultat);
        }

        [TestMethod()]
        public void areaCirculoTest()
        {
            double resultat = G.areaCirculo(2);
            Assert.AreEqual(Math.PI * Math.Pow(2, 2), resultat);
        }

        [TestMethod()]
        public void areatrianguloTest()
        {
            int resultat = G.areatriangulo(2,4);
            Assert.AreEqual((2 * 4) / 2, resultat);
        }

        [TestMethod()]
        public void arearectanguloTest()
        {
            int resultat = G.arearectangulo(2, 4);
            Assert.AreEqual(2 * 4, resultat);
        }

        [TestMethod()]
        public void areapentagonoTest()
        {
            int resultat = G.areapentagono(2, 6);
            Assert.AreEqual((2 * 6) / 2, resultat);
        }

        [TestMethod()]
        public void arearomboTest()
        {
            int resultat = G.arearombo(2, 8);
            Assert.AreEqual((2 * 8) / 2, resultat);
        }

        [TestMethod()]
        public void arearomboideTest()
        {
            int resultat = G.arearomboide(2, 4);
            Assert.AreEqual(2 * 4, resultat);
        }

        [TestMethod()]
        public void areatrapecioTest()
        {
            int resultat = G.areatrapecio(2, 4, 6);
            Assert.AreEqual(((2 + 4) / 2) * 6, resultat);
        }
    }
}