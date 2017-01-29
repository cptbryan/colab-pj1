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

    }

    /* HumanEntity will be where any objects or methods associated with Humans/Character/NPC's should be written.*/
    public class HumanEntity
    {
        
        //variable declaration
        public string gender;
        public string hairColor;
        public string species;

        public string Gender//accessors
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string HairColor
        {
            get
            {
                return hairColor;
            }
            set
            {
                hairColor = value;
            }
        }

        public string Species
        {
            get
            {
                return species;
            }
            set
            {
                species = value;
            }
        }
        
          
        // Below is the asnUsrName method. It's purpose is to localize the definition of the usrName variable.
        public static string asnUsrName()
        {   /* I moved usrName (which stores the user chosen name) here, from it's previous location in the Main loop.
               I changed the usrInputA variable to validateName (which is used to verify that the user name is what the user intended it to be) to better convey its use.
               */
            string usrName;
            string validateName;

            // In the main loop (subject to improvement) call the asnUsrName method/function.
            // Within the asnUsrName method/function, we prompt the user to enter the name of their character, and assign it to the usrName variable.   
            narraText.introScrawl(narraText.textStore(3));//Enter your name
            usrName = Console.ReadLine();
            //Below I am assigning strings to variables to aid in the use of the introScrawl method.
            string usrNameCreationA = usrName + " ..." + " Really?\n";
            string usrNameCreationB = usrName + "... That sounds rather effeminate... Whatever... Yolo #Nojudgement\n";
            string usrNameCreationC = "Are you sure that " + usrName + " is your name? Y or N";
            string usrNameCreationD = "Vundabar! " + usrName + " it is.";
            narraText.introScrawl("\n" + usrNameCreationA + usrNameCreationB + "\n" + usrNameCreationC + "\n");
            validateName = Console.ReadLine().ToUpper();
            // If the user enters Y, the while loop is obviously bypassed.
            while (validateName == "N")
            {
                // Instead of re-assigning (or doing something more clever) I hard coded the responses here.
                narraText.introScrawl("So, what is your name then?");
                usrName = Console.ReadLine();
                Console.Write(usrName);
                narraText.introScrawl(" ... That sounds rather effeminate... Whatever... Yolo #Nojudgement");
                narraText.introScrawl("Are you sure that ");
                Console.Write(usrName);
                narraText.introScrawl(" is your name? Y or N");
                validateName = Console.ReadLine().ToUpper();


            }
            // Here we are insinuating that the username is now saved
            narraText.introScrawl(usrNameCreationD);


            return usrName;
        }
                
        // Below is the chrCrtn method. It's purpose is to localize the switch cases related to character creation.
        public static string chrCrtn(string objName, string usrIn)
        {
            string failMessage = "You blew it!";
            switch (objName)
            {

                case "hairColor":
                    {
                        HumanEntity obj = new HumanEntity();
                        switch (usrIn)
                        {
                            case "1":
                                {
                                    obj.hairColor = "Black";
                                    break;
                                }
                            case "2":
                                {
                                    obj.hairColor = "Brown";
                                    break;
                                }
                            case "3":
                                {
                                    obj.hairColor = "Blonde";
                                    break;
                                }
                            case "4":
                                {
                                    obj.hairColor = "Red";
                                    break;
                                }
                            case "5":
                                {
                                    obj.hairColor = "White";
                                    break;
                                }
                            default:
                                {
                                    narraText.introScrawl(narraText.textStore(6));
                                    break;
                                }
                        }
                        return obj.hairColor;

                    }

                case "Gender":
                    {
                        HumanEntity obj = new HumanEntity();
                        switch (usrIn)
                        {
                            case "1":
                                {
                                    obj.gender = "Male";
                                    break;
                                }
                            case "2":
                                {
                                    obj.gender = "Female";
                                    break;
                                }
                            default:
                                {
                                    narraText.introScrawl(narraText.textStore(13));
                                    break;
                                }
                        }
                        return obj.gender;
                    }
                case "species":
                    {
                        HumanEntity obj = new HumanEntity();
                        switch (usrIn)
                        {
                            case "1":
                                {
                                    obj.species = "Human";
                                    break;
                                }
                            case "2":
                                {
                                    obj.species = "Dwarf";
                                    break;
                                }
                            case "3":
                                {
                                    obj.species = "Elf";
                                    break;
                                }
                        }
                        return obj.species;
                    }
                default:
                    {
                        return failMessage;
                    }
            }


        }
       
    }
}

