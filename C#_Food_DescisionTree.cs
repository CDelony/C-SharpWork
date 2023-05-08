using static System.Console;
// This program is built off a descision tree first asking if you are feeling hungry
/*
Your program must read: (1) user’s name and (2) responses to the questions. 
Use array(s) to save all the user inputs (name, responses to the questions) 
and the final output. Your program must print out the output. 

*/

namespace HW5
{
    class program
    {
        static void Main(String[] args)
        {
            DT dt1 = new DT();
            dt1.ExecuteDT();
            dt1.MakeRec();  
            
        }
        public static string GetInput(string msg)
        {
            string input;
            Write(msg);
            input = ReadLine();
            return input;

        }
    }
    class DT
    {
        string[] myArray = new string[7];
        Random myrandom = new Random();
        int random;

        public DT()
        {
            myArray[0] = "";
            myArray[1] = "";
            myArray[2] = "";
            myArray[3] = "";
            myArray[4] = "";
            myArray[5] = "";													
            myArray[6] = "";

        }

        public void ExecuteDT()
        {
            myArray[0] = program.GetInput("What is your name?: ");
            myArray[1] = program.GetInput("Feeling hungry (Y/N): ");
            if (myArray[1] == "Y")
            {
                myArray[2] = program.GetInput("Is it midday? (Y/N): ");
                if (myArray[2] == "Y") 
                {
                    myArray[6] = "Eat lunch!";
                }
                

                else
                {
                    myArray[3] = program.GetInput("Is it after 6pm? (Y/N) ");
                    if (myArray[3] == "Y")
                    {
                        myArray[6] = "Eat dinner!";
                    }
                    else
                    {
                        myArray[6] = "Eat a snack!";
                    }
                }

            }
            else
            {
                myArray[4] = program.GetInput("Do you have work to do? (Y/N) ");
                if(myArray[4] == "Y")
                {
                    myArray[6] = "Do work!";
                }
                else
                {
                    myArray[5] = program.GetInput("Have you worked out? (Y/N) ");
                    if(myArray[5] == "Y")
                    {
                        myArray[6] = "Eat a snack!";
                    }
                    else
                    {
                        random = myrandom.Next(1, 10 + 1);
                        if(random>=4)
                        {
                            myArray[6] = "Go to the gym! ";
                        }
                        else
                        {

                            myArray[6] = "Go running!";
                        }
                    }
                }

            }
        }

        public void MakeRec()
        {
            WriteLine(myArray[6]);
        }
    
    
    }

}