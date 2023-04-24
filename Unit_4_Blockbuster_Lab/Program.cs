namespace Unit_4_Blockbuster_Lab
{
    internal class Program
    {
        static void Main()
        {
            Blockbuster blockbuster = new Blockbuster();
            Movie movie = blockbuster.CheckOut();

            Console.Write("Do you want to watch the movie? (y/n)");
            string prompt = Console.ReadLine();
            if (prompt.ToLower() == "y")
            {
                movie.Play();
                //movie.PlayWholeMovie();
            }
        }
    }
}