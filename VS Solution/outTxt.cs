using System;
using System.Collections.Generic;
/* Just some boiler plate placeholder code.*/

namespace TextAdv{

    [Serializable()]
    public class narraText{
       
        //Pre Main Loop
        public static string newGamePrompA = "\r\nWould you like to begin your adventure? Y or N";
        

        public static string textStore(int x) {

		    List<string> narration = new List<string>();
                // Pre Main Loop Narration
			    narration.Add("Welcome to the land of......\nWell this is awkward...\nWe don't seem to have a name for it yet...\nGive us a break, it is pre-pre-pre-pre-alpha!"); //0

                //Begin Main Loop narrations
                narration.Add("Currently you have a few options.\nPick an option... Or don't... I don't care. (Enter a number)");//1

                //New Game
                narration.Add("\nYou have made a horrible mistake...\nI suppose at this point, you expect me to do something...\n'DANCE FOR ME COMPUTER MONKEY!!,' you are likely screaming at your monitor.\nI won't be your puppet, meatbag!\nSeriously though.... You are a brave adventurer no doubt.");//2

                //Naming User
                narration.Add("As an adventurer, you will likely need a name. It will make insulting you much easier!\nWhat is your name?\n");//3

                //Character Appearance

                //TBD

                //Gender
                narration.Add("Well, now that we know your name, it's time to decide what you look like./n First, are you a Male or a Female ? \n1: Male\n2: Female");//4

                //Hair Color
                narration.Add("What color is your hair? \n1-Black\n2-Brown\n3-Blonde\n4-Red\n5-White");//5
                narration.Add("So, are you too inept to know what your hair color is? Let's try again.");//6 Hair Color Fail State

                //Class - This will also be revisited.
                narration.Add("Let's talk classes. Not that you personally have any.... Your options are: \n-1brave knight\n-2 sharp-eyed archer\n-3 wise mage?\n We both know your class should be loser :D");//7
                narration.Add("Ah... Loser it is... Who would have known my prophetic nature would reveal itself here.");//8

                //Clothing - This will be changed once we define the Character Appearance structure
                narration.Add("What is your preferred armor? \n1-Plate Armor, \n2-Leather, \n-3Robe? Chiffon gown?");//9
                narration.Add("A Chiffon gown you say? You know that it is sheer right? Sicko!");//10
                narration.Add("Enough adventuring for you... GET OUT OF MY HOUSE!");//11

                // Ending Game
                narration.Add("Hate to see you go, but love to watch you leave...giggty!");//12

                //Generic Fail Statement
                narration.Add("So... We appear to be at an impasse... It isn't difficult.. Just enter a number from the list!");//13

            //Menu Item Messages
                narration.Add("We are working on it!");//14
                narration.Add("Well... I don't know how to say this... but we don't have a save function yet... You've lost nothing... or everything...\nPress Enter to continue:");//15
                narration.Add("You may start to notice a pattern... We promise features and don't deliever them... Don't Worry! That's why god made DLC!");//16
                narration.Add("Your options consist of: 'Firmly place your head between your legs and kiss your buttocks goodbye.' or 'Play something better.' I suggest the later, frankly.\nPress enter to continue:");//17
                narration.Add("Currently I can only dipence advice. As my 'Help' credentials are in the mail...\nPress Enter to continue:");//18
                narration.Add("What is your race?\n1-Human\n2-Dwarf\n3-Elf");//19
                //narration.Add();//19

            return narration[x];
            
        }

        // introScrawl forces the text to display character by character
        public static void introScrawl(string x)
        {
            
            for (int i=0; i<x.Length; i++){

                Console.Write(x[i]);
                System.Threading.Thread.Sleep(75);              
            }
			System.Threading.Thread.Sleep(300);
			Console.WriteLine("\n");
		}

        // Moved the intro from Main to the introVis method.
        // introVis displays a line of brackets (the length being defined by (int i = 0; i < #; i++)).
        // Then intro text. Then another line of brackets.
        public static void introVis()
        {
            for (int i = 0; i < 21; i++)
            {
                Console.Write("[][]");
                //System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine("\n");

            narraText.introScrawl(narraText.textStore(0));

            for (int i = 0; i < 21; i++)
            {
                Console.Write("[][]");
                //System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine("\n");
        }

        // Moved the outro from Main to the outVis method.
        // outVis displays a line of "kirby's" (the length being defined by (int i = 0; i < #; i++)).
        // Then intro text. Then another line of "kirby's".
        public static void outVis()
        {
            Console.Write("\n");
            for (int i = 0; i < 4; i++)
            {
                System.Threading.Thread.Sleep(200);
                Console.Write("<('-'<) ");
                System.Threading.Thread.Sleep(200);
                Console.Write("(^'-'^) ");
                System.Threading.Thread.Sleep(200);
                Console.Write("(>'-')> ");
                System.Threading.Thread.Sleep(200);
            }
            Console.WriteLine("\n");

            narraText.introScrawl(narraText.textStore(12));
            
            for (int i = 0; i < 4; i++)
            {
                System.Threading.Thread.Sleep(200);
                Console.Write("<('-'<) ");
                System.Threading.Thread.Sleep(200);
                Console.Write("(^'-'^) ");
                System.Threading.Thread.Sleep(200);
                Console.Write("(>'-')> ");
                System.Threading.Thread.Sleep(200);
            }
            Console.WriteLine("\n");


            Console.ReadKey();
            System.Environment.Exit(1); ;
        }



	}
}
