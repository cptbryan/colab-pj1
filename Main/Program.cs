using System;
using System.Collections.Generic;

/* Just some boiler plate placeholder code.*/

namespace TextAdv
{
    
    class advMain
    {
        public static string menuOptChk = "";

        public static void Main(string[] args)
        {
            EngineMech.optionsMenu();
            //Moved the intro section of braces and text into the introVis method
            narraText.introVis();


            narraText.introScrawl(narraText.textStore(1));
            EngineMech.mainMenu(menuOptChk);

            while(menuOptChk != "")
            {
                narraText.introScrawl(narraText.textStore(26));
                Console.WriteLine("To exit press enter");
                Console.ReadLine();
                narraText.outVis();
            }

            // This is honestly where the "Game Loop" begins. Generally this would be "New Game" on a menu.
            
            //Assigning the return value of asnUsrName method to usrName. Might not be necessary, so keep that in mind. 
            

            //Begin Character Creation //Character Creation will be moved to Human Entity.cs


            /*

            //Gender Select 
            narraText.introScrawl(narraText.textStore(4));
            string gender = HumanEntity.chrCrtn("Gender", Console.ReadLine().ToUpper());

            //Hair Color Select
            narraText.introScrawl(narraText.textStore(5));
            string hcolor = HumanEntity.chrCrtn("hairColor", Console.ReadLine().ToUpper());

            //Class Selection
            armor sClass = new armor();
            narraText.textStore(7);
            sClass.startingClass(Console.ReadLine().ToUpper());

            //Clothing and Armor Selection
            narraText.textStore(9);
            sClass.tempArmor(Console.ReadLine().ToUpper());

            //End of current switches
            // Detailing the users choices.
            Console.WriteLine("Let me make sure I heard you 'write'... Heh Heh...Not funny? Whatever...\nSo your name is " + usrName + "\nYou are a " + gender + "\nYou are some kind of " + sClass.startClass + " adventurer" + "\nYour hair color is " + hcolor + " and you prefer the comfort of " + sClass.startArmor);
            Console.WriteLine("Correct?");
            Console.ReadLine();

            //Here is where the game loop breaks currently. After save states and...everything else is implemented, we will change this

            narraText.introScrawl(narraText.textStore(11));
            */

        }
    }
}
