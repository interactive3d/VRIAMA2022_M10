using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectUnityBehaviours : MonoBehaviour
{
    public GO_UnityPublisher publisher;

    private void OnEnable()
    {
        publisher?.Published.AddListener(ChangeColor);
    }

    private void OnDisable()
    {
        publisher?.Published.RemoveListener(ChangeColor);
    }

    public void ChangeColor()
    {

    }


}
