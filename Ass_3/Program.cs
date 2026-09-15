namespace Ass_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st answer
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion

            #region 2st answer
            int[,] shelfCopies =
            {
                {3,5 },
                {1,4 }
            };
            for (int i = 0; i < shelfCopies.GetLength(0); i++)
            {
                for (int j = 0; j < shelfCopies.GetLength(1); j++)
                {
                    Console.Write($"{shelfCopies[i, j]}  ");
                }
                Console.WriteLine();
            }
            #endregion

            #region 3st answer
            PrintWelcomeMessage();
            #endregion
        }
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

    }
}
