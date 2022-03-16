using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerManager : MonoBehaviour
{
    // function to mute and unmute

    // function to change the Volume based on the sldier value

    // save the values for use in other scenes

    // setup the audio on start




    // #########  VARIABLE DECLARATIONS #########


    #region Variables

    public GameObject audioSourceGO; // this will be a reference to the audio source
    public AudioSource audioComponent;

    [Range (0,1)]
    public float volumeLevel; // the value from the slider that will change

    private bool isAudioMutted;

    #endregion

    #region MainFunctions

    private void Awake()
    {
        if(audioSourceGO == null)
        {
            Debug.Log("There is no audio source GameObject assigned. So I assign myself to it");
            audioSourceGO = gameObject;
        }
    }

    private void Start()
    {
        isAudioMutted = false; // this will make the audio play at the start of the application
        audioComponent = audioSourceGO.GetComponent<AudioSource>();
        audioComponent.Play();

    }
    #endregion

    #region HelperFunctions

    // this will trigger the mute of the audio on the audioComponent assigned
    public void MuteTheAudio(bool audioMute)
    {
        audioComponent.mute = audioMute;
    }

    // this function is to set the volume level on the audio source
    public void SetVolumeLevel(float volumeLevel)
    {
        audioComponent.volume = volumeLevel;
    }


    #endregion


}
