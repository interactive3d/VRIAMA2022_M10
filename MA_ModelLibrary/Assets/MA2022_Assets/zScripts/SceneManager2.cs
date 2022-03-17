using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; // to use elements from that class

public class SceneManager2 : MonoBehaviour
{
    public Text myNameLabel;
    public TMP_Text theNewLabel;

    private void Start()
    {
        // myNameLabel.text = PlayerPrefs.GetString("CurrentUserName");
        // theNewLabel.text = PlayerPrefs.GetString("CurrentUserName");
        // theNewLabel.text = PlayerPrefs.GetString("CurrentUserName");

        // myNameLabel.text = GlobalSceneManager.Instance.UserName;
        // theNewLabel.text = GlobalSceneManager.Instance.UserName;

        // Invoke("ChangeValue", 5f);

    }

    void ChangeValue()
    {
        // GlobalSceneManager.Instance.UserName = "Marcin";
        // theNewLabel.text = GlobalSceneManager.Instance.UserName;
    }

    
}
