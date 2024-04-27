using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUIAfterSound : MonoBehaviour
{
    public AudioSource audioSource;
    public Button button;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        button.gameObject.SetActive(false);    
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            AfterSound();
        }
    }


    void AfterSound()
    {
        button.gameObject.SetActive(true);
        Debug.Log("Do Something After Audio Finished Playing.");
        this.gameObject.SetActive(false);
    }
}