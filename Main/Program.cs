using System;
/* Just some boiler plate placeholder code.*/

namespace TextAdv
{
	class advMain
	{
		public static void Main(string [] args){
			
		string x;	
			

			do{

			        Console.WriteLine("Enter a character");
			        x  = Console.ReadLine();
			        x.ToUpper();
				Console.WriteLine(x);
				


			}while(x != "Y");
			
		}
	}


}
