using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdv
{
    
    /* MonsterEntity will be where any objects or methods associated with Monters/Enemies/Monster NPC's should be written.*/

    public class MonsterEntity
    {
        //variable declaration
        public string entName { get; set; }
        private string entGender { get; set; }
        private string entHair { get; set; }
        private string entHairStyle { get; set; }
        private string entHairColor { get; set; }
        private string entSpecies { get; set; }
        private string entHeight { get; set; }
        private string entWeight { get; set; }
        private string entBuild { get; set; }

        public MonsterEntity()
        {
            this.entName = entName;
            this.entGender = entGender;
            this.entHair = entHair;
            this.entHairStyle = entHairStyle;
            this.entHairColor = entHairColor;
            this.entSpecies = entSpecies;
            this.entHeight = entHeight;
            this.entWeight = entWeight;
            this.entBuild = entBuild;
        }
    }

    /* HumanEntity will be where any objects or methods associated with Humans/Character/NPC's should be written.*/
    
    public class HumanEntity
    {

        //variable declaration
        public string entName { get; set; }
        public string entGender { get; set; }
        public string entFacialHair { get; set; }
        public string entHairStyle { get; set; }
        public string entHairColor { get; set; }
        public string entSpecies { get; set; }
        public string entHeight { get; set; }
        public string entWeight { get; set; }
        public string entBuild { get; set; }

        public HumanEntity()
        {
            this.entName = entName;
            this.entGender = entGender;
            this.entFacialHair = entFacialHair;
            this.entHairStyle = entHairStyle;
            this.entHairColor = entHairColor;
            this.entSpecies = entSpecies;
            this.entHeight = entHeight;
            this.entWeight = entWeight;
            this.entBuild = entBuild;
        }


        // Below is the asnUsrName method. It's purpose is to localize the definition of the usrName variable.
        public static string asnUsrName()
        {   /* I moved usrName (which stores the user chosen name) here, from it's previous location in the Main loop.
               I changed the usrInputA variable to validateName (which is used to verify that the user name is what the user intended it to be) to better convey its use.
               */
            string validateName;
            HumanEntity nuChar = new HumanEntity();
                        
            // In the main loop (subject to improvement) call the asnUsrName method/function.
            // Within the asnUsrName method/function, we prompt the user to enter the name of their character, and assign it to the usrName variable.   
            narraText.introScrawl(narraText.textStore(3));//Enter your name
            nuChar.entName = Console.ReadLine();
            //Below I am assigning strings to variables to aid in the use of the introScrawl method.
            string usrNameCreationA = nuChar.entName + " ..." + " Really?\n";
            string usrNameCreationB = nuChar.entName + "... That sounds rather effeminate... Whatever... Yolo #Nojudgement\n";
            string usrNameCreationC = "Are you sure that " + nuChar.entName + " is your name? Y or N";
            string usrNameCreationD = "Vundabar! " + nuChar.entName + " it is.";
            narraText.introScrawl("\n" + usrNameCreationA + usrNameCreationB + "\n" + usrNameCreationC + "\n");
            validateName = Console.ReadLine().ToUpper();
            // If the user enters Y, the while loop is obviously bypassed.
            while (validateName == "N")
            {
                // Instead of re-assigning (or doing something more clever) I hard coded the responses here.
                narraText.introScrawl("So, what is your name then?");
                nuChar.entName = Console.ReadLine();
                Console.Write(nuChar.entName);
                narraText.introScrawl(" ... That sounds rather effeminate... Whatever... Yolo #Nojudgement");
                narraText.introScrawl("Are you sure that ");
                Console.Write(nuChar.entName);
                narraText.introScrawl(" is your name? Y or N");
                validateName = Console.ReadLine().ToUpper();


            }
            // Here we are insinuating that the username is now saved
            narraText.introScrawl(usrNameCreationD);


            return nuChar.entName;
        }
                
        // Below is the chrCrtn method. It's purpose is to localize the switch cases related to character creation.
        public static string chrCrtn(string objName)
        {
            
            
            string failMessage = "You blew it!";
            switch (objName)
            {

                case "Gender":
                {
                    narraText.introScrawl(narraText.textStore(4));
                    string usrIn = Console.ReadLine();
                    HumanEntity nuChar = new HumanEntity();
                    switch (usrIn)
                    {
                        case "1":
                            {
                                nuChar.entGender = "Male";
                                break;
                            }
                        case "2":
                            {
                                nuChar.entGender = "Female";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return nuChar.entGender;
                }
                case "FacialHair":
                {
                    narraText.introScrawl(narraText.textStore(5));
                    narraText.introScrawl(narraText.textStore(6));
                    string usrIn = Console.ReadLine();

                    HumanEntity nuChar = new HumanEntity();
                    switch (usrIn)
                    {
                        case "1":
                            {
                                nuChar.entFacialHair = "Long and Braided";
                                break;
                            }
                        case "2":
                            {
                                nuChar.entFacialHair = "Big and Bushy";
                                break;
                            }
                        case "3":
                            {
                                nuChar.entFacialHair = "Wildman";
                                break;
                            }
                        case "4":
                            {
                                nuChar.entFacialHair = "Fu-Man Chu";
                                break;
                            }
                        case "5":
                            {
                                nuChar.entFacialHair = "C'mon Bruther";
                                break;
                            }
                        case "6":
                            {
                                nuChar.entFacialHair = "Mutton Chops";
                                break;
                            }
                        case "7":
                            {
                                nuChar.entFacialHair = "Thin 'n Dirty";
                                break;
                            }
                        case "8":
                            {
                                nuChar.entFacialHair = "The Sparrow";
                                break;
                            }
                        case "9":
                            {
                                nuChar.entFacialHair = "Honest Abe";
                                break;
                            }
                        case "10":
                            {
                                nuChar.entFacialHair = "Prepubescent";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return nuChar.entFacialHair;
                }
                case "HairStyle":
                {
                    narraText.introScrawl(narraText.textStore(7));
                    narraText.introScrawl(narraText.textStore(8));
                    string usrIn = Console.ReadLine();

                    HumanEntity nuChar = new HumanEntity();
                    switch (usrIn)
                    {
                        case "1":
                            {
                                nuChar.entHairStyle = "Long and Free";
                                break;
                            }
                        case "2":
                            {
                                nuChar.entHairStyle = "Soldier";
                                break;
                            }
                        case "3":
                            {
                                nuChar.entHairStyle = "Tonsure";
                                break;
                            }
                        case "4":
                            {
                                nuChar.entHairStyle = "Top-Knot";
                                break;
                            }
                        case "5":
                            {
                                nuChar.entHairStyle = "Shaved";
                                break;
                            }
                        case "6":
                            {
                                nuChar.entHairStyle = "Afro";
                                break;
                            }
                        case "7":
                            {
                                nuChar.entHairStyle = "Shoulder Length";
                                break;
                            }
                        case "8":
                            {
                                nuChar.entHairStyle = "HighTop-Fade";
                                break;
                            }
                        case "9":
                            {
                                nuChar.entHairStyle = "Long Dreads";
                                break;
                            }
                        case "10":
                            {
                                nuChar.entHairStyle = "Long Shaved Sides";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return nuChar.entHairStyle;

                }
                case "HairColor":
                {
                    narraText.introScrawl(narraText.textStore(9));
                    narraText.introScrawl(narraText.textStore(10));
                    string usrIn = Console.ReadLine();

                    HumanEntity nuChar = new HumanEntity();
                    switch (usrIn)
                    {
                        case "1":
                            {
                                nuChar.entHairColor = "Black";
                                break;
                            }
                        case "2":
                            {
                                nuChar.entHairColor = "Brown";
                                break;
                            }
                        case "3":
                            {
                                nuChar.entHairColor = "Blonde";
                                break;
                            }
                        case "4":
                            {
                                nuChar.entHairColor = "Red";
                                break;
                            }
                        case "5":
                            {
                                nuChar.entHairColor = "White";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return nuChar.entHairColor;

                }
                case "Species":
                {
                    narraText.introScrawl(narraText.textStore(11));
                    narraText.introScrawl(narraText.textStore(12));
                    string usrIn = Console.ReadLine();
                    HumanEntity nuChar = new HumanEntity();
                    switch (usrIn)
                    {
                        case "1":
                            {
                                nuChar.entSpecies = "Human";
                                break;
                            }
                        case "2":
                            {
                                nuChar.entSpecies = "Dwarf";
                                break;
                            }
                        case "3":
                            {
                                nuChar.entSpecies = "Elf";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return nuChar.entSpecies;
                }
                case "Height":
                {
                    narraText.introScrawl(narraText.textStore(13));
                    narraText.introScrawl(narraText.textStore(14));
                    string usrIn = Console.ReadLine();

                    HumanEntity nuChar = new HumanEntity();
                    switch (usrIn)
                    {
                        case "1":
                            {
                                nuChar.entHeight = "Short";
                                break;
                            }
                        case "2":
                            {
                                nuChar.entHeight = "Average";
                                break;
                            }
                        case "3":
                            {
                                nuChar.entHeight = "Tall";
                                break;
                            }
                        case "4":
                            {
                                nuChar.entHeight = "Giant";
                                break;
                            }
                        case "5":
                            {
                                nuChar.entHeight = "How's the weather up there";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return nuChar.entHeight;

                }
                case "Weight":
                {
                    narraText.introScrawl(narraText.textStore(15));
                    narraText.introScrawl(narraText.textStore(16));
                    string usrIn = Console.ReadLine();

                    HumanEntity nuChar = new HumanEntity();
                    switch (usrIn)
                    {
                        case "1":
                            {
                                nuChar.entWeight = "Feather Weight";
                                break;
                            }
                        case "2":
                            {
                                nuChar.entWeight = "Average";
                                break;
                            }
                        case "3":
                            {
                                nuChar.entWeight = "Big'un";
                                break;
                            }
                        case "4":
                            {
                                nuChar.entWeight = "Brick House";
                                break;
                            }
                        case "5":
                            {
                                nuChar.entWeight = "Fluffy";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return nuChar.entWeight;

                }
                case "Build":
                {
                    narraText.introScrawl(narraText.textStore(17));
                    narraText.introScrawl(narraText.textStore(18));
                    string usrIn = Console.ReadLine();

                    HumanEntity nuChar = new HumanEntity();
                    switch (usrIn)
                    {
                        case "1":
                            {
                                nuChar.entBuild = "Struggles to lift soap";
                                break;
                            }
                        case "2":
                            {
                                nuChar.entBuild = "Average";
                                break;
                            }
                        case "3":
                            {
                                nuChar.entBuild = "Fit";
                                break;
                            }
                        case "4":
                            {
                                nuChar.entBuild = "Ripped";
                                break;
                            }
                        case "5":
                            {
                                nuChar.entBuild = "Roids";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return nuChar.entBuild;

                }
                default:
                {
                    return failMessage;
                }
                
            }


        }
       
    }
}




