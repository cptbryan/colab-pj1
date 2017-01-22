using System;
using System.Collections.Generic;
/* Just some boiler plate placeholder code.*/

namespace TextAdv{

	public class narraText{
		
		public static string textStore(int x) {
		


		List<string> narration = new List<string>();
			narration.Add("Welcome to the land of......"); //0
			narration.Add("Well this is awkward..."); //1
			narration.Add("We don't seem to have a name for it yet...");//2
			narration.Add("Give us a break, it is pre-pre-pre-pre-alpha!");//3
			narration.Add("Hate to see you go, but love to watch you leave...giggty!");//4
			narration.Add("\nYou have made a horrible mistake..."); // Begin in-game narrations at postion 5
			narration.Add("I suppose at this point, you expect me to do something...");//6
			narration.Add("'DANCE FOR ME COMPUTER MONKEY!!' You are likely screaming at your monitor.");//7
			narration.Add("I won't be your puppet meatbag!");//8
			narration.Add("Seriously though.... You are a brave adventurer no doubt.");//9
			narration.Add("What is your name?");//10
			// string narrationWthVarA = Console.WriteLine(usrName +"..." + " Really?");
			// string narrationWthVarB = Console.WriteLine("Vundabar! " + usrName + " It is." );
			narration.Add("That sounds rather effeminate... Whatever... Yolo #Nojudgement");//11
			narration.Add("Are you sure that's your name? Y or N");//12
			narration.Add("... I'm frankly not sure of what to do next...");//13
			narration.Add("Any ideas?");//14
			narration.Add("GET OUT OF MY HOUSE!");//15
			narration.Add("Currently you have a few options: ");//16
			narration.Add("Pick an option... Or don't... I don't care. (Enter a number)");//17
            narration.Add("It's time to decide what you look like.");//18
            narration.Add("Are you a male or a female? (One or the other, this isn't California.)");//19
            narration.Add("What color is your hair?");//20
            narration.Add("What is your preferred armor? Leather, Chainmail, Metal Suit?");//21
            narration.Add("Let's talk classes. Are you a brave knight? A sharp-eyed archer? Or a wise mage?");//22

         


            

			return narration[x];

		}

		// I know I will want to reuse this code, so obviously I need to make it a function (or a method for all of those heathen Csharp'ers )
		// What would be nice, is for us to have the ability to use this on any text we choose to deploy. Not just variables. Frankly I am not sure how to go about that.
		static public void introScrawl(string x){

			// The point of this code is to create a "simulation" of a person typing (it can be made much better... I once made one that simulated random misspellings, varibale typing speed, etc....)
			// This is to give the feeling that the game/narrator is saying the text (or typing the text).
			
			for(int i=0; i<x.Length; i++){
				Console.Write(x[i]);
				System.Threading.Thread.Sleep(100);
			};
			System.Threading.Thread.Sleep(300);
			Console.WriteLine("\n");
			return;
		
		}



	}
}