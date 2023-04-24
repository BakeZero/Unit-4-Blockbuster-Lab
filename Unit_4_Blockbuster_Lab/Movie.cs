using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Blockbuster_Lab
{
    internal abstract class Movie
    {
        internal string Title { get; set; }
        internal Genre Category { get; set; }
        internal int RunTime { get; set; }
        internal List<string> Scenes { get; set; }

        public Movie(string Title, Genre genre, List<string> Scenes, int RunTime)
        {
            this.Title = Title;
            this.Category = genre;
            this.Scenes = Scenes;
            this.RunTime = RunTime;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(Title);
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("Runtime: " + RunTime);
        }

        public virtual void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }

        internal virtual bool Continue()
        {
            Console.Write("Watch another scene? (y/n): ");
            string prompt = Console.ReadLine();
            if (prompt.ToLower() == "y")
            {
                return true;
            }
            else if (prompt.ToLower() == "n")
            {
                return false;
            }
            else
                return Continue();
        }
        public abstract void Play();
        public abstract void PlayWholeMovie();
    }
}
