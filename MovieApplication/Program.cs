using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    public class Program
    {
        static List<Movie> movies = new List<Movie>();

        public static void DeleteMovie()
        {
            Console.WriteLine("Enter a Movie Name");
            var nameDel = Console.ReadLine();
            foreach (var movie in movies.FindAll(x => x.MovieName.Contains(nameDel)))
            {
                movies.Remove(movie);
            }
            Console.WriteLine("Movie is deleted");
            foreach (var m in movies)
                Console.WriteLine(m.MovieName);
        }

public static void UpdateMovie()
  {
            Console.WriteLine("Enter a Movie Name");
            var name = Console.ReadLine();
            Console.WriteLine("Update a Movie");
            var nameUpd = Console.ReadLine();
            foreach (var m in movies)
            {
                if (m.MovieName == name)
                    m.MovieName = nameUpd;
            }
            foreach (var m in movies)
                Console.WriteLine(m.MovieName);
        }



public static void DisplayMovies()
        {
            int count = 1;
            foreach (var movie in movies)
            {
                Console.WriteLine(count);
                Console.WriteLine("Movie Name: {0}, Actor: {1}, Genre: {2}, Director: {3}", movie.MovieName, movie.MainActor, movie.Genre, movie.Director);
                count++;
            }
        }


        static void Main(string[] args)
        {
            

            movies.Add(new Movie("Taken3", "Liam Neeson", "Action", "Oliver Megaton"));
            movies.Add(new Movie("Titanic", "Leonardo DiCaprio", "Romance", "James Cameron"));
            movies.Add(new Movie("The Boy Next Door","Jennifer Lopez","Thriller","Rob Cohen"));
            movies.Add(new Movie("Avatar","Sam Worthington","Science Fiction","James Cameron"));
            movies.Add(new Movie("Gravity","Sandra Bullock","Science Fiction","Alfonso Cuaron"));
            movies.Add(new Movie("Air Force One","Harrison Ford","Thriller","Wolfgang Peterson"));
            movies.Add(new Movie("I Am Legend","Will Smith","Science Fiction","Francis Lawrence"));
            movies.Add(new Movie("Behind Enemy Lines","Owen Wilson","Action","John Moore"));
            movies.Add(new Movie("The Jungle Book","Bill Murray","Fantasy Adventure","Jon Favreau"));
            movies.Add(new Movie("Ocean's13","Brad Pitt","Action","Steven Soderbergh"));
            movies.Add(new Movie("Gladiator", "Russel Crowe", "Drama", "Ridley Scott"));
            movies.Add(new Movie("The Next Three Days", "Russel Crowe", "Thriller", "Paul Haggis"));

            var rf = movies[0].MainActor;


            //foreach (var movie in movies)
            //    Console.WriteLine(movie.MovieName);


            Console.WriteLine("Choose an Option from the following List");
            Console.WriteLine("\tmovie - Find a Movie");
            Console.WriteLine("\tactor - Find Movie By Actor");
            Console.WriteLine("\tdirector - Find Movie By Director");
            Console.WriteLine("\tadd - Add a Movie");
            Console.WriteLine("\tupdate - Update a Movie");
            Console.WriteLine("\tdisplay - Display All Movies");
            Console.WriteLine("\tquit - Quit Program");
            Console.WriteLine("Your Option?");

            switch (Console.ReadLine())
            {
                case "movie":
                    SearchMovie();
                    break;
                case "actor":
                    Console.WriteLine("Enter Actor Name");
                    var actor = Console.ReadLine();
                    foreach (var movie in movies.FindAll(x => x.MainActor.Contains(actor)))
                    {
                        Console.WriteLine("List of Movies by Actor: {0} ", movie.MovieName);
                    }
                    break;
                case "director":
                    Console.WriteLine("Enter Director Name");
                    var director = Console.ReadLine();
                    foreach (var movie in movies.FindAll(x => x.Director.Contains(director)))
                    {
                        Console.WriteLine("List of Movies by Director: {0} ", movie.MovieName);
                    }
                    break;
                case "add":
                    AddMovie();
                    break;
                case "quit":
                    return ;
                default:
                    Console.WriteLine("This is an incorrect option entry. Please Re-try!");
                    break;
                case "delete":

                    DeleteMovie();

                    break;

                case "update":

                    UpdateMovie();

                    break;

                case "display":

                    DisplayMovies();

                    break;

            }
            
        }
        public static void SearchMovie()
        {
            Console.WriteLine("Enter Movie Name");
            var mName = Console.ReadLine();
            foreach (var movie in movies.FindAll(x => x.MovieName.Contains(mName)))
            {
                Console.WriteLine("Movie Name: {0} ", movie.MovieName);
                Console.WriteLine("Main Actor: {0} ", movie.MainActor);
                Console.WriteLine("Movie Genre: {0} ", movie.Genre);
                Console.WriteLine("Director Name: {0} ", movie.Director);
            }
        }
        public static void AddMovie()
        {
            Console.WriteLine("Enter a Movie Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter a Main Actor");
            var actor = Console.ReadLine();
            Console.WriteLine("Enter a Movie Genre");
            var genre = Console.ReadLine();
            Console.WriteLine("Enter a Director Name");
            var director = Console.ReadLine();
            Movie movie = new Movie(name, actor, genre, director);
            movies.Add(movie);
            Console.WriteLine("Movie is Added into the list");
            foreach (var m in movies)
                Console.WriteLine(m.MovieName);
        }

    }
}
