using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdv
{

    /// <summary>
    /// The MonsterEntity Class should contain all variables endemic to the creation or instantiation of a Monster type Entity.
    /// </summary>
    #region Monster Base Class
    public class MonsterEntity
    {
        //variable declaration
        public static string entName { get; set; }
        public static string entGender { get; set; }
        public static string entHair { get; set; }
        public static string entHairStyle { get; set; }
        public static string entHairColor { get; set; }
        public static string entSpecies { get; set; }
        public static string entHeight { get; set; }
        public static string entWeight { get; set; }
        public static string entBuild { get; set; }

        public MonsterEntity()
        {
            //this.entName = entName;
            //this.entGender = entGender;
            //this.entHair = entHair;
            //this.entHairStyle = entHairStyle;
            //this.entHairColor = entHairColor;
            //this.entSpecies = entSpecies;
            //this.entHeight = entHeight;
            //this.entWeight = entWeight;
            //this.entBuild = entBuild;
        }
    }
    #endregion

    /// <summary>
    /// The HumanEntity Class should contain all variables endemic to the creation or instantiation of a Human type Entity.
    /// </summary>
   #region Human Base Class 
    public class HumanEntity
    {

        //variable declaration
        public static string entName { get; set; }
        public static string entGender { get; set; }
        public static string entFacialHair { get; set; }
        public static string entHairStyle { get; set; }
        public static string entHairColor { get; set; }
        public static string entSpecies { get; set; }
        public static string entHeight { get; set; }
        public static string entWeight { get; set; }
        public static string entBuild { get; set; }

        public HumanEntity()
        {
            //this.entName = entName;
            //this.entGender = entGender;
            //this.entFacialHair = entFacialHair;
            //this.entHairStyle = entHairStyle;
            //this.entHairColor = entHairColor;
            //this.entSpecies = entSpecies;
            //this.entHeight = entHeight;
            //this.entWeight = entWeight;
            //this.entBuild = entBuild;
        }


        #region Character Name Creation
        public static string asnUsrName()
        {   /* I moved usrName (which stores the user chosen name) here, from it's previous location in the Main loop.
               I changed the usrInputA variable to validateName (which is used to verify that the user name is what the user intended it to be) to better convey its use.
               */
            string validateName;
            HumanEntity nuChar = new HumanEntity();
                        
            // In the main loop (subject to improvement) call the asnUsrName method/function.
            // Within the asnUsrName method/function, we prompt the user to enter the name of their character, and assign it to the usrName variable.   
            narraText.introScrawl(narraText.textStore(3));//Enter your name
            HumanEntity.entName = Console.ReadLine();
            //Below I am assigning strings to variables to aid in the use of the introScrawl method.
            string usrNameCreationA = HumanEntity.entName + " ..." + " Really?\n";
            string usrNameCreationB = HumanEntity.entName + "... That sounds rather effeminate... Whatever... Yolo #Nojudgement\n";
            string usrNameCreationC = "Are you sure that " + HumanEntity.entName + " is your name? Y or N";
            string usrNameCreationD = "Vundabar! " + HumanEntity.entName + " it is.";
            narraText.introScrawl("\n" + usrNameCreationA + usrNameCreationB + "\n" + usrNameCreationC + "\n");
            validateName = Console.ReadLine().ToUpper();
            // If the user enters Y, the while loop is obviously bypassed.
            while (validateName == "N")
            {
                // Instead of re-assigning (or doing something more clever) I hard coded the responses here.
                narraText.introScrawl("So, what is your name then?");
                HumanEntity.entName = Console.ReadLine();
                Console.Write(HumanEntity.entName);
                narraText.introScrawl(" ... That sounds rather effeminate... Whatever... Yolo #Nojudgement");
                narraText.introScrawl("Are you sure that ");
                Console.Write(HumanEntity.entName);
                narraText.introScrawl(" is your name? Y or N");
                validateName = Console.ReadLine().ToUpper();


            }
            // Here we are insinuating that the username is now saved
            narraText.introScrawl(usrNameCreationD);


            return HumanEntity.entName;
        }
        #endregion   
        
        #region Character Attribute Creation
        public static string chrCrtn(string objName)
        {

            
            HumanEntity HumanEntity = new HumanEntity();
            string failMessage = "You blew it!";
            switch (objName)
            {
                
                case "Gender":
                {
                    narraText.introScrawl(narraText.textStore(4));
                    string usrIn = Console.ReadLine();
                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.entGender = "Male";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.entGender = "Female";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return HumanEntity.entGender;
                }
                case "FacialHair":
                {
                    narraText.introScrawl(narraText.textStore(5));
                    narraText.introScrawl(narraText.textStore(6));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.entFacialHair = "Long and Braided";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.entFacialHair = "Big and Bushy";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.entFacialHair = "Wildman";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.entFacialHair = "Fu-Man Chu";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.entFacialHair = "C'mon Bruther";
                                break;
                            }
                        case "6":
                            {
                                HumanEntity.entFacialHair = "Mutton Chops";
                                break;
                            }
                        case "7":
                            {
                                HumanEntity.entFacialHair = "Thin 'n Dirty";
                                break;
                            }
                        case "8":
                            {
                                HumanEntity.entFacialHair = "The Sparrow";
                                break;
                            }
                        case "9":
                            {
                                HumanEntity.entFacialHair = "Honest Abe";
                                break;
                            }
                        case "10":
                            {
                                HumanEntity.entFacialHair = "Prepubescent";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return HumanEntity.entFacialHair;
                }
                case "HairStyle":
                {
                    narraText.introScrawl(narraText.textStore(7));
                    narraText.introScrawl(narraText.textStore(8));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.entHairStyle = "Long and Free";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.entHairStyle = "Soldier";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.entHairStyle = "Tonsure";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.entHairStyle = "Top-Knot";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.entHairStyle = "Shaved";
                                break;
                            }
                        case "6":
                            {
                                HumanEntity.entHairStyle = "Afro";
                                break;
                            }
                        case "7":
                            {
                                HumanEntity.entHairStyle = "Shoulder Length";
                                break;
                            }
                        case "8":
                            {
                                HumanEntity.entHairStyle = "HighTop-Fade";
                                break;
                            }
                        case "9":
                            {
                                HumanEntity.entHairStyle = "Long Dreads";
                                break;
                            }
                        case "10":
                            {
                                HumanEntity.entHairStyle = "Long Shaved Sides";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return HumanEntity.entHairStyle;

                }
                case "HairColor":
                {
                    narraText.introScrawl(narraText.textStore(9));
                    narraText.introScrawl(narraText.textStore(10));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.entHairColor = "Black";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.entHairColor = "Brown";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.entHairColor = "Blonde";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.entHairColor = "Red";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.entHairColor = "White";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return HumanEntity.entHairColor;

                }
                case "Species":
                {
                    narraText.introScrawl(narraText.textStore(11));
                    narraText.introScrawl(narraText.textStore(12));
                    string usrIn = Console.ReadLine();
                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.entSpecies = "Human";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.entSpecies = "Dwarf";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.entSpecies = "Elf";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return HumanEntity.entSpecies;
                }
                case "Height":
                {
                    narraText.introScrawl(narraText.textStore(13));
                    narraText.introScrawl(narraText.textStore(14));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.entHeight = "Short";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.entHeight = "Average";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.entHeight = "Tall";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.entHeight = "Giant";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.entHeight = "How's the weather up there";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return HumanEntity.entHeight;

                }
                case "Weight":
                {
                    narraText.introScrawl(narraText.textStore(15));
                    narraText.introScrawl(narraText.textStore(16));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.entWeight = "Feather Weight";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.entWeight = "Average";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.entWeight = "Big'un";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.entWeight = "Brick House";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.entWeight = "Fluffy";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return HumanEntity.entWeight;

                }
                case "Build":
                {
                    narraText.introScrawl(narraText.textStore(17));
                    narraText.introScrawl(narraText.textStore(18));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.entBuild = "Struggles to lift soap";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.entBuild = "Average";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.entBuild = "Fit";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.entBuild = "Ripped";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.entBuild = "Roids";
                                break;
                            }
                        default:
                            {
                                narraText.introScrawl(narraText.textStore(13));
                                break;
                            }
                    }
                    return HumanEntity.entBuild;

                }
                default:
                {
                    return failMessage;
                }
                
            }
            

        }
        #endregion
    }
    #endregion
}




