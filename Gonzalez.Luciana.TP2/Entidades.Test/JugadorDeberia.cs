using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entidades.Test
{
    [TestClass]
    public class JugadorDeberia
    {
        [TestMethod]
        public void ResponderJugadaConBool()
        {
            //given
            Jugador j = new Jugador("Pepe");

            //when
            bool respuesta = j.ResponderJugada();

            //then
            Assert.IsInstanceOfType(respuesta, typeof(bool));
        }


    }
}
