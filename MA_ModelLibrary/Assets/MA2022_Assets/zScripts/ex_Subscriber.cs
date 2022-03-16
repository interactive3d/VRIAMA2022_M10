using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_Subscriber : MonoBehaviour
{
    public ex_Publisher publisher;

    public bool watchedAll, watchedSports, watchedNews;

    private void OnEnable()
    {
        if (watchedAll)
        {
            publisher.realeasedNewContent += WatchAll;
        }
        if (watchedSports)
        {
            publisher.realeasedNewContent += WatchSports;
        }

        if (watchedNews)
        {
            publisher.realeasedNewContent += WatchNews;
        }
    }

    private void OnDisable()
    {
        if (watchedAll)
        {
            publisher.realeasedNewContent -= WatchAll;
        }
        if (watchedSports)
        {
            publisher.realeasedNewContent -= WatchSports;
        }

        if (watchedNews)
        {
            publisher.realeasedNewContent -= WatchNews;
        }
    }


    public void WatchAll()
    {
        Debug.Log(" watched all");
    }
    public void WatchSports()
    {
        Debug.Log(" watched sports");
    }
    public void WatchNews()
    {
        Debug.Log(" watched news");
    }
}
