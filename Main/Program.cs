using System;
using System.Collections.Generic;
using System.Xml;
/* Just some boiler plate placeholder code.*/

namespace TextAdv
{
	class advMain
	{
        public static string usrName = "";

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
			string usrInputA;
			string usrInputB;
			string menuOptChk;
            

            // There is likely a better way to handle the narration, but this is the best I have atm



            // I don't plan on reusing this code much, so copy and paste will suffice for me.

            for (int i=0; i<21; i++){
				Console.Write("[][]");
				System.Threading.Thread.Sleep(100);
			}
			Console.WriteLine("\n");

			//var instance = new narration();
			// Here is the block of the text, nice and clean compared to what it would be without the function.
			// FYI, The objects being passed into the function, were originally variables.
			// I wanted to test out using list attributes in place of varibles...
			// Doesn't really save much code, but I don't have to think up unique variable names for all of the items.
			narraText.introScrawl(narraText.textStore(0));
			narraText.introScrawl(narraText.textStore(1));
			narraText.introScrawl(narraText.textStore(2));
			narraText.introScrawl(narraText.textStore(3));

			for(int i=0; i<21; i++){
				Console.Write("[][]");
				System.Threading.Thread.Sleep(100);
			}
			Console.WriteLine("\n");



			narraText.introScrawl(narraText.textStore(5));
            narraText.introScrawl(narraText.textStore(6));
            narraText.introScrawl(narraText.textStore(7));
			menuOptChk = Console.ReadLine();


