using System;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TextAdv
{
    [Serializable()]
    public class EngineMech
    {
        public static void newGame()
        {
            
            HumanEntity.asnUsrName();
            HumanEntity.chrCrtn("gender");
            HumanEntity.chrCrtn("hairColor");
            HumanEntity.chrCrtn("species");

        }

        public static void saveGame()
        {
            //serialize objects/data
            
            narraText.introScrawl(narraText.textStore(15));
            Console.ReadKey();


        }

        public static void loadGame()
        {
            //load serailized data
            
            narraText.introScrawl(narraText.textStore(16));
            
            Console.ReadKey();
            
        }

        public static void optionsMenu()
        {
            string usrMod;
            int orgConWidth, maxConWidth, usrConWidth;
            int orgConHeight, maxConHeight, usrConHeight;

            orgConWidth = Console.WindowWidth;
            orgConHeight = Console.WindowHeight;
            maxConWidth = Console.LargestWindowWidth;
            maxConHeight = Console.LargestWindowHeight;
            Console.WriteLine("FOR DEBUG-- WINDOW WIDTH {0} WINDOW HEIGHT {1}", orgConWidth, orgConHeight);
            Console.WriteLine("FOR DEBUG-- WINDOW WIDTH {0} WINDOW HEIGHT {1}", maxConWidth, maxConHeight);
            Console.WriteLine("Would you like to change these values? (Max of 90 for both values) Y or N");
            usrMod = Console.ReadLine().ToUpper();

            switch (usrMod)
            {
                case "Y":
                    {
                        Console.WriteLine("Width: ");
                        usrConWidth = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Height: ");
                        usrConHeight = Convert.ToInt32(Console.ReadLine());
                        Console.SetWindowSize(usrConWidth, usrConHeight);
                        break;
                    }
                case "N":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No changes will be made.");
                        break;
                    }


            }
                         
            //narraText.introScrawl(narraText.textStore(17));
            //Console.ReadKey();
            
           
            
            /*Read/write user modifiable options to xml
            
                This will consit of 
                 - Background Color
                 - Text Color
                 - Text Scroll Speed
                 - Font Size
                 - Turn Intro on or off
                 - ?Any other Ideas?
            */

        }

        public static string helpMenu()
        {
            string x = "Sorry";
            narraText.introScrawl(narraText.textStore(18));
            return x;
        }

        public static string mainMenu(string menuOptChk)
        {
            
            if (menuOptChk == "")
            {
                string gameMenu = "\n1-New Game\n2-Load Game\n3-Options\n4-Exit";
                narraText.introScrawl(gameMenu);
                menuOptChk = Console.ReadLine();
                switch (menuOptChk)
                {
                    case "1":
                        {
                            newGame();
                            break;
                        }
                    case "2":
                        {
                            loadGame();
                            break;
                        }
                    case "3":
                        {
                            optionsMenu();
                            break;
                        }
                    case "4":
                        {
                            narraText.outVis();
                            break;
                        }
                    default:
                        {
                            Console.Write("The value you entered does not represent any known item.");
                            break;
                        }

                }
                return gameMenu;
            }
            else if(menuOptChk != "")
            {
                string gameMenu = "\n1-Save Game\n2-Load Game\n3-Options\n4-Help\n5-Exit";
                switch (menuOptChk)
                {
                    case "1":
                        {
                            saveGame();
                            break;
                        }
                    case "2":
                        {
                            loadGame();
                            break;
                        }
                    case "3":
                        {
                            optionsMenu();
                            break;
                        }
                    case "4":
                        {
                            helpMenu();
                            break;
                        }
                    case "5":
                        {
                            narraText.outVis();
                            break;
                        }
                    default:
                        {
                            Console.Write("The value you entered does not represent any known item.");
                            break;
                        }

                }
                
                return gameMenu;
            }
            return menuOptChk;
            

            /*In game menu for user to access.

                This will consist of 
                 - New Game (if not already in loop)
                 - Save Game
                 - Options
                 - Help
                 - Exit
            */

        }
    }
}
