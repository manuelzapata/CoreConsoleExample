using System;
using System.Threading.Tasks;

namespace CoreConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to fetch Star Wars films");
            Console.ReadLine();

            ShowFilms().Wait();

            Console.WriteLine("\nPress any key to finish");
            Console.ReadKey();
        }

        private static async Task ShowFilms(){

            var proxy = new StarWarsProxy();
            var films = await proxy.LoadFilms();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach(var film in films) {
                Console.WriteLine($"{film.Title} - Episode {film.EpisodeNumber}");
            }

            Console.ResetColor();

        }
    }
}
