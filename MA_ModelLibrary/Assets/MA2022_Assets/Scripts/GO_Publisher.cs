using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Publisher : MonoBehaviour
{
    public delegate void ClickAction();

    public static event ClickAction OnClicked; // defining the Event in C#

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Trigger action");
            if (OnClicked != null)
            {
                OnClicked();
            }
            
        }
    }




}
