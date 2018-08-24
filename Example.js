var mentalThreshold;
var bankAccountBalance;
var phoneCount;
var accessCount = 0;
const TAX_RATE = .07;
var phonePrice = 99.99;
const ACCESSORY_PRICE = 24.99;

function phonePurchase()
{
    bankAccountBalance = prompt("What is your bank account balance?");//User enters in account balance.
    mentalThreshold = prompt("What is the max you are willing to spend on each phone?");//User enters in max amount to spend per phone.

    if((phonePrice < bankAccountBalance) && (phonePrice < mentalThreshold))//This is a verification statement that confirms that the user's inputted data meets the program's required parameters to run.
    {
        while(phonePrice < bankAccountBalance)
        {
            while(phonePrice + ACCESSORY_PRICE < mentalThreshold)
                {
                    phonePrice+=ACCESSORY_PRICE;
                    accessCount++;    
                }
            phoneCount += 1; 
            console.log(phonePrice);
        }
        phonePrice = phonePrice + (accessCount * ACCESSORY_PRICE);
        console.log("You have puchased " + phoneCount + " phones, each with " + accessCount + " accessories.");
        bankAccountBalance = bankAccountBalance - phonePrice;
        console.log("You have " + bankAccountBalance + " left in your account.");
    }
    else
    {
        console.log("I'm sorry, but the phone is out of your price range.");
    }
    
    
}

phonePurchase();

while(phonePrice < mentalThreshold)
            {
                accessCount += 1;   
                phonePrice += ACCESSORY_PRICE;
            } 