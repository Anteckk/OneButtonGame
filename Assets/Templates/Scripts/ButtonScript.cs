using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject zone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrinkShot()
    {
        if (zone.GetComponent<ZoneScript>().GetHasDrink())
        {
            Debug.Log("##### SHOT #####");
        }
        else
        {
            Debug.Log("##### NO DRINK ######");
        }
    }
}
