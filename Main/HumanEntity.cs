using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdv
{
    public class HumanEntity
    {
        
        public static string asnUsrName()
        {
            string usrName;
            string usrInputA;
                      
            usrName = Console.ReadLine();
            string usrNameCreationA = usrName + " ..." + " Really?\n";
            string usrNameCreationB = usrName + "... That sounds rather effeminate... Whatever... Yolo #Nojudgement\n";
            string usrNameCreationC = "Are you sure that " + usrName + " is your name? Y or N";
            string usrNameCreationD = "Vundabar! " + usrName + " it is.";
            narraText.introScrawl("\n"+ usrNameCreationA + usrNameCreationB + "\n" + usrNameCreationC + "\n");
            usrInputA = Console.ReadLine().ToUpper();

            while(usrInputA == "N")
            {
                narraText.introScrawl("So, what is your name then?");
                usrName = Console.ReadLine();
                Console.Write(usrName);
                narraText.introScrawl(" ... That sounds rather effeminate... Whatever... Yolo #Nojudgement");
                narraText.introScrawl("Are you sure that ");
                Console.Write(usrName);
                narraText.introScrawl(" is your name? Y or N");
                usrInputA = Console.ReadLine().ToUpper();
                

            }

            narraText.introScrawl(usrNameCreationD);


            return usrName;
        }

        public string usrName = asnUsrName();


    }
}
