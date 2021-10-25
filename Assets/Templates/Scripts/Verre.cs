using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Verre : MonoBehaviour
{

    public int Type;
    public int Points;
    public bool SubtractLife;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * 3 * Time.deltaTime;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
