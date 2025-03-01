// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main()
    {
        int sodaStock = 100, sodaRestock = 40;
        int chipsStock = 40, chipsRestock = 20;
        int candyStock = 60, candyRestock = 40;

        //Display initial stock
        Console.WriteLine($"Initial Stock Levels:");
        Console.WriteLine($"Soda: {sodaStock}");
        Console.WriteLine($"Chips: {chipsStock}");
        Console.WriteLine($"Candy: {candyStock}");
        
        sodaStock = AdjustStock("soda", sodaStock);
        chipsStock = AdjustStock("chips", chipsStock);
        candyStock = AdjustStock("candy", candyStock);
        
        Console.WriteLine("\nRestock Alerts:");
        if (sodaStock <= sodaRestock) Console.WriteLine("⚠️ Soda needs to be restocked!");
        if (chipsStock <= chipsRestock) Console.WriteLine("⚠️ Chips need to be restocked!");
        if (candyStock <= candyRestock) Console.WriteLine("⚠️ Candy needs to be restocked!");
    }
    
    public static int AdjustStock(string itemName, int currentStock)
    {
        Console.Write($"\nHow many {itemName}s have been sold today? Current stock: {currentStock}: ");
        int sold = int.Parse(Console.ReadLine());

        if (sold > currentStock)
        {
            Console.WriteLine("❌ Too high! Cannot sell more than available stock.");
        }
        else
        {
            currentStock -= sold;
        }

        //Display updated stock after each input
        Console.WriteLine($"Remaining {itemName} stock: {currentStock}");

        return currentStock;
    }
}
