using System;
using System.Collections.Generic;
/* Just some boiler plate placeholder code.*/

namespace TextAdv
{
	class advMain
	{
		
		// I know I will want to reuse this code, so obviously I need to make it a function (or a method for all of those heathen Csharp'ers )
		// What would be nice, is for us to have the ability to use this on any text we choose to deploy. Not just variables. Frankly I am not sure how to go about that.
		static public void introScrawl(string x){

			// The point of this code is to create a "simulation" of a person typing (it can be made much better... I once made one that simulated random misspellings, varibale typing speed, etc....)
			// This is to give the feeling that the game/narrator is saying the text (or typing the text).
			
			for(int i=0; i<x.Length; i++){
				Console.Write(x[i]);
				//System.Threading.Thread.Sleep(100);
			};
			System.Threading.Thread.Sleep(300);
			Console.WriteLine("\n");
			return;
		
		}
		
		
		
		public static void Main(string [] args){
			
			// So obviously what we are wanting to do is create a quirky and fun little game.
			
			/*
				The first step is to think about what your goal is.
				You don't start by slinging code and seeing what sticks, as that is a recipe for suffering.
				
				Something as complex as a game has to be thought out. Anybody can make a program that spits text onto the screen.
				A game is a multitude of instructions all working in series. You need to define which instructions... and what series... well before writing any code.
			*/
			
			// For the sake of expediency... I decided to write out a very basic block of code to give an idea of what that might look like.
			
			string loopChk;
			
			string usrName = "";
			string usrInputA;
			string usrInputB;
			string narrationWthVarA = usrName +"..." + " Really?";
		    string narrationWthVarB = "Vundabar!";
			            
			
			// There is likely a better way to handle the narration, but this is the best I have atm
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
			
			
			// I don't plan on reusing this code much, so copy and paste will suffice for me.
			// Commenting these out while I am debugging - 1/15/17
			// for(int i=0; i<21; i++){
			// 	Console.Write("[][]");
			// 	System.Threading.Thread.Sleep(100);
			// };
			// Console.WriteLine("\n");
			
			// Here is the block of the text, nice and clean compared to what it would be without the function.
			// FYI, The objects being passed into the function, were originally variables. 
			// I wanted to test out using list attributes in place of varibles...
			// Doesn't really save much code, but I don't have to think up unique variable names for all of the items.
			introScrawl(narration[0]);
			introScrawl(narration[1]);
			introScrawl(narration[2]);
			introScrawl(narration[3]);
			
			// Commenting these out while I am debugging - 1/15/17
			// for(int i=0; i<21; i++){
			// 	Console.Write("[][]");
			// 	System.Threading.Thread.Sleep(100);
			// };
			// Console.WriteLine("\n");
			
			
			/* Here begins the "all powerfull" main loop... otherwise known as the "Game Loop".
			   Everything prior to this is superfluous to the game loop, and is really just for flavor.
			*/
			
			do{
					//Generally you don't want the "Would you like to play a game" action inside of the loop.
					//This is where a menu would come in handy.
					
					//"How do we make a menu" I hear you say? GOOD QUESTION!
					//... I have no idea....
					
			        Console.WriteLine("\r\nWould you like to begin your adventure? Y or N");
			        loopChk = Console.ReadLine().ToUpper();
			        
			        // This is honestly where the "Game Loop" begins. Generally this would be "New Game" on a menu. 
			        if(loopChk == "Y"){
			        	introScrawl(narration[5]);
			        	introScrawl(narration[6]);
			        	introScrawl(narration[7]);
			        	introScrawl(narration[8]);
			        	introScrawl(narration[9]);
			        	introScrawl(narration[10]);
			        	usrName = Console.ReadLine();
			            introScrawl(narrationWthVarA);
			            introScrawl(narration[11]);
			            introScrawl(narration[12]);
			        	usrInputA = Console.ReadLine().ToUpper();
			        	
			        	if(usrInputA == "N"){
			        		
			        		while(usrInputA == "N"){
			        		introScrawl(narration[10]);
			        		usrName = Console.ReadLine();
			        		introScrawl(narration[11]);
			        		introScrawl(narration[12]);
			        		usrInputA = Console.ReadLine().ToUpper();
			        		}
			        	}
			        	
						introScrawl(narrationWthVarB);
						Console.Write(usrName);
			        	introScrawl(narration[13]);
			        	introScrawl(narration[14]);
			        	usrInputB = Console.ReadLine();
			        	Console.WriteLine();
			        	string narrationWthVarC = usrInputB + " ...? You can't do that!!! That's illegal in Topeka YOU SICKO!";
			        	introScrawl(narrationWthVarC);
			        	introScrawl(narration[15]);
			        	
			        	break;
			        	
			        }
			        
				


			}while(loopChk == "Y");
			Console.WriteLine("\n");
			
			for(int i=0; i<4; i++){
				System.Threading.Thread.Sleep(200);
				Console.Write("<('-'<) ");
				System.Threading.Thread.Sleep(200);
				Console.Write("(^'-'^) ");
				System.Threading.Thread.Sleep(200);
				Console.Write("(>'-')> ");
				System.Threading.Thread.Sleep(200);
			};
			Console.WriteLine("\n");
			
			introScrawl(narration[4]);
			
			for(int i=0; i<4; i++){
				System.Threading.Thread.Sleep(200);
				Console.Write("<('-'<) ");
				System.Threading.Thread.Sleep(200);
				Console.Write("(^'-'^) ");
				System.Threading.Thread.Sleep(200);
				Console.Write("(>'-')> ");
				System.Threading.Thread.Sleep(200);
			};
			Console.WriteLine("\n");		
		}
	}


}
