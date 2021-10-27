using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneScript : MonoBehaviour
{
    private bool hasDrink;

    private Verre _verre;
    // Start is called before the first frame update
    void Start()
    {
        hasDrink = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        hasDrink = true;
        _verre = other.GetComponent<Verre>();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        hasDrink = false;
    }

    public bool GetHasDrink()
    {
        return hasDrink;
    }

    public Verre GetVerre()
    {
        return _verre;
    }
}
