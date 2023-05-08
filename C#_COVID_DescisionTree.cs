using static System.Console;
//Write a program that allows an individual to conduct the self-assessment by following the decision tree below. 
namespace HW5
{
    class program
    {
        static void Main(String[] args)
        {
            DT myDT = new DT(GetInput("What is your name? "));
            myDT.RunDt();
            myDT.Recomned();

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
        string[] myArray = new string[8];
        
        public DT(string name)
        {
            myArray[0] = name;
        }

        public void Recomned()
        {
            WriteLine(myArray[7]);
        }
        public void RunDt()
        {
            myArray[1] = program.GetInput("Travel from China or Korea? ");
            if (myArray[1] == "Y")
            {
                myArray[2] = program.GetInput("Trabel from Hubei? ");
                if(myArray[2] == "Y")
                {
                    myArray[7] = "High Risk!";
                }
                else
                {
                    myArray[3] = program.GetInput("Did you follow the recomnended precautios");
                    if (myArray[3] == "Y")
                    {
                        myArray[7] = "Medium Risk!";
                    }
                    else
                    {
                        myArray[7] = "High Risk!";
                    }
                }
            }
            else
            {
                myArray[4] = program.GetInput("Had contact with a confirmed case?");
                if( myArray[4] == "Y")
                {
                    myArray[5] = program.GetInput("Was the contact outside of health Care Facility");
                    if (myArray[5] == "Y")
                    {
                        myArray[3] = program.GetInput("Did you follow the recomnended precautios");
                        if (myArray[3] == "Y")
                        {
                            myArray[7] = "Medium Risk!";
                        }
                        else
                        {
                            myArray[7] = "High Risk!";
                        }
                    }
                    else
                    {
                        myArray[6] = program.GetInput("Was it Risky contact? ");
                        if (myArray[6] == "Y")
                        {
                            myArray[7] = "Medium Risk";
                        }
                        else
                        {
                            myArray[7] = "Low or No Risk!";
                        }
                    }
                }
                else
                {
                    myArray[7] = "Low or No Risk!";
                }
            }
        }
    }
  


}