using System;

namespace Input_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 0;
            int orange = 15;
            int lemon = 5;

            Console.Write("Enter Money ");//ใส่งเงิน
            money = (int)double.Parse(Console.ReadLine());
            Console.WriteLine("Monney is = " + money + " Baht");//บอกจำนวนเงินที่ใส่เข้าไป

            Console.WriteLine("what do you want to buy:" + "\n" +
               "Orange = " + orange + " Baht" + "\n" +"Lemon = " + lemon + " Baht");

            Console.Write("Input oreange or lemon:");
            string order = Console.ReadLine();

            if(order == "Orange" || order == "orange")
            {

                if (money >= 15)
                {
                    Console.Write("amount:");
                    int orderOrange = (int)double.Parse(Console.ReadLine());
                    Console.WriteLine("total orange price = " + (orderOrange * orange) + " Baht");
                    int allPriceOrange = orderOrange * orange;

                    if (money >= allPriceOrange)
                    {
                        int allPrice = money - allPriceOrange;
                        Console.WriteLine("change = " + allPrice + " Baht");
                    }

                    else
                    {
                        Console.WriteLine("Your money is not enough");
                    }
                    Console.WriteLine("thank you");
                }
            }

            if (order == "lemon" || order == "Lemon")
            {
                Console.Write("amount:");
                int orderLemon = (int)double.Parse(Console.ReadLine());
                Console.WriteLine("total lemon price = " + (orderLemon * lemon) + " Baht");
                int allPriceLemon = orderLemon * lemon;

                if (money >= allPriceLemon)
                {
                    int allPrice = money - allPriceLemon;
                    Console.WriteLine("change = " + allPrice + " Baht");
                }

                else
                {
                    Console.WriteLine("Your money is not enough");
                }
                Console.WriteLine("thank you");
            }
        }
    }
}
