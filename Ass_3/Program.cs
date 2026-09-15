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

            #region 4st answer
            PrintBookTitle("Clean Code");
            #endregion

            #region 5st answer
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages); // 400
                                      // print 400 ==> because passing by value type
            #endregion

            #region 6st answer
            double[] prices_2 = { 25.5, 40.0 };
            ApplyDiscount(prices_2);
            Console.WriteLine(prices_2[0]); // 20.5
            // print 20.5 ==> passing by Ref type 
            #endregion
        }
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        public static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
    }
}
