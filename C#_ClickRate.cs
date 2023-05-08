using static System.Console;
/*
Write a program that can calculate click-through rate of two online ads. 
The program prompts the user to enter impressions and the number of clicks of ad A, 
then does the same for ad 2, and displays CTR of the two ads.


*/
namespace HW5
{
    class program
    {
        static void Main(String[] args)
        {
            OnlineAD AD1 = new OnlineAD(GetInput("What is the # of clicks for Ad1? "), GetInput("What is the # of imps of Ad1? "));
            AD1.CalcCTR();

            OnlineAD AD2 = new OnlineAD(GetInput("What is the # of clicks for Ad2? "), GetInput("What is the # of imps of Ad2? "));
            AD2.CalcCTR();

            DisplayCTR(AD1.GetCTR(),AD2.GetCTR());
        }
        public static double GetInput(string msg)
        {
            string input;
            Write(msg);
            input = ReadLine();
            return double.Parse(input);
        }
        public static void DisplayCTR(double ctr1, double ctr2)
        {

            WriteLine("The CTR of Ad1 is: {0:F3}", ctr1);
            WriteLine("The CTR of Ad2 is: {0:F3}", ctr2);
        }
    
    }
    class OnlineAD
    {
        double clicks, imps, ctr;
        public OnlineAD(double userClicks, double userImps)
        {
            clicks = userClicks;
            imps = userImps;
            
        }

        public void CalcCTR()
        {
            ctr = clicks / imps;
        }

        public double GetCTR()
        {
            return ctr;
        }
    
    }


}