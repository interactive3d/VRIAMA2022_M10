using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 
using TMPro;
using UnityEngine.SceneManagement; // this namespace is responsible for operations on the scene


public class LoaderManager : MonoBehaviour
{
    #region Variables to store

    public string userName;

    public TMP_InputField if_UName; // reference to the text field
    
    #endregion



    // 1. take text from the label and store it as userName variable
    // 2. when Load button is pressed I want to load a second scene


    #region Helper Functions
    // function to change the scene
    public void ChangeSceneTo(string newSceneName)
    {
        SceneManager.LoadScene(newSceneName);
    }

    public void ChangeSceneToIndex(int sceneIndex)
    {
        UpdateTheName();
        SceneManager.LoadScene(1);
    }

    public void UpdateTheName()
    {
        // reference to text fild
        userName = if_UName.text;
        Debug.Log("The name is: " + userName);


        PlayerPrefs.SetString("CurrentUserName", userName); // this will create a Windows Registry Key to store the data

    }


    #endregion
}
