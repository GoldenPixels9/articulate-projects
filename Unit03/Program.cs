using Unit03.Game;


namespace Unit03
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Director director = new Director(); //creates an instance of the director class
            director.StartGame(); //director instance uses the start game function
        }
    }
}