using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_Publisher : MonoBehaviour
{
    public delegate void MyCSharpEvent();

    public MyCSharpEvent realeasedNewContent;

    public void Publish()
    {
        realeasedNewContent?.Invoke();
    }
}
