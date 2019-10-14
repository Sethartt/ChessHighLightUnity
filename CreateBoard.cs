using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreateBoard : MonoBehaviour
{
    public PawnStatus PS;
    public GameObject blackField;
    public GameObject whiteField;
    private GameObject currentField;

    public GameObject Pawn;
    public GameObject Tower;
    public GameObject Bishop;
    public GameObject Horse;
    public GameObject King;
    public GameObject Queen;

    private int numberOfColumns = 8;
    private int numberOfRows = 8;
    private bool flagForColors = false;




    void Start()
    {
        BuildBoard();
        InstantiatePawns();
    }


    private void BuildBoard()
    {
        for (int j = 0; j < numberOfRows; j++)
        {
            for (int i = 0; i < numberOfColumns; i++)
            {
                Vector3 pos = new Vector3(i, 0, j);
                if (flagForColors)
                {
                    currentField = Instantiate(whiteField, pos, Quaternion.identity);
                    flagForColors = !flagForColors;
                    currentField.name = string.Format("{0}{1}", i, j);
                    
                }
                else
                {
                    currentField = Instantiate(blackField, pos, Quaternion.identity);
                    flagForColors = !flagForColors;
                    currentField.name = string.Format("{0}{1}", i, j);
                }
            }
            flagForColors = !flagForColors;
        }
    }

    private void InstantiatePawns()
    {
        for(int i=0 ; i<8; i++)
        {
            var pawn = Instantiate(Pawn, new Vector3(0 + i, 0.5f, 1), Quaternion.Euler(-90, 0, 0));
            var outline = pawn.AddComponent<Outline>();
            PS = pawn.GetComponent<PawnStatus>();
            PS.SetXPos(i);
            PS.SetYPos(1);
            outline.OutlineMode = Outline.Mode.OutlineAll;
            outline.OutlineColor = Color.yellow;
            outline.OutlineWidth = 5f;
            outline.enabled = false;
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
