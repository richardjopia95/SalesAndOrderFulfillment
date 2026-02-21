using System;
using System.Diagnostics.Metrics;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=========================");
        Console.WriteLine("        GROCERY         ");
        Console.WriteLine("Sales / Order Fulfillment");
        Console.WriteLine("=========================");

        string[] name = { "Rice", "Milk", "Eggs" };
        double[] price = { 200, 30, 150 };
        int[] stock = {100, 50, 200 };
        double total = 0;


        while (true)
        {
            Console.WriteLine("\nProducts:");
            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine((i + 1)+ ". " + name[i] + "" + price[i] + " " + "Stock: " + stock[i]);
                Console.Write("gUSTO MO NYAN?: ");

                int p = int.Parse(Console.ReadLine());

                if (p == -1)
                {
                    break;
                }
                Console.Write("Quantity: ");
                int q = int.Parse(Console.ReadLine());

                if (q <= stock[p])
                {
                    double sub = q * price[p];
                    total += sub;
                    stock[p] -= q;
                    Console.WriteLine("Added: " + sub);
                }
                else
                {
                    Console.WriteLine("Not enough stock!");
                }
                Console.WriteLine("\nTotal: " + total);
                Console.WriteLine("Order oki");


            }
        }
    }
}