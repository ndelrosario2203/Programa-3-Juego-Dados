
using Programa_3_Juego_Dados;

public class Program { 

    public static void Main(string[] args)
    {

        Console.WriteLine("Introduce la cantidad de caras de los dados.");

        int caraDados = int.Parse(Console.ReadLine());

        JuegoDados juegoDados = new JuegoDados();

        juegoDados.iniciarJuego(caraDados);

    }



}
