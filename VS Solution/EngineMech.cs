using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

/*
     Had an idea relating to our save game functionality.
 Maybe; on assignment of object attributes in HumanEntity.ChrCrtn, we can use Syste.IO.Stream to stream the object's contents to memory and then read that stream to save the information.
 So, within the SaveGame method we would read the stream from memory, to find the object data. We would then serialize that data to XML via XmlSerializer.

 I am going to try just making a stream array of active elements within each attribute assignment and test that. If that doesn't work, I am also going to look a serializing the entire application (i.e. All class fully).
Look into enumeration of the HumanEntity object.
*/
namespace TextAdv
{
    #region Game Systems Class  
    public class EngineMech
    {
        #region New Game Method
        public static void NewGame()
        {
            
            NarraText.IntroScrawl(NarraText.TextStore(2));
            HumanEntity playerChar = new HumanEntity();

            playerChar.EntName = HumanEntity.AsnUsrName();
            playerChar.EntGender = HumanEntity.ChrCrtn("Gender");
            playerChar.EntFacialHair = HumanEntity.ChrCrtn("FacialHair");
            playerChar.EntHairStyle = HumanEntity.ChrCrtn("HairStyle");
            playerChar.EntHairColor = HumanEntity.ChrCrtn("HairColor");
            playerChar.EntSpecies = HumanEntity.ChrCrtn("Species");
            playerChar.EntHeight = HumanEntity.ChrCrtn("Height");
            playerChar.EntWeight = HumanEntity.ChrCrtn("Weight");
            playerChar.EntBuild = HumanEntity.ChrCrtn("Build");

            SaveGame(true, playerChar, "UserState.xml");
            
            Console.ReadLine();
            
        }
        #endregion


        #region Save Game Method *init XML Serializer Write*
        // Currently I am using a bool to define the functionality of saveGame.
        // This is not optimal, but the action of saveGame will only have two modes.
        // First Run: SaveGame has not been run in recent context OR Second Run: SaveGame has been run in recent context. 


        public static void SaveGame<T>(bool firstRun, T data, string xml)
        {
            if (firstRun)
            {
                //serialize objects/ data
                //If firstRun is true, prompt the user to decide whether or not to save
                NarraText.IntroScrawl(NarraText.TextStore(27));
                string choice = Console.ReadLine().ToUpper();
                firstRun = false;

                // User choice is Y, recursively run saveGame method specifiying false parameter
                if (choice == "Y")
                {
                    SaveGame<T>(false, data, xml);
                }



            }

            var serializer = new XmlSerializer(typeof(T));

            TextWriter writer = new StreamWriter(xml);

            serializer.Serialize(writer, data);
            writer.Close();
        }
        #endregion

        #region Load Game Method *init XML Serializer Read*

        public static T LoadGame<T>(string xml)
        {
            // Deserailize data
            var serializer = new XmlSerializer(typeof(T));

            FileStream fileName = new FileStream(xml, FileMode.OpenOrCreate);

            using (TextReader reader = new StreamReader(fileName))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
        
        #endregion

        #region Options Menu Method
        public static void OptionsMenu()
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
                         
            //narraText.introScrawl(narraText.textStore(29));
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
        #endregion

        #region Help Menu Method
        public static string HelpMenu()
        {
            string x = "Sorry";
            NarraText.IntroScrawl(NarraText.TextStore(30));
            return x;
        }
        #endregion
        
        #region Main Menu *Can call all other menu items*
        public static string MainMenu(string menuOptChk)
        {
            
            if (menuOptChk == "")
            {
                string gameMenu = "\n1-New Game\n2-Load Game\n3-Options\n4-Exit";
                NarraText.IntroScrawl(gameMenu);
                menuOptChk = Console.ReadLine();
                switch (menuOptChk)
                {
                    case "1":
                        {
                            NewGame();
                            break;
                        }
                    case "2":
                        {
                            LoadGame<HumanEntity>("UserState.xml");
                            break;
                        }
                    case "3":
                        {
                            OptionsMenu();
                            break;
                        }
                    case "4":
                        {
                            NarraText.OutVis();
                            break;
                        }
                    default:
                        {
                            Console.Write("The value you entered does not represent any known item.");
                            break;
                        }

                }
                return menuOptChk;
            }
            else if(menuOptChk != "")
            {
                string gameMenu = "\n1-Save Game\n2-Load Game\n3-Options\n4-Help\n5-Exit";
                switch (menuOptChk)
                {
                    case "1":
                        {
                            //SaveGame(true, HumanEntity,  );
                            break;
                        }
                    case "2":
                        {
                            //LoadGame();
                            break;
                        }
                    case "3":
                        {
                            OptionsMenu();
                            break;
                        }
                    case "4":
                        {
                            HelpMenu();
                            break;
                        }
                    case "5":
                        {
                            NarraText.OutVis();
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
        #endregion
    }
    #endregion

}
