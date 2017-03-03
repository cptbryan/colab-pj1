using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TextAdv
{

    /// <summary>
    /// The MonsterEntity Class should contain all variables endemic to the creation or instantiation of a Monster type Entity.
    /// </summary>
    #region Monster Base Class
    public class MonsterEntity
    {
        //variable declaration
        public static string EntName { get; set; }
        public static string EntGender { get; set; }
        public static string EntHair { get; set; }
        public static string EntHairStyle { get; set; }
        public static string EntHairColor { get; set; }
        public static string EntSpecies { get; set; }
        public static string EntHeight { get; set; }
        public static string EntWeight { get; set; }
        public static string EntBuild { get; set; }

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
    [Serializable]
    public class HumanEntity
    {

        //variable declaration
        
        public static string EntName { get; set; }
        public static string EntGender { get; set; }
        public static string EntFacialHair { get; set; }
        public static string EntHairStyle { get; set; }
        public static string EntHairColor { get; set; }
        public static string EntSpecies { get; set; }
        public static string EntHeight { get; set; }
        public static string EntWeight { get; set; }
        public static string EntBuild { get; set; }
        

        public HumanEntity()
        {
            //HumanEntity.EntName = EntName;
            //HumanEntity.EntGender = EntGender;
            //HumanEntity.EntFacialHair = EntFacialHair;
            //HumanEntity.EntHairStyle = EntHairStyle;
            //HumanEntity.EntHairColor = EntHairColor;
            //HumanEntity.EntSpecies = EntSpecies;
            //HumanEntity.EntHeight = EntHeight;
            //HumanEntity.EntWeight = EntWeight;
            //HumanEntity.EntBuild = EntBuild;
        }

        


        #region Character Name Creation
        
        public static string AsnUsrName()
        {   /* I moved usrName (which stores the user chosen name) here, from it's previous location in the Main loop.
               I changed the usrInputA variable to validateName (which is used to verify that the user name is what the user intended it to be) to better convey its use.
               */
            string validateName;
            HumanEntity nuChar = new HumanEntity();
                        
            // In the main loop (subject to improvement) call the asnUsrName method/function.
            // Within the asnUsrName method/function, we prompt the user to enter the name of their character, and assign it to the usrName variable.   
            NarraText.IntroScrawl(NarraText.TextStore(3));//Enter your name
            HumanEntity.EntName = Console.ReadLine();
            //Below I am assigning strings to variables to aid in the use of the introScrawl method.
            string usrNameCreationA = HumanEntity.EntName + " ..." + " Really?\n";
            string usrNameCreationB = HumanEntity.EntName + "... That sounds rather effeminate... Whatever... Yolo #Nojudgement\n";
            string usrNameCreationC = "Are you sure that " + HumanEntity.EntName + " is your name? Y or N";
            string usrNameCreationD = "Vundabar! " + HumanEntity.EntName + " it is.";
            NarraText.IntroScrawl("\n" + usrNameCreationA + usrNameCreationB + "\n" + usrNameCreationC + "\n");
            validateName = Console.ReadLine().ToUpper();
            // If the user enters Y, the while loop is obviously bypassed.
            while (validateName == "N")
            {
                // Instead of re-assigning (or doing something more clever) I hard coded the responses here.
                NarraText.IntroScrawl("So, what is your name then?");
                HumanEntity.EntName = Console.ReadLine();
                Console.Write(HumanEntity.EntName);
                NarraText.IntroScrawl(" ... That sounds rather effeminate... Whatever... Yolo #Nojudgement");
                NarraText.IntroScrawl("Are you sure that ");
                Console.Write(HumanEntity.EntName);
                NarraText.IntroScrawl(" is your name? Y or N");
                validateName = Console.ReadLine().ToUpper();


            }
            // Here we are insinuating that the username is now saved
            NarraText.IntroScrawl(usrNameCreationD);
            

            return HumanEntity.EntName;
        }
        #endregion   
        
        #region Character Attribute Creation
        public static string ChrCrtn(string objName)
        {

            
            HumanEntity HumanEntity = new HumanEntity();
            string failMessage = "You blew it!";
            switch (objName)
            {
                
                case "Gender":
                {
                    NarraText.IntroScrawl(NarraText.TextStore(4));
                    string usrIn = Console.ReadLine();
                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.EntGender = "Male";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.EntGender = "Female";
                                break;
                            }
                        default:
                            {
                                NarraText.IntroScrawl(NarraText.TextStore(13));
                                break;
                            }
                    }
                    return HumanEntity.EntGender;
                }
                case "FacialHair":
                {
                    NarraText.IntroScrawl(NarraText.TextStore(5));
                    NarraText.IntroScrawl(NarraText.TextStore(6));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.EntFacialHair = "Long and Braided";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.EntFacialHair = "Big and Bushy";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.EntFacialHair = "Wildman";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.EntFacialHair = "Fu-Man Chu";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.EntFacialHair = "C'mon Bruther";
                                break;
                            }
                        case "6":
                            {
                                HumanEntity.EntFacialHair = "Mutton Chops";
                                break;
                            }
                        case "7":
                            {
                                HumanEntity.EntFacialHair = "Thin 'n Dirty";
                                break;
                            }
                        case "8":
                            {
                                HumanEntity.EntFacialHair = "The Sparrow";
                                break;
                            }
                        case "9":
                            {
                                HumanEntity.EntFacialHair = "Honest Abe";
                                break;
                            }
                        case "10":
                            {
                                HumanEntity.EntFacialHair = "Prepubescent";
                                break;
                            }
                        default:
                            {
                                NarraText.IntroScrawl(NarraText.TextStore(13));
                                break;
                            }
                    }
                    return HumanEntity.EntFacialHair;
                }
                case "HairStyle":
                {
                    NarraText.IntroScrawl(NarraText.TextStore(7));
                    NarraText.IntroScrawl(NarraText.TextStore(8));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.EntHairStyle = "Long and Free";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.EntHairStyle = "Soldier";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.EntHairStyle = "Tonsure";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.EntHairStyle = "Top-Knot";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.EntHairStyle = "Shaved";
                                break;
                            }
                        case "6":
                            {
                                HumanEntity.EntHairStyle = "Afro";
                                break;
                            }
                        case "7":
                            {
                                HumanEntity.EntHairStyle = "Shoulder Length";
                                break;
                            }
                        case "8":
                            {
                                HumanEntity.EntHairStyle = "HighTop-Fade";
                                break;
                            }
                        case "9":
                            {
                                HumanEntity.EntHairStyle = "Long Dreads";
                                break;
                            }
                        case "10":
                            {
                                HumanEntity.EntHairStyle = "Long Shaved Sides";
                                break;
                            }
                        default:
                            {
                                NarraText.IntroScrawl(NarraText.TextStore(13));
                                break;
                            }
                    }
                    return HumanEntity.EntHairStyle;

                }
                case "HairColor":
                {
                    NarraText.IntroScrawl(NarraText.TextStore(9));
                    NarraText.IntroScrawl(NarraText.TextStore(10));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.EntHairColor = "Black";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.EntHairColor = "Brown";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.EntHairColor = "Blonde";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.EntHairColor = "Red";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.EntHairColor = "White";
                                break;
                            }
                        default:
                            {
                                NarraText.IntroScrawl(NarraText.TextStore(13));
                                break;
                            }
                    }
                    return HumanEntity.EntHairColor;

                }
                case "Species":
                {
                    NarraText.IntroScrawl(NarraText.TextStore(11));
                    NarraText.IntroScrawl(NarraText.TextStore(12));
                    string usrIn = Console.ReadLine();
                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.EntSpecies = "Human";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.EntSpecies = "Dwarf";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.EntSpecies = "Elf";
                                break;
                            }
                        default:
                            {
                                NarraText.IntroScrawl(NarraText.TextStore(13));
                                break;
                            }
                    }
                    return HumanEntity.EntSpecies;
                }
                case "Height":
                {
                    NarraText.IntroScrawl(NarraText.TextStore(13));
                    NarraText.IntroScrawl(NarraText.TextStore(14));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.EntHeight = "Short";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.EntHeight = "Average";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.EntHeight = "Tall";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.EntHeight = "Giant";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.EntHeight = "How's the weather up there";
                                break;
                            }
                        default:
                            {
                                NarraText.IntroScrawl(NarraText.TextStore(13));
                                break;
                            }
                    }
                    return HumanEntity.EntHeight;

                }
                case "Weight":
                {
                    NarraText.IntroScrawl(NarraText.TextStore(15));
                    NarraText.IntroScrawl(NarraText.TextStore(16));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.EntWeight = "Feather Weight";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.EntWeight = "Average";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.EntWeight = "Big'un";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.EntWeight = "Brick House";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.EntWeight = "Fluffy";
                                break;
                            }
                        default:
                            {
                                NarraText.IntroScrawl(NarraText.TextStore(13));
                                break;
                            }
                    }
                    return HumanEntity.EntWeight;

                }
                case "Build":
                {
                    NarraText.IntroScrawl(NarraText.TextStore(17));
                    NarraText.IntroScrawl(NarraText.TextStore(18));
                    string usrIn = Console.ReadLine();

                    
                    switch (usrIn)
                    {
                        case "1":
                            {
                                HumanEntity.EntBuild = "Struggles to lift soap";
                                break;
                            }
                        case "2":
                            {
                                HumanEntity.EntBuild = "Average";
                                break;
                            }
                        case "3":
                            {
                                HumanEntity.EntBuild = "Fit";
                                break;
                            }
                        case "4":
                            {
                                HumanEntity.EntBuild = "Ripped";
                                break;
                            }
                        case "5":
                            {
                                HumanEntity.EntBuild = "Roids";
                                break;
                            }
                        default:
                            {
                                NarraText.IntroScrawl(NarraText.TextStore(13));
                                break;
                            }
                    }
                    return HumanEntity.EntBuild;

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




