using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdv
{
    public class HumanEntity
    {
        /* HumanEntity will be where several things are created.
         * Any objects or methods associated with Humans/Character/NPC's should be written here.
         * 
         * Below is the asnUsrName method. It's purpose is to localize the definition of the usrName variable.
         */
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
            narraText.introScrawl("\n"+ usrNameCreationA + usrNameCreationB + "\n" + usrNameCreationC + "\n");
            validateName = Console.ReadLine().ToUpper();
            // If the user enters Y, the while loop is obviously bypassed.
            while(validateName == "N")
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
        // I doubt this does anything, but I added it as I was fumbling around trying to get everything working correctly.
        public string usrName = asnUsrName();


    }
}
