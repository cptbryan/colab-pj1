using System;

public class charAtts
{
    public string gender;//variable declaration
    public string hairColor;
    public string armor;
    public int armorStrength;
    public string startWeapon;
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
   public string Armor
            {
                get
                    {
                        return armor;
                    }
                set
                    {
                        armor = value;
                    }
            }
    public int ArmorStrength
            {
                get
                    {
                        return armorStrength;
                    }
                set
                    {
                        armorStrength = value;
                    }
            }
    public string startClass
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
    public string startWeapon
    {
        get
        {
            return startWeapon;
        }
        set
        {
            startWeapon = value;
        }
    }

}

