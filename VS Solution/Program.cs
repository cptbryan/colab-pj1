using System;
using System.Collections.Generic;

/* Just some boiler plate placeholder code.*/

namespace TextAdv
{
    
    class advMain
    {
        public static string menuOptChk = "";

        public static void Main(string[] args)
        {
            EngineMech.OptionsMenu();
            //Moved the intro section of braces and text into the introVis method
            NarraText.IntroVis();
                
           
            NarraText.IntroScrawl(NarraText.TextStore(1));
            EngineMech.MainMenu(menuOptChk);
            var playerChar = EngineMech.LoadGame<HumanEntity>("UserState.xml");
            Console.WriteLine("Okay {0}... So I suppose we shall now begin your perilous affliction!", playerChar.EntName);
            NarraText.IntroScrawl(NarraText.TextStore(31));

            Console.ReadLine();
                        

        }
    }
}
