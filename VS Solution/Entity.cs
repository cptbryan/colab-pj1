using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
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
        
        public string EntName { get; set; }
        public string EntGender { get; set; }
        public string EntFacialHair { get; set; }
        public string EntHairStyle { get; set; }
        public string EntHairColor { get; set; }
        public string EntSpecies { get; set; }
        public string EntHeight { get; set; }
        public string EntWeight { get; set; }
        public string EntBuild { get; set; }
        

        public HumanEntity()
        {
            
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
            nuChar.EntName = Console.ReadLine();
            //Below I am assigning strings to variables to aid in the use of the introScrawl method.
            string usrNameCreationA = nuChar.EntName + " ..." + " Really?\n";
            string usrNameCreationB = nuChar.EntName + "... That sounds rather effeminate... Whatever... Yolo #Nojudgement\n";
            string usrNameCreationC = "Are you sure that " + nuChar.EntName + " is your name? Y or N";
            string usrNameCreationD = "Vundabar! " + nuChar.EntName + " it is.";
            NarraText.IntroScrawl("\n" + usrNameCreationA + usrNameCreationB + "\n" + usrNameCreationC + "\n");
            validateName = Console.ReadLine().ToUpper();
            // If the user enters Y, the while loop is obviously bypassed.
            while (validateName == "N")
            {
                // Instead of re-assigning (or doing something more clever) I hard coded the responses here.
                NarraText.IntroScrawl("So, what is your name then?");
                nuChar.EntName = Console.ReadLine();
                Console.Write(nuChar.EntName);
                NarraText.IntroScrawl(" ... That sounds rather effeminate... Whatever... Yolo #Nojudgement");
                NarraText.IntroScrawl("Are you sure that ");
                Console.Write(nuChar.EntName);
                NarraText.IntroScrawl(" is your name? Y or N");
                validateName = Console.ReadLine().ToUpper();


            }
            // Here we are insinuating that the username is now saved
            NarraText.IntroScrawl(usrNameCreationD);
            

            return nuChar.EntName;
        }
        #endregion   
        
        #region Character Attribute Creation
        public static string ChrCrtn(string objName)
        {

            //string fileName = "HumanEntity.xml";
            HumanEntity nuChar = new HumanEntity();
            // using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            // {
            //     var XML = new XmlSerializer(typeof(nuChar));



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

                                        nuChar.EntGender = "Male";
                                        //XML.Serialize(stream, nuChar.EntGender = "Male");

                                        break;
                                    }
                                case "2":
                                    {
                                        nuChar.EntGender = "Female";
                                        //XML.Serialize(stream, nuChar.EntGender = "Female");
                                        break;
                                    }
                                default:
                                    {
                                        NarraText.IntroScrawl(NarraText.TextStore(13));
                                        break;
                                    }
                            }
                            return nuChar.EntGender;
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
                                        nuChar.EntFacialHair = "Long and Braided";
                                        //XML.Serialize(stream, nuChar.EntFacialHair = "Long and Braided");
                                        break;
                                    }
                                case "2":
                                    {
                                        nuChar.EntFacialHair = "Big and Bushy";
                                        // XML.Serialize(stream, nuChar.EntFacialHair = "Big and Bushy");
                                        break;
                                    }
                                case "3":
                                    {
                                        nuChar.EntFacialHair = "Wildman";
                                        // XML.Serialize(stream, nuChar.EntFacialHair = "Wildman");
                                        break;
                                    }
                                case "4":
                                    {
                                        nuChar.EntFacialHair = "Fu-Man Chu";
                                        // XML.Serialize(stream, nuChar.EntFacialHair = "Fu-Man Chu");
                                        break;
                                    }
                                case "5":
                                    {
                                        nuChar.EntFacialHair = "C'mon Bruther";
                                        // XML.Serialize(stream, nuChar.EntFacialHair = "C'mon Bruther");
                                        break;
                                    }
                                case "6":
                                    {
                                        nuChar.EntFacialHair = "Mutton Chops";
                                        // XML.Serialize(stream, nuChar.EntFacialHair = "Mutton Chops");
                                        break;
                                    }
                                case "7":
                                    {
                                        nuChar.EntFacialHair = "Thin 'n Dirty";
                                        // XML.Serialize(stream, nuChar.EntFacialHair = "Thin 'n Dirty");
                                        break;
                                    }
                                case "8":
                                    {
                                        nuChar.EntFacialHair = "The Sparrow";
                                        // XML.Serialize(stream, nuChar.EntFacialHair = "The Sparrow");
                                        break;
                                    }
                                case "9":
                                    {
                                        nuChar.EntFacialHair = "Honest Abe";
                                        // XML.Serialize(stream, nuChar.EntFacialHair = "Honest Abe");
                                        break;
                                    }
                                case "10":
                                    {
                                        nuChar.EntFacialHair = "Prepubescent";
                                        // XML.Serialize(stream, nuChar.EntFacialHair = "Prepubescent");
                                        break;
                                    }
                                default:
                                    {
                                        NarraText.IntroScrawl(NarraText.TextStore(13));
                                        break;
                                    }
                            }
                            return nuChar.EntFacialHair;
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
                                        nuChar.EntHairStyle = "Long and Free";
                                        break;
                                    }
                                case "2":
                                    {
                                        nuChar.EntHairStyle = "Soldier";
                                        break;
                                    }
                                case "3":
                                    {
                                        nuChar.EntHairStyle = "Tonsure";
                                        break;
                                    }
                                case "4":
                                    {
                                        nuChar.EntHairStyle = "Top-Knot";
                                        break;
                                    }
                                case "5":
                                    {
                                        nuChar.EntHairStyle = "Shaved";
                                        break;
                                    }
                                case "6":
                                    {
                                        nuChar.EntHairStyle = "Afro";
                                        break;
                                    }
                                case "7":
                                    {
                                        nuChar.EntHairStyle = "Shoulder Length";
                                        break;
                                    }
                                case "8":
                                    {
                                        nuChar.EntHairStyle = "HighTop-Fade";
                                        break;
                                    }
                                case "9":
                                    {
                                        nuChar.EntHairStyle = "Long Dreads";
                                        break;
                                    }
                                case "10":
                                    {
                                        nuChar.EntHairStyle = "Long Shaved Sides";
                                        break;
                                    }
                                default:
                                    {
                                        NarraText.IntroScrawl(NarraText.TextStore(13));
                                        break;
                                    }
                            }
                            return nuChar.EntHairStyle;

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
                                        nuChar.EntHairColor = "Black";
                                        break;
                                    }
                                case "2":
                                    {
                                        nuChar.EntHairColor = "Brown";
                                        break;
                                    }
                                case "3":
                                    {
                                        nuChar.EntHairColor = "Blonde";
                                        break;
                                    }
                                case "4":
                                    {
                                        nuChar.EntHairColor = "Red";
                                        break;
                                    }
                                case "5":
                                    {
                                        nuChar.EntHairColor = "White";
                                        break;
                                    }
                                default:
                                    {
                                        NarraText.IntroScrawl(NarraText.TextStore(13));
                                        break;
                                    }
                            }
                            return nuChar.EntHairColor;

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
                                        nuChar.EntSpecies = "Human";
                                        break;
                                    }
                                case "2":
                                    {
                                        nuChar.EntSpecies = "Dwarf";
                                        break;
                                    }
                                case "3":
                                    {
                                        nuChar.EntSpecies = "Elf";
                                        break;
                                    }
                                default:
                                    {
                                        NarraText.IntroScrawl(NarraText.TextStore(13));
                                        break;
                                    }
                            }
                            return nuChar.EntSpecies;
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
                                        nuChar.EntHeight = "Short";
                                        break;
                                    }
                                case "2":
                                    {
                                        nuChar.EntHeight = "Average";
                                        break;
                                    }
                                case "3":
                                    {
                                        nuChar.EntHeight = "Tall";
                                        break;
                                    }
                                case "4":
                                    {
                                        nuChar.EntHeight = "Giant";
                                        break;
                                    }
                                case "5":
                                    {
                                        nuChar.EntHeight = "How's the weather up there";
                                        break;
                                    }
                                default:
                                    {
                                        NarraText.IntroScrawl(NarraText.TextStore(13));
                                        break;
                                    }
                            }
                            return nuChar.EntHeight;

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
                                        nuChar.EntWeight = "Feather Weight";
                                        break;
                                    }
                                case "2":
                                    {
                                        nuChar.EntWeight = "Average";
                                        break;
                                    }
                                case "3":
                                    {
                                        nuChar.EntWeight = "Big'un";
                                        break;
                                    }
                                case "4":
                                    {
                                        nuChar.EntWeight = "Brick House";
                                        break;
                                    }
                                case "5":
                                    {
                                        nuChar.EntWeight = "Fluffy";
                                        break;
                                    }
                                default:
                                    {
                                        NarraText.IntroScrawl(NarraText.TextStore(13));
                                        break;
                                    }
                            }
                            return nuChar.EntWeight;

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
                                        nuChar.EntBuild = "Struggles to lift soap";
                                        break;
                                    }
                                case "2":
                                    {
                                        nuChar.EntBuild = "Average";
                                        break;
                                    }
                                case "3":
                                    {
                                        nuChar.EntBuild = "Fit";
                                        break;
                                    }
                                case "4":
                                    {
                                        nuChar.EntBuild = "Ripped";
                                        break;
                                    }
                                case "5":
                                    {
                                        nuChar.EntBuild = "Roids";
                                        break;
                                    }
                                default:
                                    {
                                        NarraText.IntroScrawl(NarraText.TextStore(13));
                                        break;
                                    }
                            }
                            return nuChar.EntBuild;

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




