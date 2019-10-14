using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnBehavior : MonoBehaviour
{
    private Outline outline;
    private GameObject[] otherPawns;
    private Mapbehavior MB;
    public bool isActive;
    public PawnStatus PS;
    void Start()
    {
        MB = gameObject.GetComponent<Mapbehavior>();
        PS = gameObject.GetComponent<PawnStatus>();
        outline = gameObject.GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");

        otherPawns =  GameObject.FindGameObjectsWithTag("Pawns");
        foreach (var item in otherPawns)
        {
            item.GetComponent<Outline>().enabled = false;
            item.GetComponent<PawnBehavior>().isActive = false;
        }
        outline.enabled = true;
        isActive = true;
        StartColor();
        HighLightMove();
        HighLightAttack();
    }

    public void HighLightMove()
    {


        int x = PS.GetXPos();
        int y = PS.GetYPos();
        y += 1;
        GameObject field = GameObject.Find(string.Concat(x, y));
        field.GetComponent<Renderer>().material.color = Color.green;

    }

    public void HighLightAttack()
    {

        int x = PS.GetXPos();
        int y = PS.GetYPos();
        x += 1;
        y += 1;
        GameObject field = GameObject.Find(string.Concat(x, y));
        field.GetComponent<Renderer>().material.color = Color.red;

    }
    private static void StartColor()
    {
        GameObject[] otherFields = GameObject.FindGameObjectsWithTag("Field");
        foreach (var item in otherFields)
        {
            item.GetComponent<Mapbehavior>().SetStartColor();
        }
    }

    
}
