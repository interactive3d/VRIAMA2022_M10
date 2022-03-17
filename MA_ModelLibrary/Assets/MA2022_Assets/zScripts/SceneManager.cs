using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public string valueTxt;

    private void Start()
    {
        valueTxt = PresistentElements.Instance.volumeLevel.ToString();
    }

    public void GoToFirstScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("name1");
        PresistentElements.Instance.volumeLevel++;
    }

    public void GoToSecondScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("name2");
        PresistentElements.Instance.volumeLevel++;
    }
}
