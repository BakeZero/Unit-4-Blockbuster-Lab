using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Blockbuster_Lab
{
    internal class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>();

        public Blockbuster()
        {
            Movies.Add(new DVD("Your Name", Genre.Romance, new List<string>() {"beginning of movie", "middle of movie", "end of movie"}, 112));
            Movies.Add(new DVD("Weathering With You", Genre.Romance, new List<string>() { "beginning of movie", "middle of movie", "end of movie" }, 114));
            Movies.Add(new VHS("Shrek", Genre.Comedy, new List<string>() { "shrek appears", "shrek meets donkey", "shrek meets fiona" }, 90));
            Movies.Add(new VHS("Ip Man", Genre.Action, new List<string>() { "ip man drinks tea", "ip man is challenged", "ip man beats bozo" }, 106));
            Movies.Add(new DVD("Dune", Genre.Drama, new List<string>() { "beginning of movie", "middle of movie", "end of movie" }, 155));
            Movies.Add(new DVD("Blade Runner 2049", Genre.Action, new List<string>() { "beginning of movie", "middle of movie", "end of movie" }, 163));
        }

        public void PrintMovies()
        {
            Movies = Movies.OrderBy(elem => elem.Title).ToList();
            for (int i=0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i+1}) {Movies[i].Title}");
            }
        }

        public Movie CheckOut()
        {
            Console.WriteLine("Welcome to GC Blockbuster!");
            Console.WriteLine("List of available movies:");
            PrintMovies();
            int index = Validator.GetNumberMovie(1,Movies.Count);
            Console.WriteLine();
            Movies[index - 1].PrintInfo();
            return Movies[index - 1];
        }
    }
}
