using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, Genre Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = Runtime;
            this.Scenes = Scenes;
            this.CurrentTime = 0;
        }

        public override void Play()
        {
            while(true)
            {
                if (CurrentTime < Scenes.Count)
                {
                    Console.WriteLine(Scenes[CurrentTime]);
                    CurrentTime++;

                    Console.WriteLine("Continue?");
                    if (Console.ReadLine().Trim().ToLower() == "y")
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
                else
                {
                    Console.WriteLine("You need to rewind the VHS before watching again. Rewind now? (Y/N)");
                    if (Console.ReadLine().Trim().ToLower() == "y")
                    {
                        Rewind();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wow. You're kind of a jerk");
                        Console.Clear();
                        break;
                    }
                }
            }


        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Current time: {CurrentTime}");
        }

        public override void PlayWholeMovie()
        {
            while (CurrentTime < Scenes.Count)
            {
                Console.WriteLine(Scenes[CurrentTime]);
                CurrentTime++;
            }

            Console.WriteLine("You need to rewind the VHS before watching again. Rewind now? (Y/N)");
            if (Console.ReadLine().Trim().ToLower() == "y")
            {
                Rewind();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wow. You're kind of a jerk");
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
