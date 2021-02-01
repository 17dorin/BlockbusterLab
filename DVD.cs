using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }
        public override void Play()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Which scene would you like to watch?");
                    PrintScenes();
                    int option = int.Parse(Console.ReadLine());

                    Console.WriteLine(Scenes[option - 1]);

                    Console.WriteLine("Watch another scene?");
                    if(Console.ReadLine().Trim().ToLower() == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        public override void PlayWholeMovie()
        {
            this.PrintScenes();
        }
    }
}
