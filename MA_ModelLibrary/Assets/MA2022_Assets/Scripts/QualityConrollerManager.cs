using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QualityConrollerManager : MonoBehaviour
{
    // 1. I want to know what is the current quality level
    // 2. I want to know how many quality levels exist in this app
    // then based on that I will be able to change to either higher level or lover level in the available range
    // 
    // string[] names = QualitySettings.names;
    // QualitySettings.SetQualityLevel(i, true);
    // QualitySettings.IncreaseLevel(false);
    // 
    //
    #region Variables

    public int currentQualityLevel; // this variable will store the current index of the quality level
    public int totalNumeberOfQualityLevels;

    public bool decreaseQlty, increaseQlty, checkQualityLevel;

    public Slider qualitySliderObj;

    #endregion

    #region MainFunctions
    private void Start()
    {
        // check if the slider is correctly references
        if (qualitySliderObj == null)
        {
            Debug.Log("No reference to the slider");
        }

        // we will read the current quality level here
        string[] qualityLevelNames = QualitySettings.names;
        totalNumeberOfQualityLevels = qualityLevelNames.Length; // how many in total there are quality levels based on the lenght of the array
        CheckCurrentQualityLevel();

        SetSliderValues(qualitySliderObj, 0f, (float) totalNumeberOfQualityLevels-1, (float) currentQualityLevel);


    }


    private void Update()
    {
        // ONLY FOR TESTING PURPOSES
        // TO REMOVE IN THE FINAL APP TO REDUCE THE UPDATE CODE NEED
        if (decreaseQlty)
        {
            decreaseQlty = !decreaseQlty;
            DecreaseQualityLevel();
        }
        if (increaseQlty)
        {
            increaseQlty = !increaseQlty;
            IncreaseQualityLevel();
        }
        if (checkQualityLevel)
        {
            checkQualityLevel = !checkQualityLevel;
            CheckCurrentQualityLevel();
        }
    }

    #endregion



    #region Helper Functions

    public void ChangeQualityLevel()
    {
        ChangeQualityLevel((int) qualitySliderObj.value);
    }
    
    // changes the quality of the scene to specific value
    public void ChangeQualityLevel(int qualityLevel)
    {
        if (qualityLevel >= 0 && qualityLevel <= (totalNumeberOfQualityLevels-1))
        {
            QualitySettings.SetQualityLevel(qualityLevel);
            // now the quality will be set to the level selected
        }
        else
        {
            Debug.Log("I can't setup that quality level - it does not exist.");
        }
    }

    // increase the scene quality by +1 level
    public void IncreaseQualityLevel()
    {
        QualitySettings.IncreaseLevel();
    }


    // decrease the scene quality by 1 level
    public void DecreaseQualityLevel()
    {
        QualitySettings.DecreaseLevel();
    }

    // checking and returning the index of the current quality level
    public int CheckCurrentQualityLevel()
    {
        currentQualityLevel = QualitySettings.GetQualityLevel();
        Debug.Log("Current Quality Level is " + currentQualityLevel);
        Debug.Log("Current quality level name is" + QualitySettings.names[currentQualityLevel]);
        return currentQualityLevel;
    }

    // generic helper function to deal with the max, min and value of any slider in the UI
    // please note that the values are Float but this is the default information about the fields like min, max and value.


    public void SetSliderValues(Slider refSlider, float minSliderValue, float maxSliderValue, float startSliderValue)
    {
        refSlider.minValue = minSliderValue; // to set the minimal value of the slider
        refSlider.maxValue = maxSliderValue; // to set the maximal value of the slider
        refSlider.value = startSliderValue; // to set the starting value of the sldier
        Debug.Log("Values on the slider updated");
    }


    #endregion



}
