using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdv
{
    class armor
    {
        public string startArmor;
        public int armorStrength;
        public string startWeapon;
        public string startClass;

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
                            narraText.introScrawl(narraText.textStore(8));
                            startClass = "Loser";
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
                            startArmor = "Robes";
                            //charAppear.startWeapon = "Basic Spell";
                            //charAppear.startWeapon = "Fury of the Grass";
                            break;
                        }
                    default:
                        {
                            narraText.introScrawl(narraText.textStore(10));
                            startArmor = "Chiffon gown";
                            break;
                        }

                }

            } while (startArmor == "");
            return startArmor;

        }
    }
}