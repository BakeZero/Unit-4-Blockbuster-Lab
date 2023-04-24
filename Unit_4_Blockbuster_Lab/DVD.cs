using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Blockbuster_Lab
{
    internal class DVD : Movie
    {
        public DVD(string Title, Genre genre, List<string> Scenes, int RunTime) : base(Title, genre, Scenes, RunTime)
        {
            this.Title = Title;
            this.Category = genre;
            this.Scenes = Scenes;
            this.RunTime = RunTime;
        }

        public override void Play()
        {
            if (Scenes.Count != 0)
            {
                do
                {
                    int index = Validator.GetNumberScene(1, Scenes.Count) - 1;
                    Console.WriteLine($"Scene {index+1}: {Scenes[index]}\n");
                } while (Continue());
            }
        }

        public override void PlayWholeMovie()
        {
            if (Scenes.Count != 0)
            { 
                for (int i = 0; i < Scenes.Count; i++)
                {
                    Console.WriteLine($"Scene {i+1}: {Scenes[i]}");
                }
            }
        }
    }
}
