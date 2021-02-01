using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            List<string> scenes = new List<string> { "This is scene 1", "This is scene 2", "This is scene 3", "This is scene 4" };
            
            DVD shrek = new DVD("Shrek", Genre.Comedy, 120, scenes);
            DVD akira = new DVD("Akira", Genre.Action, 120, scenes);
            DVD exorcist = new DVD("The Exorcist", Genre.Horror, 150, scenes);
            VHS hollywoodCop = new VHS("Hollywood Cop", Genre.Action, 180, scenes);
            VHS nightmare = new VHS("Nightmare on Elm Street", Genre.Horror, 90, scenes);
            VHS towerOfTerror = new VHS("Tower of Terror", Genre.Drama, 150, scenes);

            this.Movies = new List<Movie> { shrek, akira, exorcist, hollywoodCop, nightmare, towerOfTerror };
        }

        public void PrintMovies()
        {
            foreach(Movie movie in Movies)
            {
                Console.WriteLine($"{Movies.IndexOf(movie) + 1}: {movie.Title}");
            }
        }

        public Movie CheckOut()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Which movie do you want to watch?");
                    PrintMovies();
                    int option = int.Parse(Console.ReadLine());

                    if (option >= 1 && option <= Movies.Count)
                    {
                        foreach(Movie movie in Movies)
                        {
                            if(option == Movies.IndexOf(movie) + 1)
                            {
                                return movie;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Please enter an option that was given");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }



        }
    }
}
