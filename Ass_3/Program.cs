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

            #region 7st answer
            int pages_1 = 400;
            AddBonusPagesByRef(ref pages_1);
            Console.WriteLine(pages_1); // 450
            // passing by ref - value type 
            #endregion

            #region 8st answer
            double[] prices_3 = { 25.5, 40.0 ,19};
            ReplaceArray(ref prices_3);
            for (int i = 0; i < prices_3.Length; i++)
            {
                Console.WriteLine(prices_3[i]);
            }
            #endregion

            #region 9st answer
            string? title = Console.ReadLine();
            double price;
            if (title != null)
            {
                TryGetPrice(title, out price);
                Console.WriteLine(price);
            }

            #endregion
            #region 10st answer
            PrintBookInfo("C#");
            PrintBookInfo("C#" , 555);
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

        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        public static void ReplaceArray(ref double[] prices)
        {
            double[] array = { 10.0, 12.5, 15.0 };
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = array[i];
            }
        }

        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
                
        }

        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"title: {title} - pages = {pages}");
        }
    }
}
