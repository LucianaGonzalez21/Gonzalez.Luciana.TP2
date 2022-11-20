namespace Entidades
{
    public class Carta
    {
        private int peso;
        private int numero;
        private string palo;

        public Carta(int peso, int numero, string palo)
        {
            this.Numero = numero;
            this.Palo = palo;
            this.Peso=peso;
        }

        public int Numero { get => numero; set => numero=value; }
        public string Palo { get => palo; set => palo=value; }
        public int Peso { get => peso; set => peso=value; }

        public static bool operator ==(Carta c1, Carta c2)
        {
            if(c1 is null || c2 is null)
            {
                return false;
            }

            return c1.Numero == c2.Numero && c1.Palo == c2.Palo;
        }

        public static bool operator !=(Carta c1, Carta c2)
        {
            return !(c1 == c2);
        }
            
    }
}