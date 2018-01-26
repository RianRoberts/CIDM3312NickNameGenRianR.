using System;
using System.Text;
using System.Linq;


namespace NickNameGenerator
{
    class Program
    {
               
        
        static void Main(string[] args)
        {
            //array list of random nicknames
           string[] randomfnickname = {

                "Worthless","Disgusting","Swaying","Heavy","Silly","Forgetful","Living",
            "Tiny","Stingy","Selfish","Greedy","Rich"
           };
           
           string[] randomlnickname = {

                "Puzzler","Joker","Penquin","Overachiever","Moose","Moneymaker","Destroyer",
                "Lifter","Baboon","Riddler","Villian","Hero"
            
           };
            //Algorithm to find the random name in the string array
            Random rnd = new Random();

            int r = rnd.Next(1,12);

            string str = randomfnickname[r];


            Random rnd2 = new Random();

            int r2 = rnd.Next(1,12);

            string str2 = randomlnickname[r2];

            //variables that you helped me get for the certain nicknames
            string[,] fnicknames = new string [10,1];
            string[,] lnicknames = new string [10,1];

            fnicknames [0,0] = "Holy";
            lnicknames [0,0] = "Hunter";

            fnicknames [1,0] = "Plump";
            lnicknames [1,0] = "Donut";
            
            fnicknames [2,0] = "Strange";
            lnicknames [2,0] = "Knight";

            fnicknames [3,0] = "Levitating";
            lnicknames [3,0] = "Thief";

            fnicknames [4,0] = "Lame";
            lnicknames [4,0] = "Jedi";

            fnicknames [5,0] = "Playful";
            lnicknames [5,0] = "Booger";

            fnicknames [6,0] = "Violent";
            lnicknames [6,0] = "Doctor";

            fnicknames [7,0] = "Witty";
            lnicknames [7,0] = "Rapper";

            fnicknames [8,0] = "Gigantic";
            lnicknames [8,0] = "Gamer";

            fnicknames [9,0] = "Tiny";
            lnicknames [9,0] = "Guard";


            Console.WriteLine("Please enter your first name: ");
            string fname = Console.ReadLine();



            Console.WriteLine("Please enter your last name: ");
            string lname = Console.ReadLine();


            Console.WriteLine("No, your name is not {0} {1}", fname, lname);
            
            Console.WriteLine("You will now forever be called {0} {1} ", Nickname(fname, fnicknames),Nickname(lname, lnicknames));
            //output for the random nickname
            Console.WriteLine("And just for fun, your random nickname will forever be: {0} {1}", str, str2);
            
            
        }         

        //I tried changing your algorithm to a for loop and I could not get it to run so I did a random Nickname gen instead.
        public static string Nickname(string input, string[,] nicknames)
        {

            int index = input.Length % nicknames.GetLength(0);

            return nicknames [index, 0];
        }
    }
}
