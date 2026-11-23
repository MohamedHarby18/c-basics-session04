
using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        double[] prices = { 25.5, 40.0, 33.75 };
        Console.WriteLine(prices[1]);
        //.................................//

        int[,] shelfCopies =
        {
            { 3, 5 },
            { 1, 4 }
        };

        Console.WriteLine(shelfCopies[1, 0]);
        //.................................//

        PrintWelcomeMessage();
        //.................................//

        PrintBookTitle("Clean Code");
        //.................................//

        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages);
        //.................................//

        double[] bookPrices = { 25.5, 40.0 };
        ApplyDiscount(bookPrices);
        Console.WriteLine(bookPrices[0]);

        // Expected output: 20.5
        // Because arrays are reference types, the method modifies
        // the original array through its reference.
        //.................................//

        int bonusPages = 400;
        AddBonusPagesByRef(ref bonusPages);
        Console.WriteLine(bonusPages);
        //.................................//

        double[] newPrices = { 25.5, 40.0 };
        ReplaceArray(ref newPrices);
        Console.WriteLine(newPrices.Length);
        //.................................//

        double price;
        bool isFound = TryGetPrice("Clean Code", out price);
        if (isFound)
            Console.WriteLine("Price: " + price);
        else
            Console.WriteLine("Book not found");
        //.................................//

        PrintBookInfo("Clean Code");
        PrintBookInfo("Refactoring", 450);
        //.................................//

        PrintBookInfo(pages: 500, title: "The Pragmatic Programmer");
        //.................................//

        PrintAllTitles(
            "Clean Code",
            "The Pragmatic Programmer",
            "Refactoring"
        );
        //.................................//
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
        prices = new double[] { 10.0, 12.5, 15.0 };
    }

    public static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
        {
            price = 25.5;
            return true;
        }

        price = 0;
        return false;
    }

    public static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Book: {title}, Pages: {pages}");
    }

    public static void PrintAllTitles(params string[] titles)
    {
        foreach (string title in titles)
        {
            Console.WriteLine(title);
        }
    }
}
