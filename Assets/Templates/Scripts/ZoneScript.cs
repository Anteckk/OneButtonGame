using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneScript : MonoBehaviour
{
    private bool hasDrink;
    // Start is called before the first frame update
    void Start()
    {
        hasDrink = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        hasDrink = true;
    }

    private void OnTriggerExit(Collider other)
    {
        hasDrink = false;
    }

    public bool GetHasDrink()
    {
        return hasDrink;
    }
}
