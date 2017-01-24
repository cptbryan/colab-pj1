using System;
namespace TextAdv
{
    public class charAtts
    {
        public string gender;//variable declaration
        public string hairColor;
        public string species;

//============================▼ ▼ ▼ Player Attributes ▼ ▼ ▼ =====================================================================================================>
        
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
        
        //hair color method
        public string hc(string color)
        {
            do
            {
                switch (color)
                {
                    case "1":
                        {
                            hairColor = "Black";
                            break;
                        }
                    case "2":
                        {
                            hairColor = "Brown";
                            break;
                        }
                    case "3":
                        {
                            hairColor = "Blonde";
                            break;
                        }
                    case "4":
                        {
                            hairColor = "Red";
                            break;
                        }
                    case "5":
                        {
                            hairColor = "White";
                            break;
                        }
                    default:
                        {
                            narraText.introScrawl(narraText.textStore(24));
                            break;
                        }
                }
            } while (hairColor == "");
            return hairColor;
        }
        //species selection
        public string playerSpecies(string breed)
        {
            do
            {
                switch (breed)
                {
                    case "1":
                        {
                            species = "Human";
                            break;
                        }
                    case "2":
                        {
                            species = "Dwarf";
                            break;
                        }
                    case "3":
                        {
                            species = "Elf";
                            break;
                        }
                }
            } while (species == "");
            return species;
        }
        public string gen(string gender)//gender method
        {
            do
            {
                switch (gender)
                {
                    case "1":
                        {
                            gender = "Male";
                            break;
                        }
                    case "2":
                        {
                            gender = "Female";
                            break;
                        }
                    default:
                        {
                            narraText.introScrawl(narraText.textStore(22));
                            break;
                        }
                }
            } while (gender == "");
            return gender;
        }
//=============================== ▼ ▼ ▼ NPC Attributes ▼ ▼ ▼ =====================================================================================================>
    }
}

