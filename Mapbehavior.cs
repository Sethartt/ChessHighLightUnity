using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapbehavior : MonoBehaviour
{
    private Color startColor;

    Renderer rend;

    

    // Start is called before the first frame update
    void Start()
    { 
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }


    void Update()
    {
        
    }



    void OnMouseEnter()
    {
        rend.material.color = Color.blue;
        
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    public void SetStartColor()
    {
        rend.material.color = startColor;
    }
}
