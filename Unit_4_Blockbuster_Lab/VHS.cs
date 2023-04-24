using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Blockbuster_Lab
{
    internal class VHS : Movie
    {
        internal int CurrentTime;
        public VHS(string Title, Genre genre, List<string> Scenes, int RunTime) : base(Title, genre, Scenes, RunTime)
        {
            this.Title = Title;
            this.Category = genre;
            this.Scenes = Scenes;
            this.RunTime = RunTime;
            this.CurrentTime = 0;
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
        public override void Play()
        {
            do
            {
                if (Scenes.Count != 0 && CurrentTime < Scenes.Count)
                {
                    Console.WriteLine($"Scene {CurrentTime}: {Scenes[CurrentTime]}");
                    CurrentTime++;
                }
                else
                {
                    Console.WriteLine("VHS ended. Rewind to watch again.");
                    RewindPrompt:
                    Console.WriteLine("Rewind? (y/n)");
                    string prompt = Console.ReadLine();
                    if (prompt == "y")
                        Rewind();
                    else if (prompt != "n")
                        goto RewindPrompt;
                }
            } while (Continue());
        }

        public override void PlayWholeMovie()
        {
            while (CurrentTime < Scenes.Count && Scenes.Count != 0)
            {
                Console.WriteLine($"Scene {CurrentTime}: {Scenes[CurrentTime]}");
                CurrentTime++;
            }
        }
    }
}
