using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour
{
    public GameObject[] myObjects; // reference to all prefabs and object

    public Transform[] myPositions; // positions on the carouselle

    public int posVariant = 0;


    private int objectCount;
    private int positionCount;
    private int newIndexOfPos;

    private void Start()
    {
        positionCount = myPositions.Length;
        objectCount = myObjects.Length;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            posVariant++;
            if(posVariant>=positionCount)
            {
                posVariant = 0;
            }
            Debug.Log("Variant: " + posVariant);
            SetPosition(posVariant);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            posVariant--;
            if (posVariant < 0)
            {
                posVariant = positionCount-1;
            }
            SetPosition(posVariant);
        }

    }

    public void SetPosition(int posVariant)
    {   
        if (objectCount <= positionCount)
        {
            
            for (int i=0; i<objectCount; i++)
            {
               newIndexOfPos = (posVariant + i) % positionCount;

               //myObjects[i].transform.position = myPositions[newIndexOfPos].position;

                iTween.MoveTo(myObjects[i], myPositions[newIndexOfPos].position, 1);
               
               Debug.Log("ObjID: " + i + " goes to pos id: " + newIndexOfPos);
            }
        }
    }
}
