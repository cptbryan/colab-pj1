using System;
using System.Collections.Generic;
using System.Xml;
/* Just some boiler plate placeholder code.*/

namespace TextAdv
{
	class advMain
	{
        

        public static void Main(string [] args){

            string menuOptChk;

            //Moved the intro section of braces and text into the introVis method
            narraText.introVis();

			narraText.introScrawl(narraText.textStore(1));
        	menuOptChk = Console.ReadLine();


            if (menuOptChk == "1")//start game loop -------------------------------------->
            {
                
                // This is honestly where the "Game Loop" begins. Generally this would be "New Game" on a menu.
                narraText.introScrawl(narraText.textStore(2));
                //Assigning the return value of asnUsrName method to usrName. Might not be necessary, so keep that in mind. 
                string usrName = HumanEntity.asnUsrName();
                                     
                //Begin Character Creation //Character Creation will be moved to Human Entity.cs
                

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
                // Moved the outro "kirby's" and text to the outVis method
                narraText.outVis();
			}
			else{
				Console.WriteLine("Let me guess.... You can't read... Or are you just incapable of following directions?");
			}Console.ReadKey();
            System.Environment.Exit(1);
        }
	}
 }

