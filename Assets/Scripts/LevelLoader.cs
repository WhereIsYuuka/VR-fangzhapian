using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    // Start is called before the first frame update
    
    public void LoadNextLevel()
    {
        transition.SetTrigger("Start");
        //StartCoroutine(LoadLevel());
    }

    // IEnumerator LoadLevel()
    // {
    //     transition.SetTrigger("Start");
    //     yield return new WaitForSeconds(transitionTime);
    // }
}
