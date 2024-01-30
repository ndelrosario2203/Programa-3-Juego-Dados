using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_3_Juego_Dados
{
    internal class JuegoDados
    {
        Random rnd = new Random();

        List<Dado> dados = new List<Dado>();

        public void iniciarJuego(int caraDados) {

            for (int i = 0; i < 3; i++)
            {
                dados.Add(new Dado { CaraDado = rnd.Next(1, caraDados + 1) });
            }

            foreach (Dado dado in dados) {
                Console.WriteLine("Se lanzó el dado, el número es: " + dado.CaraDado);            
            }

            if (dados.Any(x => x.CaraDado != dados[0].CaraDado))
            {
                Console.WriteLine("Perdiste el juego, los dados no son iguales.");

            }
            else {
                Console.WriteLine("Ganaste, los dados son iguales.");
            }
            
        }
    }
}
