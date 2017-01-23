using System;
namespace TextAdv
{
    public class charAtts
    {
        public string gender;//variable declaration
        public string hairColor;
        public string startArmor;
        public int armorStrength;
        public string startWeapon;
        public string startClass;
        //------------------------------------------>
        public string Gender//accessors
        {//these are required when calling instatiations of the class. They obtain the value for the object for example
            get//("get" reads the usier input value assigned for gender in the object and returns that value to the "set" value
            {//which then assigns that variable to a generic term "value." As far as an indepth explanation, it is beyond my knowledge.
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string Armor
        {
            get
            {
                return startArmor;
            }
            set
            {
                startArmor = value;
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
        public string StartClass
        {
            get
            {
                return startClass;
            }
            set
            {
                startClass = value;
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
        public string gen(string gender)//gender function
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
        //starting class function
        public string startingClass(string beginClass)//move on later build
        {
            do//startClass do while and switch start --------------->
            {
                switch (beginClass)//The data stored in the armor switch, class switch, and weapon switch needs
                                   //to be migrated from the charAppear object to a "TBD" object.
                {
                    case "1":
                        {
                            startClass = "Knight";
                            //charAppear.startWeapon = "Sword";
                            //charAppear.startWeapon = "Rusty Bronze Sword";
                            break;

                        }
                    case "2":
                        {
                            startClass = "Archer";
                            //charAppear.startWeapon = "Bow";
                            //charAppear.startWeapon = "Cheap Pine Bow";
                            break;
                        }
                    case "3":
                        {
                            startClass = "Mage";
                            //charAppear.startWeapon = "Basic Spell";
                            //charAppear.startWeapon = "Fury of the Grass";
                            break;
                        }
                    default:
                        {
                            narraText.introScrawl(narraText.textStore(26));
                            break;
                        }

                }
            } while (startClass == "");
            return startClass;
        }
        public string tempArmor(string startClass)//named temp armor as it will need to be moved at a later build.
        {
            do
            {
                switch (startClass)/*The data stored in the armor switch, class switch, and weapon switch needs
                         	                to be migrated from the charAppear object to a "TBD" object.*/
                {
                    case "1":
                        {
                            startArmor = "Plate Armor";
                            //charAppear.startWeapon = "Sword";
                            //charAppear.startWeapon = "Rusty Bronze Sword";
                            break;

                        }
                    case "2":
                        {
                            startArmor = "Leather";
                            //charAppear.startWeapon = "Bow";
                            //charAppear.startWeapon = "Cheap Pine Bow";
                            break;
                        }
                    case "3":
                        {
                            startArmor = "Robe";
                            //charAppear.startWeapon = "Basic Spell";
                            //charAppear.startWeapon = "Fury of the Grass";
                            break;
                        }
                    default:
                        {
                            narraText.introScrawl(narraText.textStore(28));
                            break;
                        }

                }

            } while (startArmor == "");
            return startArmor;
        }
    }
}
