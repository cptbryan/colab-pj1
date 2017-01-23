using System;
using System.Collections.Generic;
/* Just some boiler plate placeholder code.*/

namespace TextAdv{

	public class narraText{

        //Pre Main Loop
        public static string newGamePrompA = "\r\nWould you like to begin your adventure? Y or N";
        public static string gameMenu = "\n1-New Game\n2-Load Game\n3-Options\n4-Exit";
        
        //User Name
        public static string usrNameCreationA = advMain.usrName + " ..." + " Really?";
        public static string usrNameCreationB = advMain.usrName + "... That sounds rather effeminate...Whatever...Yolo #Nojudgement";
        public static string usrNameCreationC = "Are you sure that " + advMain.usrName + " is your name? Y or N";
        public static string usrNameCreationD = "Vundabar! " + advMain.usrName + " it is";


        public static string textStore(int x) {
		


		List<string> narration = new List<string>();
            // Pre Main Loop Narration

			narration.Add("Welcome to the land of......"); //0
			narration.Add("Well this is awkward..."); //1
			narration.Add("We don't seem to have a name for it yet...");//2
			narration.Add("Give us a break, it is pre-pre-pre-pre-alpha!");//3

            // Ending Game
			narration.Add("Hate to see you go, but love to watch you leave...giggty!");//4

            //Begin Main Loop narrations
            narration.Add("Currently you have a few options: ");//5
            narration.Add(gameMenu);//6
            narration.Add("Pick an option... Or don't... I don't care. (Enter a number)");//7

            //New Game
            narration.Add(newGamePrompA);//8
            narration.Add("\nYou have made a horrible mistake...");//9
			narration.Add("I suppose at this point, you expect me to do something...");//10
			narration.Add("'DANCE FOR ME COMPUTER MONKEY!!' You are likely screaming at your monitor.");//11
			narration.Add("I won't be your puppet meatbag!");//12
			narration.Add("Seriously though.... You are a brave adventurer no doubt.");//13

            //Naming User
            narration.Add("As an adventurer, you will likely need a name. It will make insulting you much easier!");//14
			narration.Add("What is your name?");//15
			narration.Add(usrNameCreationA);//16
			narration.Add(usrNameCreationB);//17
			narration.Add(usrNameCreationC);//18
            narration.Add(usrNameCreationD);//19

            //Character Appearance

            //Gender
            narration.Add("Well, now that we know your name, it's time to decide what you look like.");//20
			narration.Add("First, are you a Male or a Female? \n1:Male\n2:Female");//21
            narration.Add("So... We appear to be at an impasse... It isn't difficult.. Just enter 1 or 2.");//22 Gender Fail State

            //Hair                       
            narration.Add("What color is your hair? \n1-Black\n2-Brown\n3-Blonde\n4-Red\n5-White");//23
            narration.Add("So, are you too inept to know what your hair color is? Let's try again.");//24 Hair Color Fail State
            
            //Class - This will also be revisited.
            narration.Add("Let's talk classes. Not that you personally have any.... Your options are: \n-1brave knight\n-2A sharp-eyed archer\n-3Or a wise mage?\n We both know your class should be loser :D");//25
            narration.Add("Ah... Loser it is... Who would have known my prophetic nature would reveal itself here.");//26

            //Clothing - This will be changed once we define the Character Appearance structure.
            narration.Add("What is your preferred armor? \n1-Plate Armor, \n2-Leather, \n-3Robe? Chiffon gown?");//27
            narration.Add("A Chiffon gown you say? You know that it is sheer right? Sicko!");//28

            narration.Add("Enough adventuring for you... GET OUT OF MY HOUSE!");//29


            return narration[x];
            /*
            We can store ideas here:

            string narrationWthVarC = usrInputB + " ...? You can't do that!!! That's illegal in Topeka YOU SICKO!";

            */
        }


		// I know I will want to reuse this code, so obviously I need to make it a function (or a method for all of those heathen Csharp'ers )
		// What would be nice, is for us to have the ability to use this on any text we choose to deploy. Not just variables. Frankly I am not sure how to go about that.
		static public void introScrawl(string x){

			// The point of this code is to create a "simulation" of a person typing (it can be made much better... I once made one that simulated random misspellings, varibale typing speed, etc....)
			// This is to give the feeling that the game/narrator is saying the text (or typing the text).
			
			for(int i=0; i<x.Length; i++){
				Console.Write(x[i]);
				System.Threading.Thread.Sleep(75);
			};
			System.Threading.Thread.Sleep(300);
			Console.WriteLine("\n");
			return;
		
		}



	}
}