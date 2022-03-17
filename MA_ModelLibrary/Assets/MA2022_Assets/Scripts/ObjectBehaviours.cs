using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviours : MonoBehaviour
{
    public GameObject[] myObject; // this will be storing the reference to the object

    public bool colorChanger;
    public bool rotateChanger;
    public bool moveChanger;
    public bool transparentChanger;


    void OnEnable()
    {
        if (colorChanger)
        {
            GO_Publisher.OnClicked += ChangeColorToRandom;
        }
        if (rotateChanger)
        {
            GO_Publisher.OnClicked += RotateTheObject;
        }
        if (moveChanger)
        {
            GO_Publisher.OnClicked += MoveTheObject;
        }
        if (transparentChanger)
        {
            GO_Publisher.OnClicked += ChangeTransparency;
        }


    }
    void OnDisable()
    {
        if (colorChanger)
        {
            GO_Publisher.OnClicked -= ChangeColorToRandom;
        }
        if (rotateChanger)
        {
            GO_Publisher.OnClicked -= RotateTheObject;
        }
        if (moveChanger)
        {
            GO_Publisher.OnClicked -= MoveTheObject;
        }
        if (transparentChanger)
        {
            GO_Publisher.OnClicked -= ChangeTransparency;
        }
    }

    private GameObject myGO;

    private void Start()
    {
        myGO = gameObject;
    }
    

    public void ChangeColorToRandom()
    {
        // on Cylinder
        // GameObject myGO = gameObject; myObject[3];
        

        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        Color newRandomColor = new Color(r, g, b);

        myGO.GetComponent<Renderer>().material.color = newRandomColor; // check if will work

    }

    public void ChangeTransparency()
    {
        // on the sphere
        // GameObject myGO = myObject[1];
        

        // myGO.GetComponent<Renderer>().material.renderQueue = (int) UnityEngine.Rendering.RenderQueue.Transparent;
        // myGO.GetComponent<Renderer>().material.EnableKeyword("_ALPHABLEND_ON");
        transparentChanger = !transparentChanger;
        if (transparentChanger)
        {
            StanderdShaderUtils.ChangeRenderMode(myGO.GetComponent<Renderer>().material, StanderdShaderUtils.BlendMode.Transparent);
        }
        else
        {
            StanderdShaderUtils.ChangeRenderMode(myGO.GetComponent<Renderer>().material, StanderdShaderUtils.BlendMode.Opaque);
        }
        


    }

    public void MoveTheObject()
    {
        // this wil be exectured on the capsule
        // GameObject myGO = myObject[2];
        
        Vector3 newPostion = new Vector3(0, 0, 2);

        iTween.MoveBy(myGO, newPostion, 2f);

    }

    public void RotateTheObject()
    {
        // this will be triggered on event but if the object is CUBE
        // GameObject myGO = myObject[0];
        
        Vector3 newRotation = new Vector3(60f, 80f, 60f);
        iTween.RotateBy(myGO, newRotation, 2f);

    }





}
