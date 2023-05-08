using static System.Console;
// Write a program that can compare the unit (per lb) cost of sugar sold in packages with different weights and prices.

namespace HW5
{
    class program
    {
        static void Main(string[] args)
        {
            Package MyPackage = new Package(GetInput("Please Enter the weight of Package 1: "), GetInput("Please Enter the Price of Package 1: "), GetInput("Please Enter the weight of Package 2: "), GetInput("Please Enter the price of Package 2: "));
            MyPackage.SetPrice();
            MyPackage.SetWeight();
            MyPackage.CalcUnitPrice();
            MyPackage.DisplayResults();

        }

        static double GetInput(string msg)
        {
            string input;
            Write(msg);
            input = ReadLine();
            while (double.Parse(input) <= 0)
            {
                WriteLine("Invalid input. Please provide correct input!");
                Write(msg);
                input = ReadLine();

            }
            return double.Parse(input);
        }
    }
    class Package
    {
        double unitprice,unitprice2, price, weight,price2,weight2;
        double[] spec = new double[6];
        public Package(double userprice1, double userweight1, double userprice2, double userweight2)
        {
           price = userprice1;
            weight = userweight1;
            price2 = userprice2;
            weight2 = userweight2;
        }
        public void SetPrice()
        {
            spec[0] = price;
            spec[2] = price2;
            
        }
        public void SetWeight()
        {
            spec[1] = weight;
            spec[3] = weight2;
        }
        public void CalcUnitPrice()
        {
            unitprice = price / weight;
            unitprice2 = price2 / weight2;

            spec[4] = unitprice;
            spec[5] = unitprice2;
        }
        public void DisplayResults()
        {
            WriteLine("The Unit Price for Package 1 is: " + spec[4] + " and the unit price of Package 2 is: " + spec[5]);

            if (spec[4] < spec[5])
            {
                WriteLine("Package 1 is cheaper. ");
            }
            else
            {
                WriteLine("Package 2 is cheaper. ");
            }
            
        }
    }
}