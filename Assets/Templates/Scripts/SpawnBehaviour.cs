using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.UIElements;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    
    public GlassScriptableObject[] MesShots;

    public Verre verre;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnVerre), 0f, 0.5f);
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
        verre.Texture = MesShots[chance].texture;
        verre.GetComponent<SpriteRenderer>().sprite = verre.Texture;


    }

    public void SpawnVerre()
    {
        Randomiser();
        Instantiate(verre, gameObject.transform.position, gameObject.transform.rotation);
    }
}