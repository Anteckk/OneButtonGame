using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "shot", menuName = "new shot")]
    public class GlassScriptableObject : ScriptableObject
{
    public int type;
    public int point;
    public bool subtractLife;
    public Sprite texture;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
