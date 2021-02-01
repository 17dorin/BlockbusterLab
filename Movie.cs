using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
    enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }


        public abstract void Play();

        public abstract void PlayWholeMovie();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genre: {Category}");
            Console.WriteLine($"Runtime: {RunTime}");
        }

        public void PrintScenes()
        {
            foreach(string scene in Scenes)
            {
                Console.WriteLine($"{Scenes.IndexOf(scene) + 1}: {scene}");
            }
        }
    }
}
