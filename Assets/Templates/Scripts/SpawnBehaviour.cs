using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    
    public GlassScriptableObject[] MesShots;

    public Verre verre;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnVerre), 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Randomiser()
    {
        int chance = Random.Range(0, 3);
        verre.Type = MesShots[chance].type;
        verre.Points = MesShots[chance].point;
        verre.SubtractLife = MesShots[chance].subtractLife;
        
    }

    public void SpawnVerre()
    {
        Randomiser();
        Instantiate(verre, gameObject.transform.position, gameObject.transform.rotation);
    }
}