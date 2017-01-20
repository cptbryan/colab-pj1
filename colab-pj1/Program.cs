using System;
using System.Collections.Generic;

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
			
			string usrName = "";
            string usrInputA;
			string usrInputB;
			string narrationWthVarA = usrName +"..." + " Really?";
		    string narrationWthVarB = "Vundabar!";
		    string menuOptChk;
			            
			
			// There is likely a better way to handle the narration, but this is the best I have atm
		
			
			
			// I don't plan on reusing this code much, so copy and paste will suffice for me.
			
			for(int i=0; i<21; i++){
				Console.Write("[][]");
				System.Threading.Thread.Sleep(100);
			};
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
			};
			Console.WriteLine("\n");
			
			
			
			narraText.introScrawl(narraText.textStore(16));
			
			Console.WriteLine("1-New Game\n2-Load Game\n3-Options\n4-Exit");
			
			narraText.introScrawl(narraText.textStore(17));
			menuOptChk = Console.ReadLine();
			
			
			if(menuOptChk == "1"){

                /* Here begins the "all powerfull" main loop... otherwise known as the "Game Loop".
				   Everything prior to this is superfluous to the game loop, and is really just for flavor.
				*/

                do//start game loop -------------------------------------->
                {
                    //Generally you don't want the "Would you like to play a game" action inside of the loop.
                    //This is where a menu would come in handy.

                    //"How do we make a menu" I hear you say? GOOD QUESTION!
                    //... I have no idea....

                    Console.WriteLine("\r\nWould you like to begin your adventure? Y or N");
                    loopChk = Console.ReadLine().ToUpper();

                    // This is honestly where the "Game Loop" begins. Generally this would be "New Game" on a menu. 
                    if (loopChk == "Y")
                    {
                        narraText.introScrawl(narraText.textStore(5));
                        narraText.introScrawl(narraText.textStore(6));
                        narraText.introScrawl(narraText.textStore(7));
                        narraText.introScrawl(narraText.textStore(8));
                        narraText.introScrawl(narraText.textStore(9));
                        narraText.introScrawl(narraText.textStore(10));
                        usrName = Console.ReadLine();
                        narraText.introScrawl(narrationWthVarA);
                        narraText.introScrawl(narraText.textStore(11));
                        narraText.introScrawl(narraText.textStore(12));
                        usrInputA = Console.ReadLine().ToUpper();

                        if (usrInputA == "N")
                        {

                            while (usrInputA == "N")
                            {
                                narraText.introScrawl(narraText.textStore(10));
                                usrName = Console.ReadLine();
                                narraText.introScrawl(narraText.textStore(11));
                                narraText.introScrawl(narraText.textStore(12));
                                usrInputA = Console.ReadLine().ToUpper();
                            }
                        }

                        narraText.introScrawl(narrationWthVarB);
                        Console.Write(usrName);
                        narraText.introScrawl(narraText.textStore(13));
                        narraText.introScrawl(narraText.textStore(14));
                        usrInputB = Console.ReadLine();
                        Console.WriteLine();
                        string narrationWthVarC = usrInputB + " ...? You can't do that!!! That's illegal in Topeka YOU SICKO!";
                        narraText.introScrawl(narrationWthVarC);
                        narraText.introScrawl(narraText.textStore(15));
                        narraText.textStore(18);//beginning of character creation
                        narraText.textStore(19);
                        charAtts charAppear = new charAtts();// here is the first instantiation of the charAtts class. I did this
                        do {                                // to keep the main program file cleaner and not clutter it with variable declarations and such.
                            charAppear.gender = Console.ReadLine().ToUpper();
                            switch (charAppear.gender)//changed this block of code from else if  to switch to clean up code-------------------------------->
                            {
                                case "MALE":
                                    {
                                        charAppear.gender = "Male";
                                        break;
                                    }
                                case "M":
                                    {
                                        charAppear.gender = "Male";
                                        break;
                                    }
                                case "BOY":
                                    {
                                        charAppear.gender = "Male";
                                        break;
                                    }
                                case "MAN":
                                    {
                                        charAppear.gender = "Male";
                                        break;
                                    }
                                case "DUDE":
                                    {
                                        charAppear.gender = "Male";
                                        break;
                                    }
                                case "FEMALE":
                                    {
                                        charAppear.gender = "Female";
                                        break;
                                    }
                                case "F":
                                    {
                                        charAppear.gender = "Female";
                                        break;
                                    }
                                case "GIRL":
                                    {
                                        charAppear.gender = "Female";
                                        break;
                                    }
                                case "CHICK":
                                    {
                                        charAppear.gender = "Female";
                                        break;
                                    }
                                case "WOMAN":
                                    {
                                        charAppear.gender = "Female";
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("It is very possible that you don't consider yourself one or the other, however, that isn't applicable here.");
                                        break;
                                    }
                            }
                         while (charAppear.gender == "Male" || charAppear.gender == "Female");
                         

                            narraText.textStore(20);
                            charAppear.hairColor = Console.ReadLine().ToUpper();
                            do
                            {
                                switch (charAppear.hairColor)
                                {
                                    case "BLACK":
                                        {
                                            charAppear.hairColor = "Black";
                                            break;
                                        }
                                    case "BLONDE":
                                        {
                                            charAppear.hairColor = "Blonde";
                                            break;
                                        }
                                    case "BROWN":
                                        {
                                            charAppear.hairColor = "Brown";
                                            break;
                                        }
                                    case "RED":
                                        {
                                            charAppear.hairColor = "Red";
                                            break;
                                        }
                                    case "WHITE":
                                        {
                                            charAppear.hairColor = "White";
                                            break;
                                        }
                                    case "BALD":
                                        {
                                            charAppear.hairColor = "Bald";
                                            Console.WriteLine("Well you are like my father in law.");
                                            break;
                                        }
                                    case "NONE":
                                        {
                                            charAppear.hairColor = "Bald";
                                            Console.WriteLine("Well you are like my father in law.");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("So, are you too inept to know what your hair color is? Let's try again.");
                                            break;
                                        }
                                }
                                while (charAppear.hairColor != "Black" || charAppear.hairColor != "Blonde" || charAppear.hairColor != "Brown" || charAppear.hairColor != "Red" || charAppear.hairColor != "White" || charAppear.hairColor != "Bald" || charAppear.hairColor != "None") ;
                                narraText.textStore(21);
                                charAppear.armor = Console.ReadLine().ToUpper();
                                do
                                {
                                    switch (charAppear.armor)
                                    {
                                        case "LEATHER":
                                            {
                                                charAppear.armor = "Leather";
                                                //charAppear.armorStrenth = TBD; here, we need to assign what the strength of that armor will be based off the user choice.
                                                //charAppear.armorWeight = TBD;
                                                break;
                                            }
                                        case "HIDE":
                                            {
                                                charAppear.armor = "Leather";
                                                //charAppear.armorStrenth = TBD;
                                                //charAppear.armorWeight = TBD;
                                                break;
                                            }
                                        case "CHAINMAIL":
                                            {
                                                charAppear.armor = "Chainmail";
                                                //charAppear.armorStrength = TBD;
                                                //charAppear.armorWeight = TBD;
                                                break;
                                            }
                                        case "CHAIN":
                                            {
                                                charAppear.armor = "Chainmail";
                                                //charAppear.armorStrength = TBD;
                                                //charAppear.armorWeight = TBD;
                                                break;
                                            }
                                        case "MAIL":
                                            {
                                                charAppear.armor = "Chainmail";
                                                //charAppear.armorStrength = TBD;
                                                //charAppear.armorWeight = TBD;
                                                break;
                                            }
                                        case "METAL SUIT":
                                            {
                                                charAppear.armor = "Metal Suit";
                                                //charAppear.armorStrength = TBD;
                                                //charAppear.armorWeight = TBD;
                                                break;
                                            }
                                        case "SUIT OF ARMOR":
                                            {
                                                charAppear.armor = "Metal Suit";
                                                //charAppear.armorStrength = TBD;
                                                //charAppear.armorWeight = TBD;
                                                break;
                                            }
                                        case "METAL":
                                            {
                                                charAppear.armor = "Metal Suit";
                                                //charAppear.armorStrength = TBD;
                                                //charAppear.armorWeight = TBD;
                                                break;
                                            }
                                        case "SUIT":
                                            {
                                                charAppear.armor = "Metal Suit";
                                                //charAppear.armorStrength = TBD;
                                                //charAppear.armorWeight = TBD;
                                                break; 
                                            }

                                    }//end of armor switch


                                    break;//game loop break
                                } while (loopChk == "Y");

                                Console.WriteLine("\n");
                
			else if(menuOptChk == "2"){
				Console.WriteLine("Well... I don't know how to say this... but we don't have a save function yet...");
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
						};
						Console.WriteLine("\n");
						
						narraText.introScrawl(narraText.textStore(4));;
						
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
			else{
				Console.WriteLine("Let me guess.... You can't read... Or are you just incapable of following directions?");
			}		
		}
	}
}
