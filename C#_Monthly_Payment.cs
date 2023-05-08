using static System.Console;
/*
The consumer loan department of a bank asks a software analyst to write a program that:

•	Reads a monthly cash flow from a user; Reads a loan amount; Reads the loan period in month; Reads monthly interest rate (in %)
•	Calculates and displays the monthly payment




*/
namespace HW5
{
    class program
    {
        static void Main(String[] args)
        {
            PaymentReport report1 = new PaymentReport(GetInput("What is your Cash flow? "), GetInput("What is the loan period? "), GetInput("What is the interest rate? "));
            report1.CalPayment();
            report1.DisplayPayment();

            
        }
        public static double GetInput(string msg)
        {
            string input;
            Write(msg);
            input = ReadLine();
            return double.Parse(input);

        }
    }
    class PaymentReport
    {
        double cash, loan, period, rate, payment;

        public  PaymentReport(double userCash, double userLoan, double userPeriod, double useriRate)
        {
            cash = userCash;
            loan = userLoan;
            period = userPeriod;
            rate = useriRate;

        }
       

        public void CalPayment()
        {
            payment = (loan * rate / 100) / (1 - 1 / (Math.Pow(1 + rate / 100, period)));
        }

        public void DisplayPayment()
        {

            WriteLine("Your monthly payment is: {0:C}/month" , payment);

            if (payment > 0.5*cash)
            {
                WriteLine("Your loan is eligible. ");
            }
            else
            {
                WriteLine("Your loan is not eligible. ");
            }
        }

        
    
    
    }

}