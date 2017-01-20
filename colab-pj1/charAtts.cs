using System;

public class charAtts
{
    public string gender;//variable declaration
    public string hairColor;
    public string armor;
    public int armorStrength;
    public string playerMainWeapon;
    //------------------------------------------>
    public string Gender//access modifiers
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
    public string PlayerMainWeapon
            {
                get
                    {
                        return playerMainWeapon;
                    }
                set
                    {
                        playerMainWeapon = value;
                    }
            }

}

