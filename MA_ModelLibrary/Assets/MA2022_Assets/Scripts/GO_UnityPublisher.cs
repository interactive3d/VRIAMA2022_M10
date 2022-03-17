using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GO_UnityPublisher : MonoBehaviour
{
    public UnityEvent Published;

    public void Publish()
    {
        // THERE MUST BE SUBSCRIBER TO THE EVENT
        Published?.Invoke();
    }

}

// Color color = Random.ColorHSV();
