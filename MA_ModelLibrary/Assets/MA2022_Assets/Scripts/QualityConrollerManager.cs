using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QualityConrollerManager : MonoBehaviour
{
    // 1. I want to know what is the current quality level
    // 2. I want to know how many quality levels exist in this app
    // then based on that I will be able to change to either higher level or lover level in the available range

    #region Variables

        private int currentQualityLevel; // this variable will store the current index of the quality level

    #endregion

    #region MainFunctions
    private void Start()
    {
        // we will read the current quality level here


    }
    #endregion



    #region Helper Functions

    public void ChangeQualityLevel(int qualityLevel)
    {

    }

    public void IncreaseQualityLevel()
    {

    }


    public void DecreaseQualityLevel()
    {

    }


    #endregion



}
