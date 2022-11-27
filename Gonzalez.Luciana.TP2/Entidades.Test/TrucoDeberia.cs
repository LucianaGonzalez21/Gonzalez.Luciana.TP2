using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Entidades.Test
{
    [TestClass]

    public class TrucoDeberia
    {
        string rutaArchivo = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"mazoCartas.json";

        [TestMethod]
        public void RepartirCartasCorrectamente()
        {
            //given
            Truco truco = new Truco();
            Jugador j1 = new Jugador("Pepe");
            Jugador j2 = new Jugador("Juan");
            List<Carta> mazo = Serializador.Leer<List<Carta>>(rutaArchivo);

            //when
            truco.RepartirCartas(mazo, j1, j2);

            //then
            Assert.IsNotNull(j1.Cartas);
            Assert.IsNotNull(j2.Cartas);
            Assert.AreEqual(3, j1.Cartas.Count);
            Assert.AreEqual(3, j2.Cartas.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void LanzarExcepcionSiNoEncuentraLaRutaDelArchivo()
        {
            //given

            //when
            List<Carta> mazo = Serializador.Leer<List<Carta>>("");
        }

        [TestMethod]
        public void DefinirCartaGanadoraCorrectamente()
        {
            //given
            Truco truco = new Truco();
            Jugador j1 = new Jugador("Pepe");
            Jugador j2 = new Jugador("Juan");
            List<Carta> mazo = Serializador.Leer<List<Carta>>(rutaArchivo);
            Carta c1 = mazo[2];
            Carta c2 = mazo[15];

            //when
            Carta cartaGanadora = truco.DefinirCartaGanadora(c1, c2);
            Carta cartaNoGanadora = cartaGanadora == c1 ? c2 : c1;

            //then
            Assert.IsTrue(cartaGanadora.Peso > cartaNoGanadora.Peso);
        }

        [TestMethod]
        public void ContarPuntosEnvidoCorrectamente()
        {
            //given
            Truco truco = new Truco();
            Jugador j1 = new Jugador("Pepe");
            Jugador j2 = new Jugador("Juan");
            List<Carta> mazo = Serializador.Leer<List<Carta>>(rutaArchivo);
            Carta c1 = mazo[2];
            Carta c2 = mazo[5];

            //when
            int puntos = truco.ContarPuntosEnvido(c1, c2);

            //then
            Assert.IsTrue(puntos >= 20);
        }
    }
}
