using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ex_InputSystem : MonoBehaviour
{

    public Text logTextLabel;

    // touch count
    private void Update()
    {
        logTextLabel.text = Input.touchCount.ToString();
    }


    // touch Detection


    public int trackedTouch;
    
    void TouchDetectionUpdate()
    {
        if  (Input.touchCount > trackedTouch)
        {
            transform.position = Input.GetTouch(trackedTouch).position;
        }
    }


    // identification
    public int trackedFingerID;


    void FingerIDTrackerUpdate()
    {
        int touchCount = Input.touchCount;

        for (int i=0; i<touchCount; i++)
        {
            if (Input.GetTouch(i).fingerId == trackedFingerID)
            {
                transform.position = Input.GetTouch(i).position;
                break;
            }
        }
    }
}

