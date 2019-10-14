using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnStatus : MonoBehaviour
{

    public bool IsAlive;

    private int xPos;
    public int GetXPos()
    {
        return xPos;
    }
    public void SetXPos(int x)
    {
        x = Mathf.Clamp(x, 0, 7);
        xPos = x;
    }

    private int yPos;
    public int GetYPos()
    {
        return yPos;
    }
    public void SetYPos(int y)
    {
        y = Mathf.Clamp(y, 1, 8);
        yPos = y;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
