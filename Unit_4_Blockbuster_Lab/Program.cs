namespace Unit_4_Blockbuster_Lab
{
    internal class Program
    {
        static void Main()
        {
            Blockbuster blockbuster = new Blockbuster();
            Movie movie = blockbuster.CheckOut();
            movie.Play();
            //movie.PlayWholeMovie();
        }
    }
}