using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 80.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        //If the coffee's temperature is greater that the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTemperature)
        {
            //... do this.
            print("Coffee is too hot.");
        }
        //If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if(coffee < coldLimitTemperature)
        {
            //...do this.
            print("Coffee is too cold.");
        }
        //If it is neither of those then...
        else
        {
            //... do this.
            print("Coffee is just right.")
        }
    }
}  