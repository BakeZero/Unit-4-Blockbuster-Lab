namespace Unit_4_Blockbuster_Lab
{
    internal class Program
    {
        static void Main()
        {
            Blockbuster blockbuster = new Blockbuster();
            Movie movie = blockbuster.CheckOut();

            MoviePrompt:
            Console.Write("Do you want to watch the movie? (y/n): ");
            string prompt = Console.ReadLine();
            if (prompt.ToLower() == "y")
            {
                movie.Play();
                //movie.PlayWholeMovie();
            }
            else if (prompt.ToLower() != "n")
                goto MoviePrompt;

            Console.WriteLine("Bye!");
        }
    }
}