using System;
using System.Collections.Generic;
using System.Xml;
/* Just some boiler plate placeholder code.*/

namespace TextAdv
{
	class advMain
	{
        

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
			
			//string usrInputB; unused in current build
			string menuOptChk;


            // There is likely a better way to handle the narration, but this is the best I have atm

            // I don't plan on reusing this code much, so copy and paste will suffice for me.

            for (int i=0; i<21; i++){
				Console.Write("[][]");
				//System.Threading.Thread.Sleep(100);
			}
			Console.WriteLine("\n");


			//var instance = new narration();
			// Here is the block of the text, nice and clean compared to what it would be without the function.
			// FYI, The objects being passed into the function, were originally variables.
			// I wanted to test out using list attributes in place of varibles...
			// Doesn't really save much code, but I don't have to think up unique variable names for all of the items.
			narraText.introScrawl(narraText.textStore(0));


			for(int i=0; i<21; i++){
				Console.Write("[][]");
				//System.Threading.Thread.Sleep(100);
			}
			Console.WriteLine("\n");



			narraText.introScrawl(narraText.textStore(1));
        	menuOptChk = Console.ReadLine();


            if (menuOptChk == "1")//start game loop -------------------------------------->
            {
                                       
                // This is honestly where the "Game Loop" begins. Generally this would be "New Game" on a menu.
                narraText.introScrawl(narraText.textStore(2));
                //Assigning the return value of asnUsrName method to usrName. Might not be necessary, so keep that in mind. 
                string usrName = HumanEntity.asnUsrName();
                                     
                //Begin Character Creation //Character Creation will be moved to Human Entity.cs
                charAtts charAppear = new charAtts();// First instantiation of the charAtts class.

                //Gender Select 
                narraText.introScrawl(narraText.textStore(4));
                charAppear.gen(Console.ReadLine().ToUpper());

                //Hair Color Select
                narraText.introScrawl(narraText.textStore(5));
                charAppear.hc(Console.ReadLine().ToUpper());

                //Class Selection
                armor sClass = new armor();
                narraText.textStore(7);
                sClass.startingClass(Console.ReadLine().ToUpper());

                //Clothing and Armor Selection
                narraText.textStore(9);
                sClass.tempArmor(Console.ReadLine().ToUpper());

                //End of current switches
                // Detailing the users choices.
                Console.WriteLine("Let me make sure I heard you 'write'... Heh Heh...Not funny? Whatever...\nSo your name is " + usrName + "\nYou are some kind of " + sClass.startClass + " adventurer" + "\nYour hair color is " + charAppear.hairColor + " and you prefer the comfort of " + sClass.startArmor);
                Console.WriteLine("Correct?");
                Console.ReadLine();

                   //Here is where the game loop breaks currently. After save states and...everything else is implemented, we will change this
                 
                    narraText.introScrawl(narraText.textStore(11));


            }
            else if (menuOptChk == "2"){
				Console.WriteLine("Well... I don't know how to say this... but we don't have a save function yet... You've lost nothing... or everything...");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
			else if(menuOptChk == "3"){
				Console.WriteLine("Your options consist of: 'Firmly place your head between your legs and kiss your buttocks goodbye.' or 'Play something better.' I suggest the later, frankly.");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
			else if(menuOptChk == "4"){
				for(int i=0; i<4; i++){
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
                

                for (int i=0; i<4; i++){
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
			else{
				Console.WriteLine("Let me guess.... You can't read... Or are you just incapable of following directions?");
			}Console.ReadKey();
            System.Environment.Exit(1);
        }
	}
 }