            if(menuOptChk == "1") {
                /* Here begins the "all powerfull" main loop... otherwise known as the "Game Loop".
Everything prior to this is superfluous to the game loop, and is really just for flavor.
*/

                do//start game loop -------------------------------------->
                {
                   narraText.introScrawl(narraText.textStore(8));
                   loopChk = Console.ReadLine().ToUpper();

                    // This is honestly where the "Game Loop" begins. Generally this would be "New Game" on a menu.
                    if (loopChk == "Y")
                    {
                        narraText.introScrawl(narraText.textStore(9));
                        narraText.introScrawl(narraText.textStore(10));
                        narraText.introScrawl(narraText.textStore(11));
                        narraText.introScrawl(narraText.textStore(12));
                        narraText.introScrawl(narraText.textStore(13));

                        narraText.introScrawl(narraText.textStore(14));
                        narraText.introScrawl(narraText.textStore(15));
                        usrName = Console.ReadLine();
                        narraText.introScrawl(narraText.textStore(16));
                        narraText.introScrawl(narraText.textStore(17));
                        narraText.introScrawl(narraText.textStore(18));
                        usrInputA = Console.ReadLine().ToUpper();

                        if (usrInputA == "N")
                        {

                            while (usrInputA == "N")
                            {
                                narraText.introScrawl(narraText.textStore(15));
                                usrName = Console.ReadLine();
                                narraText.introScrawl(narraText.textStore(18));
                                usrInputA = Console.ReadLine().ToUpper();
                            }
                        }
                        narraText.introScrawl(narraText.textStore(19));

                        //Begin Character Creation

                        //Gender Select
                        narraText.introScrawl(narraText.textStore(20));
                        narraText.introScrawl(narraText.textStore(21));
                        charAtts charAppear = new charAtts();// First instantiation of the charAtts class. -EB
                        do
                        {// to keep the main program file cleaner and not clutter it with variable declarations and such.
                            charAppear.gender = Console.ReadLine().ToUpper();

                            switch (charAppear.gender)//changed this block of code from else if  to switch to clean up code-------------------------------->
                            {
                                case "1":
                                    {
                                        charAppear.gender = "Male";
                                        break;
                                    }
                                case "2":
                                    {
                                        charAppear.gender = "Female";
                                        break;
                                    }
                                default:
                                    {
                                        narraText.introScrawl(narraText.textStore(22));
                                        break;
                                    }
                            }
                        } while (charAppear.gender == "");

                        // Hair Color Select
                        narraText.introScrawl(narraText.textStore(23));
                        charAppear.hairColor = Console.ReadLine().ToUpper();
                        do
                        {
                            switch (charAppear.hairColor)
                            {
                                case "1":
                                    {
                                        charAppear.hairColor = "Black";
                                        break;
                                    }
                                case "2":
                                    {
                                        charAppear.hairColor = "Blonde";
                                        break;
                                    }
                                case "3":
                                    {
                                        charAppear.hairColor = "Brown";
                                        break;
                                    }
                                case "4":
                                    {
                                        charAppear.hairColor = "Red";
                                        break;
                                    }
                                case "5":
                                    {
                                        charAppear.hairColor = "White";
                                        break;
                                    }
                                default:
                                    {
                                        narraText.introScrawl(narraText.textStore(24));
                                        break;
                                    }
                                }
                            }while (charAppear.hairColor == "");
                            
                            //Class Selection
                         	narraText.textStore(25);
                         	charAppear.startClass = Console.ReadLine().ToUpper();
                        do//startClass do while and switch start --------------->
                         	{
                         	switch(charAppear.startClass)/*The data stored in the armor switch, class switch, and weapon switch needs
                         	            to be migrated from the charAppear object to a "TBD" object.*/
                         	            {
                         	                case "1":
                         	                {
                         	                    charAppear.startClass = "Knight";
                         	                    //charAppear.startWeapon = "Sword";
                         	                    //charAppear.startWeapon = "Rusty Bronze Sword";
                         	                    break;

                         	                }
                         	                case "2":
                         	                {
                         	                    charAppear.startClass = "Archer";
                         	                    //charAppear.startWeapon = "Bow";
                         	                    //charAppear.startWeapon = "Cheap Pine Bow";
                         	                    break;
                         	                }
                         	                case "3":
                         	                {
                         	                    charAppear.startClass = "Mage";
                         	                    //charAppear.startWeapon = "Basic Spell";
                         	                    //charAppear.startWeapon = "Fury of the Grass";
                         	                    break;
                         	                }
                         	                default:
                         	                {
                                                narraText.introScrawl(narraText.textStore(26));
                         	                    break;
                         	                }

                         	            }

                         	}while(charAppear.startClass == "");

                        //Clothing
                        narraText.textStore(27);
                        charAppear.Armor = Console.ReadLine().ToUpper();
                        do
                        {
                            switch (charAppear.startClass)/*The data stored in the armor switch, class switch, and weapon switch needs
                         	                to be migrated from the charAppear object to a "TBD" object.*/
                            {
                                case "1":
                                    {
                                        charAppear.Armor = "Plate Armor";
                                        //charAppear.startWeapon = "Sword";
                                        //charAppear.startWeapon = "Rusty Bronze Sword";
                                        break;

                                    }
                                case "2":
                                    {
                                        charAppear.Armor = "Leather";
                                        //charAppear.startWeapon = "Bow";
                                        //charAppear.startWeapon = "Cheap Pine Bow";
                                        break;
                                    }
                                case "3":
                                    {
                                        charAppear.Armor = "Robe";
                                        //charAppear.startWeapon = "Basic Spell";
                                        //charAppear.startWeapon = "Fury of the Grass";
                                        break;
                                    }
                                default:
                                    {
                                        narraText.introScrawl(narraText.textStore(28));
                                        break;
                                    }

                            }

                        } while (charAppear.Armor == "");


                        //End of current switches
                        Console.WriteLine("Let me make sure I heard you 'write'... Heh Heh...Not funny? Whatever...\nSo your name is " + usrName + "\nYou are a " + charAppear.gender + " adventurer" + "\nYour hair color is " + charAppear.hairColor + "\nYou're a " + charAppear.startClass + "\nAnd you prefer to wear " + charAppear.Armor + "s");
                        Console.WriteLine("Correct?");

                        break;//Here is where the game loop breaks currently. After save states and...everything else is implemented, we will change this
                        }
                 }while (loopChk == "Y");
                 narraText.introScrawl(narraText.textStore(29));

             
            }
            else if (menuOptChk == "2"){
				Console.WriteLine("Well... I don't know how to say this... but we don't have a save function yet... You've lost nothing... or everything...");
			}
			else if(menuOptChk == "3"){
				Console.WriteLine("Your options consist of: 'Firmly place your head between your legs and kiss your buttocks goodbye.' or 'Play something better.' I suggest the later, frankly.");
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

						narraText.introScrawl(narraText.textStore(4));

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
			}
			else{
				Console.WriteLine("Let me guess.... You can't read... Or are you just incapable of following directions?");
			}
		}
	}
}
