using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_Singleton : MonoBehaviour
{
    // SINGLETON EXAMPLE
    // design pattern
    // allow to have one instance of designed class
    // design content used on classes that are to be like a managers
    // only on object that have ONLY ONE INSTANCE
    // reference video: https://youtu.be/Y6cKPfUTrsA
    // elements to mention
    // [HideInInspector]


    // create a structure
    private static ex_Singleton _instance; // we create object
    private static ex_Singleton Instance
    {
        get
        {
            // logic to make sure if it does not exist we create it
            if(_instance != null)
            {
                GameObject MyManager = new GameObject("MyManager");
                MyManager.AddComponent<ex_Singleton>();
            }
            return _instance; // return itself;
        }
    }

    private void Awake()
    {
        _instance = this;
    }


    #region STORED VARIABLES

    public int QualityLevelSv { get; set; };
    public float VolumeLevelSv { get; set; };
    public bool MuteStateSv { get; set; };

    #endregion

    #region STARTING VALUES
    private void Start()
    {
        QualityLevelSv = 3;
        VolumeLevelSv = 0.5f;
        MuteStateSv = false;
    }
    #endregion



    void SingletonPattern()
    {
        if(_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    public void MyManagerFunction1()
    {
        // doing something like i.e. change audio
    }

}
