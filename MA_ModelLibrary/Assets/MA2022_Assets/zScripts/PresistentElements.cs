using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresistentElements : MonoBehaviour
{

    public static PresistentElements Instance { get; private set; }
    public int volumeLevel;

    private void Awake()
    {
        if(Instance == null) // this to prevent from the start at all for the first time of the start of the app
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
