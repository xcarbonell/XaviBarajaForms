using System;
using System.Collections.Generic;
using System.Linq;

namespace XaviBarajaForms
{
    public class Baraja
    {
        public List<Carta> baraja = new List<Carta>();
        public Carta card;

        public Baraja()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Carta card = new Carta(j + 1, i);
                    baraja.Add(card);
                }
            }
        }

        public int NumeroCartas()
        {
            return baraja.Count;
        }

        public Carta RobaCarta()
        {
            int numero = baraja[0].getNumero();
            int palo = baraja[0].getPalo();
            baraja.RemoveAt(0);
            Carta c = new Carta(numero, palo);
            return c;
        }

        public Carta CogeCarta(int n)
        {
            int numero = baraja[n].getNumero();
            int palo = baraja[n].getPalo();
            baraja.RemoveAt(n);
            Carta c = new Carta(numero, palo);
            return c;
        }

        public Carta CogeCartaAlAzar()
        {
            Random rand = new Random();
            int n = rand.Next(0, baraja.Count - 1);
            int numero = baraja[n].getNumero();
            int palo = baraja[n].getPalo();
            baraja.RemoveAt(n);
            Carta c = new Carta(numero, palo);
            return c;
        }

        public void ToString()
        {
            for (int i = 0; i < baraja.Count; i++)
            {
                Console.WriteLine("Carta: " + baraja[i].ToString());
            }
        }

        public List<Carta> Barajar()
        {
            var rnd = new Random();
            var randomized = baraja.OrderBy(item => rnd.Next());
            List<Carta> barajado = new List<Carta>();
            baraja = barajado;
            foreach (var carta in randomized)
            {
                barajado.Add(carta);
            }
            return barajado;
        }

        public List<Carta> ResetearBaraja()
        {
            List<Carta> baraja2 = new List<Carta>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Carta card = new Carta(j + 1, i);
                    baraja2.Add(card);
                }
            }
            baraja = baraja2;
            return baraja;
        }
    }
}
