using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Entidades.Test
{
    [TestClass]
    public class AdministradorDeberia
    {
        [TestMethod]
        public void DevolverTrueSiElJugadorEstaRegistrado()
        {
            //given
            Jugador j = SqlJugador.Leer()[0];

            //when
            bool retorno = Administrador.EsJugadorExistente(j);

            //then
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void DevolverFalseSiElJugadorNoEstaRegistrado()
        {
            //given
            Jugador j = new Jugador("1234");

            //when
            bool retorno = Administrador.EsJugadorExistente(j);

            //then
            Assert.IsFalse(retorno);
        }

        [TestMethod]
        public void DevolverFalseSiElJugadorEsNull()
        {
            //given
            Jugador j = null;

            //when
            bool retorno = Administrador.EsJugadorExistente(j);

            //then
            Assert.IsFalse(retorno);
        }

        [TestMethod]
        public void DevolverJugadorCuandoRecibeNombreRegistrado()
        {
            //given
            string nombre = "Pastel";

            //when
            Jugador jugadorRetornado = Administrador.ObtenerJugadorPorNombre(nombre);

            //then
            Assert.IsNotNull(jugadorRetornado);
            Assert.IsInstanceOfType(jugadorRetornado, typeof(Jugador));
        }

        [TestMethod]
        public void DevolverNullCuandoRecibeNombreNoRegistrado()
        {
            //given
            string nombre = "1234";

            //when
            Jugador jugadorRetornado = Administrador.ObtenerJugadorPorNombre(nombre);

            //then
            Assert.IsNull(jugadorRetornado);
        }

        [TestMethod]
        public void DevolverTrueSiLosJugadoresEstanDisponiblesParaUnaPartida()
        {
            //given
            Jugador j1 = new Jugador("Lalala");
            Jugador j2 = new Jugador("Lololo");
            //when
            bool retorno = Administrador.ValidarJugadoresEstenLibresParaJugar(j1, j2);

            //then
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void DevolverFalseSiAlMenosUnoDeLosJugadoresYaSeEncuentraEnUnaPartida()
        {
            //given
            Jugador j1 = new Jugador("Lalala");
            Jugador j2 = new Jugador("Lololo");
            j2.EstaJugando = true;

            //when
            bool retorno = Administrador.ValidarJugadoresEstenLibresParaJugar(j1, j2);

            //then
            Assert.IsFalse(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LanzarExcepcionSiAlMenosUnoDeLosJugadoresEsNull()
        {
            //given
            Jugador j1 = new Jugador("Lalala");
            Jugador j2 = null;
            j1.EstaJugando = true;

            //when
            bool retorno = Administrador.ValidarJugadoresEstenLibresParaJugar(j1, j2);
        }


    }
}
