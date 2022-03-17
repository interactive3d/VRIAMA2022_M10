using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalSceneManager : MonoBehaviour
{
    // create singleton pattern
    public static GlobalSceneManager Instance { get; internal set; }

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (Instance!=this)
        {
            Destroy(this);
        }
    }



    public string UserName { get; set; }         // this will store the UserName as the sting
    public int QualityLevel { get; set; }                    // this will store the Current Quality Level
    public float VolumeLevel { get; set; }                      // this will store the Volume Level
    public bool MuteState { get; set; }          // this will store the state of the mute if true the audio will be muted if false will play


    private void Start()
    {
        UserName = "MOROCCO";
        QualityLevel = 3;
        VolumeLevel = 0.5f;
        MuteState = false;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }


    // add functonality to save the preferences to the file (external file) 


}