using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sala
    {
        int idSala;
        Jugador j1;
        Jugador j2;
        List<Carta> mazo;

        public Sala(Jugador j1, Jugador j2)
        {
            this.J1 = j1;
            this.J2 = j2;
        }

        public Sala(int id, Jugador j1, Jugador j2): this(j1, j2)
        {
            this.IdSala = id;
        }

        public Sala(Jugador j1, Jugador j2, List<Carta> mazo): this(j1, j2)
        {
            this.Mazo=mazo;
        }

        public Jugador J1 { get => j1; set => j1=value; }
        public Jugador J2 { get => j2; set => j2=value; }
        public List<Carta> Mazo { get => mazo; set => mazo=value; }
        public string NombreJ1 { get => J1.Nombre; }
        public string NombreJ2 { get => J2.Nombre; }
        public int IdSala { get => idSala; set => idSala=value; }
    }
}
