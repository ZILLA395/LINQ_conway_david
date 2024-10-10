 namespace LINQ_conway_david
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[]   
           {

             new Game("Ark", 'T', "Survival"),
             new Game("MHW", 'T', "Action hunting sim"),
             new Game("MHR", 'T', "Action hunting sim"),
             new Game("Cs:GO", 'E', "Fps"),
             new Game("Sims", 'E', "world builder"),
             new Game("Zombcube", 'E', "FPS"),
             new Game("Skyrim", 'M', "openworld"),
             new Game("Animalcrossing", 'E', "world builder"),
             new Game("Callofduty", 'T', "Fps"),
             new Game("Overwatch", 'E', "ActionFps"),
            };

            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach (var game in shortGames) 
            { 
                Console.WriteLine(game);
            }

            var ark = games.Where(game => game.Title == "Ark")
                       .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

            Console.WriteLine(ark.FirstOrDefault());

            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            Console.WriteLine("T Rated games:");
            foreach (var game in tRated)
            {
                Console.WriteLine(game);
            }

            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;


            Console.WriteLine("E Rated Action games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }

        }
    }
}