using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ShowTextAfterVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject text;
    public bool isPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!videoPlayer.isPlaying && isPlaying)
        {
            isPlaying = false;
            AfterVideo();
        }
    }

    void AfterVideo()
    {
        text.SetActive(true);
        Debug.Log("Do Something After Video Finished Playing.");
        
    }
}
