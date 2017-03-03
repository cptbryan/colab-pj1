using System;
using System.Collections.Generic;
/* Just some boiler plate placeholder code.*/

namespace TextAdv
{

    #region Game Narration Text
    public class narraText
    {

        //Pre Main Loop
        public static string newGamePrompA = "\r\nWould you like to begin your adventure? Y or N";

        #region Narration Text Store
        public static string textStore(int x)
        {


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

            //Facial Hair
            narration.Add("\nHow about facial hair?");//5
            narration.Add("1-Long and Braided\n2-Big and Bushy\n3-Wildman\n4-Fu-Man Chu\n5-'C'mon Bruther'\n6-Mutton Chops\n7-'Thin 'n Dirty'\n8-'The Sparrow'\n9-'Honest Abe'\n10-Prepubescent");//6

            //Hair Style
            narration.Add("\nWhat kind of hair style do you have?");//7
            narration.Add("1-Long and Free\n2-Soldier\n3-Tonsure\n4-Top-Knot\n5-Shaved\n6-Afro\n7-Shoulder Length\n8-HighTop-Fade\n9-Long Dreads\n10-Long Shaved Sides");//8

            //Hair Color
            narration.Add("\nWhat color is your hair?");//9
            narration.Add("1-Black\n2-Brown\n3-Blonde\n4-Red\n5-White");//10

            //Species
            narration.Add("\nWhat is your race?");//11
            narration.Add("1-Human\n2-Dwarf\n3-Elf\n");//12

            //Height
            narration.Add("\nHow tall are you?");//13
            narration.Add("1-Short\n2-Average\n3-Tall\n4-Giant\n5-'How's the weather up there?'");//14

            //Weight
            narration.Add("\nHow big are you?");//15
            narration.Add("1-Feather Weight\n2-Average\n3-'Big'un'\n4-'Brick House\n5-'Fluffy'");//16

            //Build
            narration.Add("\nWhat is your fitness level?");//17
            narration.Add("1-'Struggles to lift soap'\n2-Average\n3-Fit\n4-Ripped\n5-'Roids!'");//18

            //Class - This will also be revisited.
            narration.Add("Let's talk classes. Not that you personally have any.... Your options are: \n-1brave knight\n-2 sharp-eyed archer\n-3 wise mage?\n We both know your class should be loser :D");//19
            narration.Add("Ah... Loser it is... Who would have known my prophetic nature would reveal itself here.");//20

            //Clothing - This will be changed once we define the Character Appearance structure
            narration.Add("What is your preferred armor? \n1-Plate Armor, \n2-Leather, \n-3Robe? Chiffon gown?");//21
            narration.Add("A Chiffon gown you say? You know that it is sheer right? Sicko!");//22
            narration.Add("Enough adventuring for you... GET OUT OF MY HOUSE!");//23

            // Ending Game
            narration.Add("Hate to see you go, but love to watch you leave...giggty!");//24

            //Generic Fail Statement
            narration.Add("So... We appear to be at an impasse... It isn't difficult.. Just enter a number from the list!");//25

            //Menu Item Messages
            narration.Add("We are working on it!");//26
            narration.Add("Well... I don't know how to say this... but we don't have a save function yet... You've lost nothing... or everything...\nPress Enter to continue:");//27
            narration.Add("You may start to notice a pattern... We promise features and don't deliever them... Don't Worry! That's why god made DLC!");//28
            narration.Add("Your options consist of: 'Firmly place your head between your legs and kiss your buttocks goodbye.' or 'Play something better.' I suggest the later, frankly.\nPress enter to continue:");//29
            narration.Add("Currently I can only dipence advice. As my 'Help' credentials are in the mail...\nPress Enter to continue:");//30

            //MainLoop Next
            narration.Add("Let me make sure I heard you 'write'... Heh Heh...Not funny? Whatever...\nSo your name is: " + HumanEntity.entName + "\nYour gender is: " + HumanEntity.entGender + "\nYour choice of facial hair is: " + HumanEntity.entFacialHair + "\nYour hair style is: " + HumanEntity.entHairStyle + "\nYour hair color is: " + HumanEntity.entHairColor + "\nYour race is: " + HumanEntity.entSpecies + "\nYour height is: " + HumanEntity.entHeight + "\nYour weight is: " + HumanEntity.entWeight + "\nYour build is: " + HumanEntity.entBuild);//31

            //narration.Add();//31

            return narration[x];

        }
        #endregion

        // introScrawl forces the text to display character by character
        #region Controls Speed of Text Output
        public static void introScrawl(string x)
        {

            for (int i = 0; i < x.Length; i++)
            {

                Console.Write(x[i]);
                //System.Threading.Thread.Sleep(75);              
            }
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("\n");
        }
        #endregion

        // Moved the intro from Main to the introVis method.
        // introVis displays a line of brackets (the length being defined by (int i = 0; i < #; i++)).
        // Then intro text. Then another line of brackets.
        #region Intro ASCII Border
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
        #endregion

        // Moved the outro from Main to the outVis method.
        // outVis displays a line of "kirby's" (the length being defined by (int i = 0; i < #; i++)).
        // Then intro text. Then another line of "kirby's".
        #region Outro ASCII Border and Exit Message
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
        #endregion


    }
    #endregion
}
